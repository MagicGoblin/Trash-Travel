using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D BoatRB;
    public int Speed;
    public Vector2 ForwardDirection;
    public Vector2 BackDirection;
    public Vector2 RightDirection;
    public Vector2 LeftDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(BoatRB.position);
        if (Input.GetKey(KeyCode.W))
        {
            BoatRB.AddForce(Speed * ForwardDirection);
        }
        if (Input.GetKey(KeyCode.S))
        {
            BoatRB.AddForce(Speed * BackDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            BoatRB.AddForce(Speed * RightDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            BoatRB.AddForce(Speed * LeftDirection);
        }
    }
}
