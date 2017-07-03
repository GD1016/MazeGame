using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGame : MonoBehaviour {

    public Chessboard Board;

    public Character Player;

    // Use this for initialization
    void Start() {

    }



    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Player.move(Character.Direction.left);
            return;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Player.move(Character.Direction.right);
            return;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Player.move(Character.Direction.up);
            return;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Player.move(Character.Direction.down);
            return;
        }
    }
}
