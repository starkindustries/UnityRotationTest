using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTest : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TestRotation sequence initiated!");
        Debug.Log("Current rotation: " + transform.rotation.ToString());              
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 10f;
    }

    public void DidPressQuaternionButton()
    {
        transform.rotation = Quaternion.Euler(x: 0f, y: 180f, z: 0f);
        Debug.Log("Quaternion.Euler(x: 0f, y: 180f, z: 0f): " + transform.rotation.ToString());
    }

    public void DidPressEulerButton()
    {
        transform.rotation = new Quaternion(x: 0f, y: 1f, z: 0f, w: 0f);
        Debug.Log("Quaternion(x: 0f, y: 1f, z: 0f, w: 0f): " + transform.rotation.ToString());
    }
}
