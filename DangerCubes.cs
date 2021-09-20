using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerCubes : MonoBehaviour
{
    public BallDeflect health;
    public GameObject Ball;
    public Vector3 BallScale;
    public Vector3 newBallSize;
    public GameObject GameOverPanel;
    public float RemovedHealth;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            health.playerHealth -= RemovedHealth;
            Ball.transform.localScale = BallScale; //* Time.deltaTime;
            Destroy(gameObject);
            Debug.Log("KILLED!!");
        }
    }

    private void Update()
    {
        if (BallScale == newBallSize)
        {
            Destroy(Ball);
            GameOverPanel.SetActive(true);
        }
    }
}
