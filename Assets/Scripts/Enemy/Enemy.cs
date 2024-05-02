
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float movementSpeed = 4.0f;

    private Rigidbody2D rb;
    private bool directionToggle;
    private float timer;

    private void Start () {

        rb = this.GetComponent<Rigidbody2D>();
        EnemySpawner.enemies.Add(this);
        directionToggle = Random.Range(0, 1) == 1;
    }

    private void Update () {

        timer -= Time.deltaTime;
        if (timer < 0) timer = Random.Range(0.4f, 1.4f); else return;

        directionToggle = !directionToggle;
    }

    private void FixedUpdate () {

        if (directionToggle)
            rb.AddForce(new Vector3(movementSpeed, 0, 0));
        else
            rb.AddForce(new Vector3(-movementSpeed, 0, 0));
    }

    private void OnCollisionEnter2D (Collision2D collision) {

        directionToggle = !directionToggle;
    }

    private void OnDestroy () {

        EnemySpawner.enemies.Remove(this);
        ScoreMenu.score++;
    }
}
