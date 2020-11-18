using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float enemySpeed = 0.6f;
    public Renderer enemyRenderer;

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2 (0, -enemySpeed/10) *Time.fixedDeltaTime);
    }
    void Update()
    {
        if (enemyRenderer.isVisible == false)
        {
            Object.Destroy(gameObject);
            scoreScript.scoreValue = scoreScript.scoreValue - 1;
        }
        enemySpeed += 0.0004f;
    }


}
