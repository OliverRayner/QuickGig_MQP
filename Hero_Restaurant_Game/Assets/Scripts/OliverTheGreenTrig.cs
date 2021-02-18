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
    static int NumFinders = 0;       
    void Awake()
    {
        GreenTrigger = gameObject.GetComponent<Collider2D>();
    }
    public void Update()
    {
        int EmptyPlate = 0;
        GameObject[] FoodObjects = GameObject.FindGameObjectsWithTag("Drag");
        foreach (GameObject Drag in FoodObjects)
        {
            Collider2D foodCollider = Drag.GetComponent<Collider2D>();
            if (foodCollider.bounds.Intersects(GreenTrigger.bounds))
            {
                EmptyPlate += Drag.GetComponent<OliverDragandDrop>().Organizer;
            }
        }

        if (EmptyPlate == FoodTotal && LoopNumber.text == OrderNumber.text)
        {
            string[] scenes = {"GameFirst","GameSecond","GameThird","GameFourth",
        "GameFifth","GameSixth","GameSeventh","GameEighth","GameNinth","GameTenth",
        "GameEleventh","GameTwelfth","GameThirteenth","GameFourteenth","GameFifteenth"};


            int answer = Random.Range(0, 14);

            string show = scenes[answer];

            SceneManager.LoadScene(show);

            NumFinders += 1;
        }

        if (NumFinders == 10)
        {
            SceneManager.LoadScene("DinnerWinner");
            NumFinders = 0;
        }
    }

}