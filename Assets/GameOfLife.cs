using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLife : MonoBehaviour {

    public Chessboard Board;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.K)) {
            Board.killAll();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Board.toggleMouseField();
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Board.pause = !Board.pause;
        }
        if (Board.pause) {
            return;
        }

        int[,] aliveCells = new int[Board.field_x_variable, Board.field_y_variable];
        for (int col = 0; col < Board.field_y_variable; col++) {
            for (int row = 0; row < Board.field_x_variable; row++) {
                aliveCells[col, row] = Board.GetAliveNeighbours(col, row);
            }
        }

        for (int col = 0; col < Board.field_y_variable; col++) {
            for (int row = 0; row < Board.field_x_variable; row++) {
                int aliveNeighbours = aliveCells[col, row];

                if (!Board.isAlive(col, row)) {
                    if (aliveNeighbours == 3) {
                        Board.setLifeStatus(col, row, true);
                    }
                } else {
                    if (aliveNeighbours < 2 || aliveNeighbours > 3) {
                        Board.setLifeStatus(col, row, false);
                    }
                }
            }
        }
    }
}
