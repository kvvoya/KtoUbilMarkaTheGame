using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    const string domScene = "Dom";
    const string dorogaScene = "Doroga";
    const string oprosnikiScene = "Oprosniki";

    public void GoToRoomA()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case domScene:
                SceneManager.LoadScene(dorogaScene);
                break;
            case oprosnikiScene:
                SceneManager.LoadScene(domScene);
                break;
            default:
                return;
        }
    }

    public void GoToRoomB()
    {
        if (SceneManager.GetActiveScene().name == domScene)
        {
            SceneManager.LoadScene(oprosnikiScene);
        }
        else if (SceneManager.GetActiveScene().name == dorogaScene)
        {
            SceneManager.LoadScene(domScene);
        }
    }
}
