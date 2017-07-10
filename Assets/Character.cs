using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public Chessboard Board;
    public IndexPaar pos;



    void Start() {
        transform.position = Board.getFieldCenter(pos.col, pos.row);

        //transform.position.Set(CharacterCol, CharacterRow, 0);
    }
    void Update() {

    }


    public void move(Direction direction) {
        IndexPaar newPos = pos.GetNeighbour(direction);
        UpdatePos(newPos);
    }

    void UpdatePos(IndexPaar pos) {
        if (!Board.isAlive(pos.col, pos.row)) {
            return;
        }
        this.pos = pos;
        transform.position = Board.getFieldCenter(pos.col, pos.row);
    }
}

