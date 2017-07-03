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

    public void move(int direction) {
        switch (direction) {
            //Left
            case 0:
                CharacterCol--;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
            //Right
            case 1:
                CharacterCol++;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
            //Up
            case 2:
                CharacterRow++;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
            //Down
            case 3:
                CharacterRow--;
                transform.position = Board.getFieldCenter(CharacterCol, CharacterRow);
                break;
        }
    }
}
