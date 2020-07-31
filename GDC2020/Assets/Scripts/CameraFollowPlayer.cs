using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public  Vector3 offset;
    public float previousZ;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (previousZ - player.position.z > 0)
        {
            transform.position = new Vector3(offset.x, offset.y, player.position.z + offset.z);
        }
        previousZ = player.position.z;
    }
}
