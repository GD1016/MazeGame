using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkerAI : MonoBehaviour {

    public Character character;
    float turnTime = 0.5f;
    Direction currentDir = Direction.left;
    public enum CurrentDir { up, down, left, right }


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        turnTime -= Time.deltaTime;

        if (turnTime < 0) {
            turnTime = 0.5f;
            move();
        }
        //Alternative
        //int randomMovementIndex = Random.Range(0, 4);
        //Character.Direction randomDirection = (Character.Direction)randomMovementIndex;
    }

    void move() {
        switch (currentDir) {
            case Direction.left:
                if (character.Board.isAlive(character.CharacterCol - 1, character.CharacterRow)) {
                    character.move(currentDir);
                } else { turnLeft(); }
                break;
            case Direction.down:
                if (character.Board.isAlive(character.CharacterCol, character.CharacterRow - 1)) {
                    character.move(currentDir);
                } else { turnLeft(); }
                break;
            case Direction.right:
                if (character.Board.isAlive(character.CharacterCol + 1, character.CharacterRow)) {
                    character.move(currentDir);
                } else { turnLeft(); }
                break;
            case Direction.up:
                if (character.Board.isAlive(character.CharacterCol, character.CharacterRow + 1)) {
                    character.move(currentDir);
                } else { turnLeft(); }
                break;
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
