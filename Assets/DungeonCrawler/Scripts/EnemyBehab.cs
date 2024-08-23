using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPGG.FiniteStateMachine {

    public enum States {

        IDLE,
        PATROLLING,
        PERSECUTING
    }
    public class EnemyBehab : MonoBehaviour {

        //variable declaration
        public States myState;
        int speed;


        void Start() {
            speed = 5;
            //instation of the variable
            myState = States.IDLE;
        }
        //operation of the variable
        void Update() {

            Debug.Log(gameObject.name + " Finite State Machine - Update() - enemy is in " + myState.ToString());

            switch (myState) {

                case States.IDLE:
                    //Code
                    IdleState();
                    break;

                case States.PATROLLING:
                    //Code
                    PatrollingState();
                    break;

                case States.PERSECUTING:
                    //Code
                    PersecutingState();
                    break;
            }
        }

        #region MyStateMethods


        protected void IdleState() {

        }
        protected void PatrollingState() {

        }
        protected void PersecutingState() {

            Invoke("ChangeToIdleState",3.0f);
        }

        protected void ChangeToIdleState() {
            ChangeState(States.IDLE);
        }
        public void ChangeState(States value) {

            Debug.Log(gameObject.name + " Finite State Machine - Update() - state is going to change from " + myState.ToString() + " to " + value.ToString());
            myState = value;
            Debug.Log(gameObject.name + " Finite State Machine - Update() - state is now " + myState.ToString());
        }

        #endregion
        void FixedUpdate() {
            float dt = Time.deltaTime;

            Vector3 movement = new Vector3(0, 0, 0);

            movement += new Vector3((Input.GetAxis("Horizontal") * speed * dt), (Input.GetAxis("Vertical") * speed * dt), 0);

            transform.position += movement;
        }
    }
}