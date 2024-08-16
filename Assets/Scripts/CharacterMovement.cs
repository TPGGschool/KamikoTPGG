using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    int speed = 5;
    int sprintspeed = 8;
    void Start()
    {
        
    }

    void FixedUpdate() {
        float dt = Time.deltaTime;

        int actualSpeed;
        if (Input.GetKey(KeyCode.LeftShift)) {

            actualSpeed = sprintspeed;
        } else {
            actualSpeed = speed;
        }
       Vector3 movement = new Vector3(0, 0, 0);

      
            movement += new Vector3((Input.GetAxis("Horizontal") * actualSpeed * dt), (Input.GetAxis("Vertical") * actualSpeed * dt), 0);

        transform.position += movement;
    }


    
}
