using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandWalkerAI : MonoBehaviour {
    public Character Character;
    float turnTime = 0.5f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        turnTime -= Time.deltaTime;

        if (turnTime < 0) {
            turnTime = 0.1f;
            move();
        }

        //Alternative
        //int randomMovementIndex = Random.Range(0, 4);
        //Character.Direction randomDirection = (Character.Direction)randomMovementIndex;


    }

    void move() {
        int random = Random.Range(0, 4);
        if (random == 0) {
            Character.move(Direction.left);
            return;
        }
        if (random == 1) {
            Character.move(Direction.right);
            return;
        }
        if (random == 2) {
            Character.move(Direction.up);
            return;
        }
        if (random == 3) {
            Character.move(Direction.down);
            return;
        }
    }

}

