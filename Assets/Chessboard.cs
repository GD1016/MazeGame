using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessboard : MonoBehaviour {

    public int field_x_variable = 20;
    public int field_y_variable = 20;
    public bool pause = false;

    GameObject[,] grid;

    // Use this for initialization
    void Start() {
        grid = new GameObject[field_x_variable, field_y_variable];

        for (int col = 0; col < field_x_variable; col++) {
            for (int row = 0; row < field_y_variable; row++) {
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Quad);
                tile.transform.position = new Vector2(col + 0.5f, row + 0.5f);
                tile.transform.parent = this.transform;
                tile.name = string.Format("Kachel ({0},{1})", col, row);
                grid[col, row] = tile;

                int random = Random.Range(0, 10);
                if (random >= 5) {
                    tile.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
        }

        int camsize = field_x_variable / 2;
        Camera.main.transform.position = new Vector3(camsize, camsize, -10);
        Camera.main.orthographicSize = camsize;
    }

    // Update is called once per frame
    void Update() {
    }

    public int GetAliveNeighbours(int col, int row) {

        int aliveNeighbours = 0;
        int searchradius = 1;

        for (int i = col - searchradius; i <= col + searchradius; i++) {
            for (int j = row - searchradius; j <= row + searchradius; j++) {
                if (i >= 0 && j >= 0 && i < field_x_variable && j < field_y_variable) {
                    if (!(i == col && j == row)) {
                        if (isAlive(i, j)) {
                            aliveNeighbours++;
                        }
                    }
                }
            }
        }
        return aliveNeighbours;
    }

    public bool isAlive(int col, int row) {
        if (col > field_x_variable || row > field_y_variable || col < 0 || row < 0) {
            return false;
        }
        return grid[col, row].GetComponent<Renderer>().material.color == Color.blue;
    }

    public void setLifeStatus(int col, int row, bool alive) {
        if (col > field_x_variable || row > field_y_variable || col < 0 || row < 0) {
            return;
        }
        if (!alive) {
            grid[col, row].GetComponent<Renderer>().material.color = Color.white;
        } else {
            grid[col, row].GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    public void killAll() {
        print("Hallo");
        for (int col = 0; col < field_x_variable; col++) {
            for (int row = 0; row < field_y_variable; row++) {
                setLifeStatus(col, row, false);
            }
        }
    }

    void toggle(int col, int row) {
        if (isAlive(col, row)) {
            setLifeStatus(col, row, false);
        } else {
            setLifeStatus(col, row, true);
        }
    }

    public void toggleMouseField() {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        int indexX = (int)mouseWorldPos.x;
        int indexY = (int)mouseWorldPos.y;
        toggle(indexX, indexY);
    }
    public Vector3 getFieldCenter(int col, int row) {

        Vector3 result = new Vector3(col + 0.5f, row + 0.5f, 0);
        return result;
    }
}