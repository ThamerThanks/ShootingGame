using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScript : MonoBehaviour
{
    public CanvasGroup buttonCanvas;
    public GameObject player;
    public void respawnPlayer()
    {
        if (playerCollision.playerIsDead)
        {
            Instantiate(player, new Vector2(0, 0), Quaternion.identity);
            playerCollision.playerIsDead = false;
            scoreScript.scoreValue = 0;
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
            enemyMovement.enemySpeed = 0.4f;
            enemySpawner.spawnRate = 2;
            shotMovement.shotSpeed = 10;

        }
    }
}
