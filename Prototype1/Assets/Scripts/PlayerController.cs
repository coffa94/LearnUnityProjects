using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float turnSpeed = 1f;
    private float horizontalInput;
    private float forwardInput;

    [SerializeField] private Camera[] cameraAvailable;
    private int currentCameraIndex;

    [SerializeField] private int playerNumber;

    // Start is called before the first frame update
    void Start()
    {
        currentCameraIndex = 0;

        //active first camera
        cameraAvailable[currentCameraIndex].gameObject.SetActive(true);

        //disable other cameras
        for (int i = 1; i < cameraAvailable.Length; i++) {
            cameraAvailable[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //take the horizontal and vertical input from the player
        horizontalInput = Input.GetAxis("Horizontal" + playerNumber);
        forwardInput = Input.GetAxis("Vertical" + playerNumber);

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //turn the vehicle left or right (NOT DONE WITH TRANSLATE METHOD ANYMORE)
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetButtonDown("ChangeCamera" + playerNumber)){
            //disable current camera
            cameraAvailable[currentCameraIndex].gameObject.SetActive(false);

            //get the next index in the camera array
            currentCameraIndex++;
            
            //arrived at the end of the camera array, restart from zero
            if (currentCameraIndex >= cameraAvailable.Length) {
                currentCameraIndex = 0;
            }

            cameraAvailable[currentCameraIndex].gameObject.SetActive(true);
            
        }

    }
}
