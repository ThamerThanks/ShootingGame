using UnityEngine;

public class shotCollision : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("Hit" + collisionInfo.collider.name + collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "Enemy")
        {
            Object.Destroy(collisionInfo.gameObject);
            Object.Instantiate(explosion, collisionInfo.gameObject.transform.position, Quaternion.identity);
            scoreScript.scoreValue += 1;
            playerShot.nextShot = 0f;
        }
        Object.Destroy(gameObject);
    }
}
