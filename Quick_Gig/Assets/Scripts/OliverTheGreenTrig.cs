using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class OliverTheGreenTrig : MonoBehaviour
{
    Collider2D GreenTrigger;
    public int FoodTotal;
    public Text LoopNumber;
    public Text OrderNumber;
    public static int NumFinders = 0;
    private AudioClip correctSound;
    private AudioSource audioSource;
    private void Start(){
        correctSound = (AudioClip)Resources.Load("CorrectAnswer");
    }
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
            Changer();
        }

        if (NumFinders == 10)
        {
            SceneManager.LoadScene("QGDW");
            NumFinders = 0;
        }

        void Changer(){
            string[] scenes = {"QG1","QG2","QG3","QG4","QG5","QG6","QG7","QG8","QG9","QG10","QG11","QG12","QG13","QG14","QG15"};

            int answer = Random.Range(0,14);

            string show = scenes[answer];

            SceneManager.LoadScene(show);

            NumFinders += 1;

        }
/*
        IEnumerator PlayCorrectSound(){
            Changer();
            audioSource.clip = correctSound;
            audioSource.Play();
            yield return new WaitUntil(() => audioSource.isPlaying == false);
        }
        */
    }

}
/*

            audioSource.clip = correctSound;
            
            audioSource.Play();
            */