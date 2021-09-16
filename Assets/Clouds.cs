using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    //public int up = 9; 
    public float speed = 2f;
    GameObject obj;

    // Update is called once per frame
    void Update()
    {
        //We stop the current position value of the tranform of the object this component is in
        //Basically we store the current position of the object.
        Vector3 temp = this.transform.position;

        //We add speed to the current x value of temp
        temp.x = temp.x + speed * Time.deltaTime;

        //An alternate way of writing the current x value of temp
        //temp.x += speed; 

        //We assign temp as the new position of the object.
        //We're teleporting the object in very small amounts really quickly.
        this.transform.position = temp;
    }
}
