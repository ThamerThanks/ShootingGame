using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverHideShow : MonoBehaviour
{

    public Transform button;
    public void hideGO()
    {
        button.localScale = new Vector2(0, 0);
    }
    public void showGO()
    {
        button.localScale = new Vector2(1, 1);
    }

}
