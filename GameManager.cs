using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BallDeflect playerhealth;
    public GameObject Player;
    public string sceneID;
    public GameObject GameOver;
    public Vector3 standardSize;
    public Vector3 newSize;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerhealth.playerHealth <= 0)
        {
            Destroy(Player);
            //LoadIntro();
            GameOver.SetActive(true);
        }

        if (Input.GetKey("escape"))
        {
            //pauseMenu.SetActive(true);
            //Time.timeScale = 0;
        }

        if ((Player.transform.localScale == standardSize) || (Player.transform.localScale == new Vector3 (1.6f, 1.6f, 1.6f)))
        {
            Player.transform.localScale = newSize;
        }
    }
}
