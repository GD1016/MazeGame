using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandWalkerAI : MonoBehaviour {

    public Character character;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        print("RandWalker Update");

    }

    void Move() {
        print("RandWalker Move");

        // create array out of enum
        System.Array values = Direction.GetValues(typeof(Direction));
        int randomIndex = Random.Range(0, values.Length); // select random index
                                                          // retrieve random enum value from array
        Direction randomDir = (Direction)values.GetValue(randomIndex);
        character.Move(randomDir);
    }
}
