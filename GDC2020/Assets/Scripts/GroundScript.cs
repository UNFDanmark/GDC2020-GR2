using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public Renderer ground;
    public float Offset;
    public float Scrollspeed;
    // Start is called before the first frame update
    void Start()
    {
        ground = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ground.material.mainTextureOffset = new Vector2(0, Offset);
        Offset -= Scrollspeed;
    }
}
