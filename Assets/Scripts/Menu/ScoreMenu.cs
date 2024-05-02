
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreMenu : MonoBehaviour {

    public static int score = 0;

    public TMP_Text scoreText;

    private float timer;

    private void Start () {

        score = 0;
    }

    private void Update () {


        timer -= Time.deltaTime;
        if (timer < 0) timer = .1f; else return;

        scoreText.text =
            "Wave: " + EnemySpawner.wave + "\n" +
            "Score: " + score;
        ;

        if (PlayerDeath.isDead) scoreText.text = "";
    }
}
