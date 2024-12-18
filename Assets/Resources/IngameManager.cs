using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;


public class IngameManager : MonoBehaviour
{
    public TextMeshProUGUI timertext;
    public TextMeshProUGUI scoretext;
    public int score;
    public float totalwaktu = 60f;
    public GameOver gameover;
    private float currenttime;
    
    // Start is called before the first frame update
    void Start()
    {
        currenttime = totalwaktu;
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime -= Time.deltaTime;
        UpdateTimerUI();
        UpdateScoreUI();
        if (currenttime <= 0f)
        {
            gameover.ActiveGameOver();
        }
    }

    public void UpdateTimerUI()
    {
        int second = Mathf.FloorToInt(currenttime % 60);
        timertext.text = string.Format("{0:00}", second);
    }

    public void UpdateScoreUI()
    {
        scoretext.text = score.ToString();
    }

    public void ScoreManager(int nambah)
    {
        score += nambah;
    }
}
