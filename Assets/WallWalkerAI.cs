using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkerAI : WalkerAI {

    Direction currentDir = Direction.left;

    // Use this for initialization
    void Start() {

    }

    protected override void Move() {
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
