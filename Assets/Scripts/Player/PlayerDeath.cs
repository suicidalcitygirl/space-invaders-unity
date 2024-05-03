
using System;
using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour {

    public static bool isDead = false;

    public bool invincible;
    public int hitPoints;
    public string[] killingTags;
    public GameObject objectToSpawnOnDestroy;
    public GameObject objectToSpawnOnDamage;
    public GameObject gameOverMenu;
    public Slider HPBar;

    private void Start () {

        isDead = false;
        HPBar.maxValue = hitPoints - 1;
    }

    private void OnCollisionEnter2D (Collision2D collision) {

        bool damageTaken = false;

        if (killingTags.Length == 0) damageTaken = true;
        else if (Array.IndexOf(killingTags, collision.collider.tag) > -1)
            damageTaken = true;

        if (damageTaken && !invincible) {

            invincible = true;
            StartCoroutine(Timer(3));

            hitPoints--;
            HPBar.value = hitPoints - 1;

            if (hitPoints <= 0) {

                Instantiate(objectToSpawnOnDestroy, transform.position, transform.rotation);

                isDead = true;
                gameOverMenu.SetActive(true);
                HPBar.gameObject.SetActive(false);

                Destroy(gameObject);

            }
            else
                Instantiate(objectToSpawnOnDamage, transform.position, transform.rotation)
                    .transform.SetParent(transform);
        }

        IEnumerator Timer (float seconds) {

            yield return new WaitForSeconds(seconds);
            invincible = false;
        }
    }
}
