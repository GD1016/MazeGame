using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public Chessboard Board;

    public int CharacterCol;
    public int CharacterRow;

    public enum Direction { left, right, up, down }

    // Use this for initialization
    void Start() {
        transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);

        //transform.position.Set(CharacterCol, CharacterRow, 0);
    }

    // Update is called once per frame
    void Update() {

    }


    public void move(Direction direction) {
        switch (direction) {
            //Left
            case Direction.left:
                CharacterCol--;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
            //Right
            case Direction.right:
                CharacterCol++;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
            //Up
            case Direction.up:
                CharacterRow++;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
            //Down
            case Direction.down:
                CharacterRow--;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
            default:
                break;
        }
    }
}
