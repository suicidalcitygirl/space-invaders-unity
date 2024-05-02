
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour {

    public TMP_Text gameOverText, scoreText;
    public Button playAgainButton, quitButton;

    private float timer;

	private void Start () {

		quitButton.onClick.AddListener(delegate{
			Application.Quit();
		});

		playAgainButton.onClick.AddListener(delegate{
			SceneManager.LoadScene("Main");
		});
	}

    private void Update () {

        timer -= Time.deltaTime;
        if (timer < 0) timer = 1f; else return;

        scoreText.text = scoreText.text == ""
            ? "Wave: " + EnemySpawner.wave + "  Score: " + ScoreMenu.score
            : ""
        ;
    }
}
