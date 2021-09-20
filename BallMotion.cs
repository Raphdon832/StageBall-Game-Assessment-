using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{
    public Rigidbody BallRB;

    [SerializeField] private float thrust;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JumpPressed()
    {
        BallRB.AddForce(0, thrust, 0);
    }
}
