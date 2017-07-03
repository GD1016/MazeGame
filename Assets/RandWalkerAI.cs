using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandWalkerAI : MonoBehaviour {

    public Character Character;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        int random = Random.Range(0, 4);

        if (random == 0) {
            Character.move(Character.Direction.left);
            return;
        }
        if (random == 1) {
            Character.move(Character.Direction.right);
            return;
        }
        if (random == 2) {
            Character.move(Character.Direction.up);
            return;
        }
        if (random == 3) {
            Character.move(Character.Direction.down);
            return;
        }
    }
}
