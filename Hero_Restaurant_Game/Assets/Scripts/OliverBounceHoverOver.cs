using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OliverBounceHoverOver : MonoBehaviour
{
    private bool bounce;
    
    // Start is called before the first frame update
    void Start()
    {
        bounce = true;
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        if (bounce)
        {
            StartCoroutine("StartBouncing");
        }
    }

    private IEnumerator StartBouncing()
    {
        bounce = false;

        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector2(
            (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.00001f, Mathf.SmoothStep(0f, 1f, i))),
            (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.00001f, Mathf.SmoothStep(0f, 1f, i))));
            yield return new WaitForSeconds(0.015f);
        }

        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector2(
            (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.00001f, Mathf.SmoothStep(0f, 1f, i))),
            (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.00001f, Mathf.SmoothStep(0f, 1f, i))));
            yield return new WaitForSeconds(0.015f);
        }

        bounce = true;
    }
}
