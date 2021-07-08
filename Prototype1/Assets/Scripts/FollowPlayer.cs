using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //serialize variables
    [SerializeField] private GameObject player;

    //private variables
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset the camera behind the player by adding a new value to the player's position
        transform.position = player.transform.position + offset;   
    }
}
