using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OliverDragandDrop : MonoBehaviour, IDragHandler{
    [SerializeField] public Canvas size;
    private Collider2D DragObject;
    private Collider2D GreenTrigger;
    private RectTransform rectTransform;
    private bool isDragging;
    private bool GreenScreen;
    public int Organizer;

    public void Awake()
    {
        Collider2D collider2D1 = gameObject.GetComponent<Collider2D>();
        DragObject = collider2D1;
        GreenTrigger = GameObject.Find("GreenTrigger").GetComponent<Collider2D>();
    }

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / size.scaleFactor;
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
    }
}