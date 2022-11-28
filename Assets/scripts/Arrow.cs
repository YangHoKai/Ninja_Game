using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
        GameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        if(collision.name=="addscore")
        {
            GameManager.GetComponent<GameManager>().IncreaseScore(10);
        }
    }
}
