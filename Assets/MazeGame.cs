using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGame : MonoBehaviour {

    public Chessboard board;
    public Character player;

    // Use this for initialization
    void Start() {
        int copyOfX = x;
        copyOfX = 2;
        print("Wert von copy: " + copyOfX);
        print("Wert von x: " + x);

        Character CopyOfPlayer = player;
        CopyOfPlayer.pos.col = 5;
        print("Wert von CopyOfPlayer Colum: " + CopyOfPlayer.pos.col);
        print("Wert von Player Colum: " + player.pos.col);

        IndexPaar indexpaar = new IndexPaar();
        indexpaar.col = 3;
        IndexPaar copy = indexpaar;
        copy.col = 5;
        print("Wert von copy  Colum: " + copy.col);

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
            //MarkMoveArea(source, 3);
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
