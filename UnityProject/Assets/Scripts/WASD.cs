using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WASD : MonoBehaviour {

    // Field! You know this!
    private Vector2 startPos;

    private void Start () {
        // Note to self: this is the time to explain the transform component!
        startPos = transform.position;
    }

    private void Update () {
        //How to move stuff:
        transform.position += new Vector3(10f * Time.deltaTime, 0f, 0f); // x/y/z

        //TASK1: Make the player move about with WASD

        //TASK2: Talk about framerate, fix issues!

        //TASK3: Add a speed field, talk about public fields!
    }
}