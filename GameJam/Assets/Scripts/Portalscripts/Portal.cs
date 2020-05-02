using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public PlayerMovement player;
    private int scene = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
            scene += 1;
            player.activeScene = scene;

        }
    }
}
