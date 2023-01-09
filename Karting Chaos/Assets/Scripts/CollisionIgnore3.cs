using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionIgnore3 : MonoBehaviour
{
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Ignore3");
        Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
    }

}
