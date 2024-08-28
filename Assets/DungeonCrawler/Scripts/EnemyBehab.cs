using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPGG.FiniteStateMachine {

    public enum States {

        //IDLE
        IDLE_UP,
        IDLE_DOWN,
        IDLE_LEFT,
        IDLE_RIGHT,
        //MOVING
        MOVING_UP,
        MOVING_DOWN,
        MOVING_LEFT,
        MOVING_RIGHT
    }
    public class EnemyBehab : MonoBehaviour {

        //variable declaration
        public States myState;
        int speed;


        void Start() {
            speed = 5;
            //instation of the variable
            myState = States.IDLE_DOWN;
        }
        //operation of the variable
        void Update() {

            Debug.Log(gameObject.name + " Finite State Machine - Update() - is in any IDLE state " + isInIdleState);

            Debug.Log(gameObject.name + " Finite State Machine - Update() - enemy is in " + myState.ToString());

            switch (myState) {

                case States.IDLE_UP:
                case States.IDLE_DOWN:
                case States.IDLE_RIGHT:
                case States.IDLE_LEFT:
                    IdleState();
                    break;
                case States.MOVING_UP:
                case States.MOVING_DOWN:
                case States.MOVING_RIGHT:
                case States.MOVING_LEFT:
                    IdleState();
                    break;


            }
        }

        #region MyStateMethods


        protected void IdleState() {
           


        }
        protected void MovingState() {

        }
        protected void PersecutingState() {

            //Invoke("ChangeToIdleState",3.0f);
        }

        protected void ChangeToIdleState() {
            //hangeState(States.IDLE);
        }
        

        #endregion
        void FixedUpdate() {
          
        }

        #region GetSets

        protected bool isInIdleState {

            get{ 
            return (myState == States.IDLE_UP || myState == States.IDLE_DOWN || myState == States.IDLE_RIGHT || myState == States.IDLE_LEFT);
            }
            
        }

        public States SetState {
            set {
                Debug.Log(gameObject.name + " Finite State Machine - Update() - state is going to change from " + myState.ToString() + " to " + value.ToString());
                myState = value;
                Debug.Log(gameObject.name + " Finite State Machine - Update() - state is now " + myState.ToString());
            }
        }



        #endregion GetSets
    }
}