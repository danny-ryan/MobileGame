using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private GameObject player;
    public GameObject rightButtons;
    public GameObject leftButtons;
    public GameObject menu;
   

    bool leftlane = false;
    bool rightlane = false;

    void Start()
    {
    }

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    
        float Z = player.transform.position.z;
        float Y = player.transform.position.y;
        float X = player.transform.position.x;
        if (X == 2)
        {
            rightlane = true;
        }
        else
        {
            rightlane = false;
        }
        if (X == -2)
        {
            leftlane = true;
        }
        else
        {
            leftlane = false;
        }
        if (Time.timeScale == 1)
        {
            rightButtons.SetActive(true);
            leftButtons.SetActive(true);
        }
        else
        {
            rightButtons.SetActive(false);
            leftButtons.SetActive(false);
        }
        
    }
    


    public void rightButton()
    {
        float Z = player.transform.position.z;
        float Y = player.transform.position.y;
        float X = player.transform.position.x;
        if (!rightlane)
        {
            player.transform.position = new Vector3(X + 2, Y, Z);
        }
    }

    public void leftButton()
    {
        float Z = player.transform.position.z;
        float Y = player.transform.position.y;
        float X = player.transform.position.x;
        if (!leftlane)
        {
            player.transform.position = new Vector3(X - 2, Y, Z);
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void CharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }

    void SetActiveOnLoad()
    {

    }
}
