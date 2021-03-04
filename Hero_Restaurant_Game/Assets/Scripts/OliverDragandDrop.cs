﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OliverDragandDrop : MonoBehaviour, IDragHandler
{
    private Collider2D DragObject;
    private Collider2D GreenTrigger;
    private RectTransform rectTransform;
    private bool isDragging;
    private bool GreenScreen;
    public int Organizer;

    public void Awake()
    {
        DragObject = gameObject.GetComponent<Collider2D>();
        GreenTrigger = GameObject.Find("GreenTrig").GetComponent<Collider2D>();
    }

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }
    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);

            if(DragObject.bounds.Intersects(GreenTrigger.bounds))
            {
                GreenScreen = true;
            }
            else {
                GreenScreen = false;
            }
        }
/*
        if (transform.position.y > 3.5)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        if (transform.position.x > 7.8)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        if (transform.position.y < -1.5)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        if (transform.position.x < 1)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
*/

    }
}