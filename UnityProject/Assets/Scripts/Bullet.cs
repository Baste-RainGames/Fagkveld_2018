using UnityEngine;

public class Bullet : MonoBehaviour {

    private Rigidbody2D rigidbody;

    void Start() {
        //Task 1: Find and assign this thing
        //rigidbody = ???
        
        //Task 2: Make it move
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //Task 3: Destroy stuff we collide with!

        //Task 4: Make health! (Go there now)

        //Task 5: (After has done health): make this only destroy stuff that we should destroy.
    }
}