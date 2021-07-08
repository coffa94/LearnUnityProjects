using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //public variables
    public GameObject plane;

    //private variables
    private Vector3 offset = new Vector3(25.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //the camera's transform follow the player's transform
        transform.position = plane.transform.position + offset;
    }
}
