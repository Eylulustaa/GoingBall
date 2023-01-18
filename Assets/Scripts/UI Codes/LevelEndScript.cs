using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndScript : MonoBehaviour
{
    public static bool Level1, Level2, Level3;
    
    public void Level1Ending()
    {
        LevelEndScript.Level2 = true;
        SceneManager.LoadScene(2);
    }
    
    public void Level2Ending()
    {
        LevelEndScript.Level3 = true;
        SceneManager.LoadScene(3);
    }

    public void Level3Ending()
    {
        SceneManager.LoadScene(0);
    }
    
}
