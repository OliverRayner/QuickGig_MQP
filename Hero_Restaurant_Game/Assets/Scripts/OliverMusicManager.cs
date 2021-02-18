using UnityEngine;


public class OliverMusicManager : MonoBehaviour
{

    private static OliverMusicManager musicManagerInstance;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (musicManagerInstance == null){
            musicManagerInstance = this;
        }
        else{
            Destroy(gameObject);
        }
    }

}
