using UnityEngine;
using System.Collections;

public class DeadMenuScript : MonoBehaviour {
    public void StartButton()
    {
        Application.LoadLevel("Game");
    }

    public void Back()
    {
        Application.LoadLevel("Menu");
    }
}
