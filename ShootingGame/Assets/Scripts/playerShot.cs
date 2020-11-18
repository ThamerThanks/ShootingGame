using UnityEngine;

public class playerShot : MonoBehaviour
{
    public GameObject player;
    public Transform prefab;
    public float fireRate = 2f;
    public static float nextShot = 0f;
    SpriteRenderer sprite;
    Vector3 playerPostion;

    void Update()
    {
        playerPostion = player.transform.position;
        playerPostion.y = playerPostion.y + 0.2f;

        if (Input.GetMouseButtonDown(0) && Time.time > nextShot)
        {
            nextShot = Time.time + fireRate;
            Object.Instantiate(prefab, playerPostion, Quaternion.identity);
        }
        if (nextShot == 0f || Time.time > nextShot)
        {
            sprite = GetComponent<SpriteRenderer>();
            sprite.color = new Color(0.5f, 0.5f, 1, 1);
        }
        else
        {
            sprite.color = new Color(1, 1, 1, 1);
        }
        Debug.Log(nextShot);
    }
}
