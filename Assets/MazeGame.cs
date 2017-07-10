using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGame : MonoBehaviour {

    public Chessboard board;
    public Character player;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            player.Move(Direction.up);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            player.Move(Direction.left);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            player.Move(Direction.down);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            player.Move(Direction.right);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int indexX = (int)mouseWorldPos.x;
            int indexY = (int)mouseWorldPos.y;
            IndexPaar source = new IndexPaar();
            source.col = indexX;
            source.row = indexY;
            MarkMoveArea(source, 3);
        }
    }
    void MarkMoveArea(IndexPaar source, int range) {
        if (range < 0)
            return;

        if (board.IsAlive(source.col, source.row)) {

            board.grid[source.col, source.row].GetComponent<Renderer>().material.color = Color.red;

            IndexPaar left = source;
            left.col--;
            IndexPaar right = source;
            right.col++;
            IndexPaar up = source;
            up.row++;
            IndexPaar down = source;
            down.row--;

            MarkMoveArea(left, range - 1);
            MarkMoveArea(right, range - 1);
            MarkMoveArea(up, range - 1);
            MarkMoveArea(down, range - 1);
        }
    }
}
