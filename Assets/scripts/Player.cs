using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-3, 0, 0); // 往左移動「3」
            GetComponent<AudioSource>().Play();
        }

        // 點擊左方向鈕時
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(3, 0, 0); // 往右移動「3」
            GetComponent<AudioSource>().Play();
        }
        
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GetComponent<GameManager>().DecreaseHp();
    }
}
