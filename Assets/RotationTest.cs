using UnityEngine;

public class RotationTest : MonoBehaviour
{    
    void Start()
    {
        Debug.Log("Current rotation: " + transform.rotation.ToString());              
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 10f;
    }
}
