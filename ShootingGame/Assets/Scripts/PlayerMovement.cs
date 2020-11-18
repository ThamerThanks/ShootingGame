using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform tf;
    Vector3 finalMousePos;

    // Update is called once per frame
    void Update()
    {
        // Gets the Vector 3 position of the mouse cursor
        Vector3 cursorPosition = Input.mousePosition;
        //changes the z to be infront of the background
        cursorPosition.z = Camera.main.nearClipPlane;
        finalMousePos = Camera.main.ScreenToWorldPoint(cursorPosition);
    }

    void FixedUpdate()
    {
        tf.position = (finalMousePos);
    }


}
