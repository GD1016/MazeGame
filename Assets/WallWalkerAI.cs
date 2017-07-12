using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkerAI : MonoBehaviour {

    public Character character;
    Direction currentDir = Direction.left;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        print("WallWalker Update");

    }

    void Move() {
        print("WallWalker Move");

        IndexPaar checkPos = character.pos.GetNeighbour(currentDir);

        if (character.board.IsAlive(checkPos.col, checkPos.row)) {
            character.Move(currentDir);
        } else {
            TurnLeft();
        }
    }

    private void TurnLeft() {
        switch (currentDir) {
            case Direction.left:
                currentDir = Direction.down;
                break;
            case Direction.right:
                currentDir = Direction.up;
                break;
            case Direction.up:
                currentDir = Direction.left;
                break;
            case Direction.down:
                currentDir = Direction.right;
                break;
        }
    }
}
