using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private bool isMuted;

    // Start is called before the first frame update
    void Start()
    {
        isMuted = false;

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }
    public void MuteDePressed()
    {
        isMuted = false;

        AudioListener.pause = isMuted;
    }


    public void PlayGame()
    {
        MuteDePressed();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void mmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
        MutePressed();
    }
}
