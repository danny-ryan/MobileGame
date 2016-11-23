using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public GameObject scorer;
    public int score;
    public int highscore;

    public Text hs;
    public Text text;

    void Awake()
    {
        score = 0;

        highscore = PlayerPrefs.GetInt("highscore", highscore);
        text.text = highscore.ToString();
    }

    void OnLevelWasLoaded()
    {
        PlayerPrefs.Save();
        Debug.Log("Saved"); 
    }
  
    void Update()
    {
        if (score > highscore)
        {
            highscore = score;

            PlayerPrefs.SetInt("highscore", highscore);
        }

        hs.text = "Highscore: " + highscore;
        text.text = "Score: " + score;
    }

    void OnTriggerEnter(Collider col)
    {
        float Z = transform.position.z;
        float Y = transform.position.y;
        float X = transform.position.x;


        if (col.gameObject.tag == "Player")
        {
            scorer.transform.position = new Vector3(X, Y, Z + 26.755f);

            score += 1;
        }
    }
}
