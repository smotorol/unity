using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text txtScore;
    private int totScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        totScore = PlayerPrefs.GetInt("TOT_SCORE", 0);
        DispScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispScore(int score)
    {
        totScore += score;
        txtScore.text = "scroe <color=#ff0000>" + totScore.ToString() +"</color>";
        PlayerPrefs.SetInt("TOT_SCORE", totScore);
    }
}
