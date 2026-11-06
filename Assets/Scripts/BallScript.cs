using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            myRigidbody.linearVelocity = Vector2.up * 0;
        }
        
    }
}
