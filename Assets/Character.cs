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
        IndexPaar newPos = pos.GetNeightbour(direction);
        UpdatePos(newPos);
        //switch (direction) {
        //    case Direction.left:
        //        if (Board.isAlive(pos.col - 1, pos.row)) {
        //            pos.col--;
        //            transform.position = Board.getFieldCenter(pos.col, pos.row);
        //        }
        //        break;
        //    case Direction.right:
        //        if (Board.isAlive(pos.col + 1, pos.row)) {
        //            pos.col++;
        //            transform.position = Board.getFieldCenter(pos.col, pos.row);
        //        }
        //        break;
        //    case Direction.up:
        //        if (Board.isAlive(pos.col, pos.row + 1)) {
        //            pos.row++;
        //            transform.position = Board.getFieldCenter(pos.col, pos.row);
        //        }
        //        break;
        //    case Direction.down:
        //        if (Board.isAlive(pos.col, pos.row - 1)) {
        //            pos.row--;
        //            transform.position = Board.getFieldCenter(pos.col, pos.row);
        //        }
        //        break;
        //    default:
        //        break;
    }

    void UpdatePos(IndexPaar pos) {
        if (!Board.isAlive(pos.col, pos.row)) {
            return;
        }
        this.pos = pos;
        transform.position = Board.getFieldCenter(pos.col, pos.row);
    }
}

