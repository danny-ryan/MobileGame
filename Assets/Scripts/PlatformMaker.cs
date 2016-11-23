using UnityEngine;
using System.Collections;

public class PlatformMaker : MonoBehaviour
{
    public Transform platformSpawnPoint;
    public GameObject[] platforms;

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(platforms[Random.Range(0, platforms.GetLength(0))], platformSpawnPoint.position, transform.rotation);

        }


    }
}
