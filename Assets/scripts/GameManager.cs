using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject arrowprefab;
    float span = 1.0f;
    float delta = 0;
    public GameObject hpGauge;
    int blood = 10;

    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        blood = 10;
        scoreText.text = "分數:" + score+" 分";
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
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        blood -= 1;
        if (blood <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
    public void IncreaseScore(int _score)
    {
        score += _score;
        scoreText.text = "分數:" + score + " 分";

    }
}
