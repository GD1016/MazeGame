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
            case Direction.left:
                if (Board.isAlive(CharacterCol - 1, CharacterRow)) {
                    CharacterCol--;
                    transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                }
                break;
            case Direction.right:
                if (Board.isAlive(CharacterCol + 1, CharacterRow)) {
                    CharacterCol++;
                    transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                }
                break;
            case Direction.up:
                if (Board.isAlive(CharacterCol, CharacterRow + 1)) {
                    CharacterRow++;
                    transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                }
                break;
            case Direction.down:
                if (Board.isAlive(CharacterCol, CharacterRow - 1)) {
                    CharacterRow--;
                    transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                }
                break;
            default:
                break;
        }
    }
}
