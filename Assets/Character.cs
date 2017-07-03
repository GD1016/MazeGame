using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public Chessboard Board;

    public int CharacterCol;
    public int CharacterRow;

    // Use this for initialization
    void Start() {
        transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);

        //transform.position.Set(CharacterCol, CharacterRow, 0);
    }

    // Update is called once per frame
    void Update() {

    }

    public void moveLeft() {
        CharacterRow--;
        transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
    }

    public void moveRight() {
        CharacterRow++;
        transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
    }

    public void moveUp() {
        CharacterCol++;
        transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
    }

    public void moveDown() {
        CharacterCol--;
        transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
    }
}
