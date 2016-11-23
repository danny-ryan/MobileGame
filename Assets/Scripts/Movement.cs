using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    float thrust;

    private GameObject player;
    public GameObject scoreObject;

    Rigidbody rigid;

    bool leftlane = false;
    bool rightlane = false;

    void Start()
    {

        thrust = 15.0f;
        //rigid = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        transform.localPosition += transform.forward * thrust * Time.deltaTime;
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


        #region Score Stuffs
        ScoreManager scoreScript = scoreObject.GetComponent<ScoreManager>();

        if (scoreScript.score == 5)
        {
            thrust = 25;
        }
        if (scoreScript.score == 20)
        {
            thrust = 30;
        }

        if (scoreScript.score == 40)
        {
            thrust = 35;
        }
        if (scoreScript.score == 60)
        {
            thrust = 40;
        }
        if (scoreScript.score == 100)
        {
            thrust = 50;
        }

        #endregion

        #region PhoneInputs
/*
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.position.x < Screen.width / 2 && !rightlane)
                {
                    player.transform.position = new Vector3(X - 2, Y, Z);
                }
                else if (touch.position.x > Screen.width / 2 && !leftlane)
                {
                    player.transform.position = new Vector3(X + 2, Y, Z);

                }
            } 
            
        }
        */

        #endregion

        #region Inputs

        if (Input.GetKeyDown(KeyCode.D) && !rightlane)
        {
            player.transform.position = new Vector3(X + 2, Y, Z);
        }

        if (Input.GetKeyDown(KeyCode.A) && !leftlane)
        {
            player.transform.position = new Vector3(X - 2, Y, Z);

        }

        #endregion
    }

  

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BadLane")
        {
            SceneManager.LoadScene("Scene1");
            
            
        }
    }
}
