using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHideShow : MonoBehaviour
{
    public Transform button;
    public void hideButton()
    {
        button.localScale = new Vector2(0,0);
    }
    public void showButton()
    {
        button.localScale = new Vector2(1, 1);
    }
}
