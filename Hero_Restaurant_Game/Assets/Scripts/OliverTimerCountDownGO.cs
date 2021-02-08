using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
     

public class OliverTimerCountDownGO : MonoBehaviour
{
    public int countDownStartValue = 20;
    public Text timerUI;
    public float delayTime = 5.0f;
    
    public void Restart() {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName); // loads current scene
    }
    

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            timerUI.text = "Time Left : " + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }

        else
        {
            Wait();
        }

    }

private async void WaitFor5Seconds()
    {
//      await System.Threading.Tasks.Task.Delay(2);
        await System.Threading.Tasks.Task.Delay(5000);
 
    }
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }  
    }

    void nextScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    void Wait()
    {
        nextScene();
        Invoke("nextScene", delayTime);
    }
}