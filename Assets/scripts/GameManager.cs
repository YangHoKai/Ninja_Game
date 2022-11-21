using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject arrowprefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta>span)
        {
            delta = 0;
            int px = Random.Range(-6, 7);
            Instantiate(arrowprefab, new Vector3(px, 7, 0), Quaternion.identity);
        }
    }
}
