//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //initialize variables
    public float speed;
    public float xPosition;
    
    //this function is called once every frame update
    //this function moves the camera along with the user's character so that the character remains on screen
    public void Update()
    {
        speed = 6.5f;
        this.transform.Translate(speed * Time.deltaTime, 0, 0);

        xPosition = transform.position.x;
        
        if (xPosition >= 45.0f)
        {
            Vector3 CurrentPosition = transform.position;
            CurrentPosition.x = -9f;
            CurrentPosition.y = 0f;
            CurrentPosition.z = -10f;
            this.transform.position = CurrentPosition;
        }
    }
}
