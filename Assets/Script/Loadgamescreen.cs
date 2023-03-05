using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadgamescreen : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("Gamescreen");
    }
}
