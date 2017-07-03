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
            Player.move(1);
            //Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Player.move(0);
            //Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Player.move(2);
            //Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Player.move(3);
            //Board.setLifeStatus(Player.CharacterCol, Player.CharacterRow, false);
        }
	}
}
