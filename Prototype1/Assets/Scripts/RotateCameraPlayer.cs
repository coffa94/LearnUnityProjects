using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = player.rotation;
    }
}
