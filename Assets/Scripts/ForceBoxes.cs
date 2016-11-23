using UnityEngine;
using System.Collections;

public class ForceBoxes : MonoBehaviour
{
    private Rigidbody rigid;
    private float forceAmount;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        forceAmount = 15f;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            rigid.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);

            Debug.Log("Force Added");
        }
    }
}
