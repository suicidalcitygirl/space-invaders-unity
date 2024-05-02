
using UnityEngine;

public class Background : MonoBehaviour {

	public Vector3 rotationSpeeds;

	private void Update () {

		transform.eulerAngles += rotationSpeeds * Time.deltaTime;
	}
}
