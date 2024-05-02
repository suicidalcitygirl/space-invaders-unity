
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 4.0f;

    private Rigidbody2D rb;

    private void Start () {

        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update () {

        moveUp    = Input.GetKey(KeyCode.W);
        moveLeft  = Input.GetKey(KeyCode.A);
        moveDown  = Input.GetKey(KeyCode.S);
        moveRight = Input.GetKey(KeyCode.D);
    }

    private bool moveUp, moveDown, moveLeft, moveRight;

    private void FixedUpdate () {

        if (moveUp)    rb.AddForce(new Vector3(0, movementSpeed, 0));
        if (moveLeft)  rb.AddForce(new Vector3(-movementSpeed, 0, 0));
        if (moveDown)  rb.AddForce(new Vector3(0, -movementSpeed, 0));
        if (moveRight) rb.AddForce(new Vector3(movementSpeed, 0, 0));
    }
}
