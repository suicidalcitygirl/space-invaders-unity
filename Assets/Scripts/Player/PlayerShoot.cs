
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject projectilePrefab;
    public Vector3 spawnOffset;

    private void Update () {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        if (!Input.GetMouseButtonDown(0)) return;

        transform.Translate(spawnOffset);
        Instantiate(projectilePrefab, transform.position, transform.rotation);
        transform.Translate(-spawnOffset);
    }
}
