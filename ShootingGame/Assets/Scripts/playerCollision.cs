using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public GameObject explosion;
    public buttonHideShow hideShow;
    public gameOverHideShow goHideShow;
    public static bool playerIsDead = false;
    public bool LockPlayerScore;
    private float theScore;

    void Start()
    {
        GameObject go = GameObject.Find("Button");
        hideShow = (buttonHideShow)go.GetComponent(typeof(buttonHideShow));
        hideShow.hideButton();
        goHideShow.hideGO();

    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("Hit" + collisionInfo.collider.name + collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "Enemy")
        {
            Object.Destroy(collisionInfo.gameObject);
            Object.Instantiate(explosion, collisionInfo.gameObject.transform.position, Quaternion.identity);
            Object.Destroy(gameObject);
            playerIsDead = true;
            hideShow.showButton();

        }
    }

    //public float playerScore
    //{
    //    get { return value; }
    //    set
    //    {
    //        if (!LockPlayerScore)
    //            theScore = value;
    //    }
    //}


}

