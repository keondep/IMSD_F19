using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour


{
    bool gamehasended = false;
    public GameObject completelevelui;

    public void completelevel()
    {
        completelevelui.SetActive(true);
        Debug.Log("level won");
    }
    public void Endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            restart();
        }

         
    }
    void restart()
    {
        SceneManager.LoadScene("level1");
    }

}
