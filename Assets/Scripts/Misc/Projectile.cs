
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float force;
	public float aliveTime;
    public int damage;
    public string ignoreTag;

    private void Start () {

        GetComponent<Rigidbody2D>().AddForce(transform.up * force);
    }

	private void Update () {

		if (aliveTime < 0) Destroy(gameObject);
		else aliveTime -= 1 * Time.deltaTime;
	}

    private void OnCollisionEnter2D (Collision2D collision) {

        if (collision.collider.tag == ignoreTag) return;

        Destroy(gameObject);
    }
}
