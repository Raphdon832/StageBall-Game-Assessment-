using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallDeflect : MonoBehaviour
{
    public GameObject Ball;
    public Vector3 BallScale;
    public Rigidbody BallRigidbody;
    public float thrust;
    public float playerHealth = 0;

    public TextMeshProUGUI PlayerHealthText;


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) //&& Input.touches[0].phase == TouchPhase.Began)
        {
            BallRigidbody.AddForce(0, thrust, 0);
        }

        if (playerHealth > 1000)
        {
            playerHealth = 1000;
        }
        //Updates player Health text
        PlayerHealthText.text = playerHealth.ToString();


        //Ball.transform.localScale -= BallScale*Time.deltaTime;
        transform.Rotate(0f, 0f, -2.7f);

        BallRigidbody.AddForce(120*Time.deltaTime, 0, 0);
        Time.timeScale = 1;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            Debug.Log("HIT!!");
        }
    }
}
