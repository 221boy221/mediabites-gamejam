using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour {
    [SerializeField]
    private GameObject Setingspanel;
    [SerializeField]
    private GameObject Menupanel;
    AudioSource audio;
    public void start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void StartButton()
    {
        Application.LoadLevel("Game");
    }

    public void Setings()
    {
        if(Setingspanel.active == false)
        {
            Setingspanel.SetActive(true);
            Menupanel.SetActive(false);
        }
    }

    public void Back()
    {
        if(Menupanel.active == false)
        {
            Setingspanel.SetActive(false);
            Menupanel.SetActive(true);
        }
    }

    public void Credits()
    {
        Application.LoadLevel("CreditsScrene");
    }
 
    public void MuteSound()
    {
    }

    public void MuteMusic()
    { 
        //mute music
    }
}
