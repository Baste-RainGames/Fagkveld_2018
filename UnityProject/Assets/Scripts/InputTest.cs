using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {

    void Start () {
        Debug.Log("Start!");
        //Task 1: figure out the order of the methods Awake, Start, OnEnable

        //Task 1.5: figure out what happens with Awake, Start, OnEnable, Update when you toggle the little checkbox next to the script
    }
    
    void Update () {
        Debug.Log("Updates");

        //How to check input!
        if (Input.GetKeyDown(KeyCode.Space)) {
            
        }
        //Task 2: figure out difference between GetKeyDown, GetKey
        if (Input.GetKey(KeyCode.U)) {
            
        }
    }
}
