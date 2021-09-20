using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePassed : MonoBehaviour
{
    public BallDeflect health;
    public GameObject Ball;
    public Vector3 BallScale;
    public GameObject GamePass;
    // Start is called before the first frame update
    void Start()
    {
        GamePass.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ball")
        {
            GamePass.SetActive(true);
        }

    }
}
