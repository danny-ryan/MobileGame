using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeadPlayer : MonoBehaviour
{
    public GameObject death;

	void Start ()
    {
	}
	
	void OnCollisionEnter (Collision col)
    {
        if (col.gameObject == death) 
        {
            SceneManager.LoadScene("Scene1");
        }
	}
}
