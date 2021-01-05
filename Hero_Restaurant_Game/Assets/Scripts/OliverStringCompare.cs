using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OliverStringCompare : MonoBehaviour
{
    public Text orderString;
    public Text loopString;

    // Start is called before the first frame update
    void compare()
    {
        if (orderString.text == loopString.text)
        {
            SceneManager.LoadScene("DinnerWinner");
            Invoke("compare", 3.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        compare();
    }
}
