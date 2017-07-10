using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntWalkerAI : MonoBehaviour {

    public Character character;
    public Character player;
    float timer = 0.5f; // timer variable, used as a "countdown" to next move
    int[,] distance;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        timer -= Time.deltaTime; // subtract time since last frame
        if (timer > 0f) { // if countdown not done, skip
            return;
        }
        timer = 0.5f; // if we get here, reset timer
        Move(); // and move
    }

    private void Move() {
        IndexPaar target = player.pos;
        List<IndexPaar> path = GetPath(target);
        if (path.Count > 0) {
            IndexPaar firststep = path[0];
            Direction dir = character.pos.GetNeighbourDirection(firststep);
            character.Move(dir);
        }
    }

    void Breitensuche(IndexPaar source) {
        Queue<IndexPaar> queue = new Queue<IndexPaar>();
        queue.Enqueue(source);
        distance = new int[character.board.size, character.board.size];

        for (int i = 0; i < distance.GetLength(0); i++) {
            for (int j = 0; j < distance.GetLength(1); j++) {
                distance[i, j] = int.MaxValue;
            }
        }
        distance[source.col, source.row] = 0;

        while(queue.Count > 0) {
            IndexPaar u = queue.Dequeue();
            List<IndexPaar> neighbours = character.board.GetWalkableNeighbours(u);
            foreach (IndexPaar neighbour in neighbours) {
                if (distance[neighbour.col, neighbour.row] == int.MaxValue) {
                    distance[neighbour.col, neighbour.row] = distance[u.col, u.row] + 1;
                    queue.Enqueue(neighbour);
                }
            }
        }
    }
    List<IndexPaar> GetPath(IndexPaar target) {
        Breitensuche(character.pos);
        List<IndexPaar> path = new List<IndexPaar>();

        if(distance[target.col, target.row] < int.MaxValue) {
            IndexPaar node = target;
            while (distance[node.col, node.row] != 0) {
                path.Add(node);
                List<IndexPaar> neighbours = character.board.GetWalkableNeighbours(node);
                foreach(IndexPaar neighbour in neighbours) {
                    if (distance[neighbour.col, neighbour.row] == distance[node.col, node.row] - 1) {
                        node = neighbour;
                        break;
                    }
                }
            }
        }
        path.Reverse();
        return path;
    }
}
