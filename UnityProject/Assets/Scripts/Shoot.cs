using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Bullet bullet;

    void Update () {
        bool pressedShoot = false;

        //Task 1: Implement this
        if (pressedShoot) {
            Bullet spawnedBullet = Instantiate(bullet);
        
            //Task 2: Make the bullet appear in front of the thing shooting it!
        }

        //Task 3: bullet script (go there now)
    }
}