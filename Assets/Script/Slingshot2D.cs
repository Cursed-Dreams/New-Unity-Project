using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot2D : MonoBehaviour
{
    //The force that will be applied to the force when we release our mouse
    public float SlingshotForce;
    //The rigidbody on this object
    public Rigidbody2D reggiebody;

     //The start position of the dragging motion
    Vector3 startMousePos;

    bool draggingBallZ = false;

    Vector3 mouseVector;
   
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && draggingBallZ == true)
        {
            mouseVector = Input.mousePosition - startMousePos;
            reggiebody.AddForce(-mouseVector * SlingshotForce);
            draggingBallZ = false;
        }
    }

    private void OnMouseDown()
    {
        reggiebody .velocity
        startMousePos = Input.mousePosition;
        draggingBallZ = true;
    }
}
