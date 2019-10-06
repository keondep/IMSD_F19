
using UnityEngine;
public class endgame : MonoBehaviour {

    public gamemanager GameManager;


    void OnTriggerEnter()
    {
        GameManager.completelevel();
    }


}
