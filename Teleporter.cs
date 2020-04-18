using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject Player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Player)
        {
            transform.position = new Vector3(393, 35, -257);//(where you want to teleport)
        }
    }
}
