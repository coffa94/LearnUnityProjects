using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    //serialize variables
    [SerializeField] private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the game object in Z axis (giro orario)
        transform.Rotate(Vector3.back, rotationSpeed*Time.deltaTime);
    }
}
