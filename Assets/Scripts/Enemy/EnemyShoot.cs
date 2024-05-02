
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public GameObject projectile;
    public float fireRate;
    public Vector3 offset;

    private Transform target;
    private float timer;

    private void Start () {

        target = GameObject.FindWithTag("Player").transform;
        timer = Random.Range(0.0f, fireRate);
    }

    private void Update () {

        if (PlayerDeath.isDead) return;

        timer -= 1 * Time.deltaTime;
		if (timer < 0) timer = fireRate; else return;

        Quaternion rotation = transform.rotation;
		transform.up = new Vector2(
			target.position.x - transform.position.x,
			target.position.y - transform.position.y
		);
        transform.Translate(offset);
        if (!Physics2D.Raycast(transform.position, transform.eulerAngles, 2))
            Instantiate(projectile, transform.position, transform.rotation);
        transform.Translate(-offset);
        transform.rotation = rotation;
    }
}
