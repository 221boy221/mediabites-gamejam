using UnityEngine;
using System.Collections;

public class DeadMenuScript : MonoBehaviour {
    public void StartButton()
    {
        Application.LoadLevel("KevinScene");
    }

    public void Back()
    {
        Application.LoadLevel("KevinMenu");
    }
}
