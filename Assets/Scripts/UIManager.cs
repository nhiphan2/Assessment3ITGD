using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        // Load the WalkingScene while preverving this game object
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1);
    }
}
