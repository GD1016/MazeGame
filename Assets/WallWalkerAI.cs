using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkerAI : MonoBehaviour {

    public Character character;
    public IndexPaar pos;

    float turnTime = 0.5f;
    Direction currentDir = Direction.left;


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
        IndexPaar neighbour = pos.GetNeighbour(currentDir);
        if (character.Board.isAlive(neighbour.col, neighbour.row)) {
            character.move(currentDir);
        }else {
            turnLeft();
        }
        
    }

    void turnLeft() {
        switch (currentDir) {
            case Direction.left:
                currentDir = Direction.down;
                break;
            case Direction.down:
                currentDir = Direction.right;
                break;
            case Direction.right:
                currentDir = Direction.up;
                break;
            case Direction.up:
                currentDir = Direction.left;
                break;
        }


    }
}
