using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int savedSceneIndex = 0;
    public static PlayerManager _instance;
    private void Awake()
    {
        
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            _instance = this;
        }
    }
}
