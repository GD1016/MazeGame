using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGame : MonoBehaviour {

    public Chessboard Board;

    public Character Player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Player.moveRight();
            Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Player.moveLeft();
            Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Player.moveUp();
            Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Player.moveDown();
            Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
	}
}
