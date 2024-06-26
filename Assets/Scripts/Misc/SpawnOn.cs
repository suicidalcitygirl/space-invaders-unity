
using UnityEngine;

public class SpawnOn : MonoBehaviour {

    public GameObject objectToCreateOnStart, objectToCreateOnDestroy, objectToCreateOnCollision;

    private void Start () {

        if (objectToCreateOnStart == null) return;

        Instantiate(objectToCreateOnStart, transform.position, transform.rotation);
    }

    private void OnDestroy () {

        if (objectToCreateOnDestroy == null) return;

        Instantiate(objectToCreateOnDestroy, transform.position, transform.rotation);
    }

    private void OnCollisionEnter () {

        if (objectToCreateOnCollision == null) return;

        Instantiate(objectToCreateOnCollision, transform.position, transform.rotation);
    }
}
