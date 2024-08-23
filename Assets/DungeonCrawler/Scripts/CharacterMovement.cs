using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    int speed = 5;
    int sprintspeed = 8;

    public Animator animator;

    bool isWalkingUp;
    bool isWalkingDown;
    bool isWalkingSide;

    void Start()
    {
        speed = 5;
        sprintspeed = 8;
        isWalkingUp = false;
        isWalkingDown = false;
        isWalkingSide = false;
        animator.SetBool("isWalkingUp", false);
        animator.SetBool("isWalkingDown", false);
        animator.SetBool("isWalkingSide", false);

    }

    void FixedUpdate() {
        animationDirection();
        float dt = Time.deltaTime;

        int actualSpeed;
        if (Input.GetKey(KeyCode.LeftShift)) {

            actualSpeed = sprintspeed;
            animator.speed = 3;
        } else {
            actualSpeed = speed;
            animator.speed = 1.5f;
        }
       Vector3 movement = new Vector3(0, 0, 0);

      
            movement += new Vector3((Input.GetAxis("Horizontal") * actualSpeed * dt), (Input.GetAxis("Vertical") * actualSpeed * dt), 0);

        transform.position += movement;

    }

    void animationDirection() {

        if(Input.GetAxis("Horizontal") > 0)  {

            isWalkingSide = true;
            animator.SetBool("isWalkingSide", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            isWalkingUp = false;
            isWalkingDown = false;
            animator.SetBool("isWalkingUp", false);
            animator.SetBool("isWalkingDown", false);
        }
        else if(Input.GetAxis("Horizontal") < 0) {

            isWalkingSide = true;
            animator.SetBool("isWalkingSide", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            isWalkingUp = false;
            isWalkingDown = false;
            animator.SetBool("isWalkingUp", false);
            animator.SetBool("isWalkingDown", false);

        } 
        else if (Input.GetAxis("Vertical") < 0) {

            isWalkingDown = true;
            animator.SetBool("isWalkingDown", true);
            isWalkingUp = false;
            isWalkingSide = false;
            animator.SetBool("isWalkingUp", false);
            animator.SetBool("isWalkingSide", false);

        } 
        else if (Input.GetAxis("Vertical") > 0) {

            isWalkingUp = true;
            animator.SetBool("isWalkingUp", true);
            isWalkingDown = false;
            isWalkingSide = false;
            animator.SetBool("isWalkingDown", false);
            animator.SetBool("isWalkingSide", false);

        } else {
            resetAnimations();
        }


    }

    void resetAnimations() {
        isWalkingUp = false;
        isWalkingDown = false;
        isWalkingSide = false;
        animator.SetBool("isWalkingUp", false);
        animator.SetBool("isWalkingDown", false);
        animator.SetBool("isWalkingSide", false);
        gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }


    
}
