using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    AudioSource audiosource;
    public AudioClip move;
    public AudioClip gethit;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-3, 0, 0); // �������ʡu3�v
            audiosource.PlayOneShot(move);
        }

        // �I������V�s��
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(3, 0, 0); // ���k���ʡu3�v
            audiosource.PlayOneShot(move);
        }
        
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
        audiosource.PlayOneShot(move);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
        audiosource.PlayOneShot(move);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Arrow")
        {
            gameManager.GetComponent<GameManager>().DecreaseHp();
            audiosource.PlayOneShot(gethit);
        }
        if (collision.tag == "catfood")
        {
            gameManager.GetComponent<GameManager>().AddHp();
            audiosource.PlayOneShot(gethit);
        }

    }
}
