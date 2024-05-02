
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenu : MonoBehaviour {

    public Button playButton, quitButton;

    private float timer;

	private void Start () {

		quitButton.onClick.AddListener(delegate{
			Application.Quit();
		});

		playButton.onClick.AddListener(delegate{
			SceneManager.LoadScene("Main");
		});
	}
}
