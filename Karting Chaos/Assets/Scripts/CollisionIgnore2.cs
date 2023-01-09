using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionIgnore2 : MonoBehaviour
{
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Ignore2");
        Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
    }

}
