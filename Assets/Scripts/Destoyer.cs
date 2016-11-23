using UnityEngine;
using System.Collections;

public class Destoyer : MonoBehaviour
{
   

    void Update()
    {
        Destroy(gameObject, 3f);
    }
}
