using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OliverTheGreenTrig : MonoBehaviour
{
    Collider2D GreenTrigger;
    public int FoodTotal;
    public Text LoopNumber;
    public Text OrderNumber;

    void Awake()
    {
        GreenTrigger = gameObject.GetComponent<Collider2D>();
    }
    public void Update()
    {
        // Update proposed solution
        if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
        {
            GameObject[] FoodObjects = GameObject.FindGameObjectsWithTag("Drag");
            int EmptyPlate = 0;

            foreach (GameObject Drag in FoodObjects)
            {
                Collider2D billCollider = Drag.GetComponent<Collider2D>();
                if (billCollider.bounds.Intersects(GreenTrigger.bounds))
                {
                    EmptyPlate += Drag.GetComponent<OliverDragandDrop>().Organizer;
                }
            }

            if (EmptyPlate == FoodTotal && LoopNumber.text == OrderNumber.text)
            {
                SceneManager.LoadScene("DinnerWinner");
            }
        }
    }
}