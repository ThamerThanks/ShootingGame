using UnityEngine;

public class shotMovement : MonoBehaviour
{
    public Renderer shotRenderer;
    public Rigidbody2D rb;
    public static float shotSpeed = 10;

    public Vector2 shotPosition = (new Vector2(0, 1));
    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + new Vector2(0, shotSpeed / 10) * Time.fixedDeltaTime);
        if (shotRenderer.isVisible == false)
        {
            Object.Destroy(gameObject);
            scoreScript.scoreValue = scoreScript.scoreValue - 1;
        }
        shotSpeed += 0.0005f;
    }
}
