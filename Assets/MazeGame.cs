using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGame : MonoBehaviour {

    public Chessboard Board;
    public Character Player;

    void Start() {

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Player.move(Direction.left);
            return;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Player.move(Direction.right);
            return;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Player.move(Direction.up);
            return;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Player.move(Direction.down);
            return;
        }
    }
}
