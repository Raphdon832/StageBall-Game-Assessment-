using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inflator : MonoBehaviour
{
    public BallDeflect health;
    public GameObject Ball;
    public Vector3 BallScale;
    public AudioSource coinSound;

    private void Awake()
    {
        //coinSound.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            health.playerHealth += 20;
            Ball.transform.localScale = BallScale;
            Destroy(gameObject, 0.1f);
            coinSound.Play();
            Debug.Log("KILLED!!");
        }

    }
}
