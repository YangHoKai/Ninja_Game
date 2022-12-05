using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject arrowprefab;

    public GameObject catfood;
    //float span = 1.0f;
    //float delta = 0;
    public GameObject hpGauge;
    public int blood = 10;

    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        blood = 10;
        scoreText.text = "分數:" + score+" 分";
        InvokeRepeating("ArrowShot", 0, 1.0f);
        InvokeRepeating("CatFood", 4.5f, 5.0f);
    }

    void ArrowShot()
    {
        Instantiate(arrowprefab, new Vector3(Random.Range(-6, 7), 7, 0), Quaternion.identity);
    }

    void CatFood()
    {
        Instantiate(catfood, new Vector3(Random.Range(-6, 7), 7, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {   /*
        delta += Time.deltaTime;
        if(delta>span)
        {
            delta = 0;
            int px = Random.Range(-6, 7);
            Instantiate(arrowprefab, new Vector3(px, 7, 0), Quaternion.identity);
        }
        */
    }
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        blood -= 1;
        if (blood <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
    public void AddHp()
    {
        hpGauge.GetComponent<Image>().fillAmount += 0.1f;
        blood += 1;
        if (blood > 10)
            blood = 10;
    }
    public void IncreaseScore(int _score)
    {
        score += _score;
        scoreText.text = "分數:" + score + " 分";

    }
}
