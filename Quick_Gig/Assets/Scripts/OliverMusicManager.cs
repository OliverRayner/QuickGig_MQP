using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OliverMusicManager : MonoBehaviour
{

    private static OliverMusicManager musicManagerInstance;
    void Update(){

    }
    // Start is called before the first frame update
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        DontDestroyOnLoad(this);

        if (musicManagerInstance == null){
            musicManagerInstance = this;
        }
        else if (sceneName == "QGDW")
        {
            Destroy(this);
        }
        else if (sceneName == "QGGO")
        {
            Destroy(this);
        }
        else{
            Destroy(gameObject);
        }
    }
    void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode){
        if (scene.name == "QGDW") {
            Destroy(this);
        }
        else if (scene.name == "QGGO"){
            Destroy(this);
        }
    }



}
