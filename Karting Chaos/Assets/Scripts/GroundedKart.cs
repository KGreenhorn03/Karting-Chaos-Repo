using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedKart : MonoBehaviour
{

    private float hoverHeight = 1.0f;
    private float terrainHeight;
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    {

        pos = transform.position;
        float terrainHeight = Terrain.activeTerrain.SampleHeight(pos);
        transform.position = new Vector3(pos.x, terrainHeight + hoverHeight, pos.z);
        
    }
}
