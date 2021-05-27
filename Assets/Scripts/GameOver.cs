using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        unpauseGame();



    }

    // Update is called once per frame
    void Update()
    {


        if (GameObject.FindGameObjectWithTag("Player")== null)
        {
            gameOverPanel.SetActive(true);
            // score.SetActive(false);
            score.transform.position = new Vector4(545, 980, 0);
            pauseGame();
            

        }


    }

    public void pauseGame()
    {

        
            Time.timeScale = 0;
            
        
    }

    public void unpauseGame()
    {

        Time.timeScale = 1;
        
    }




        public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
