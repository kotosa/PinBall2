using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private GameObject ScoreText;

    // Score
    private int m_iSumScore = 0;
    private int m_iSmallStarScore = 10;
    private int m_iLargeStarScore = 15;
    private int m_iSmallCloudScore = 50;
    private int m_iLargeCloudScore = 100;

    // Use this for initialization
    void Start () {
        this.ScoreText = GameObject.Find("ScoreText");
    }
	
	// Update is called once per frame
	void Update () {
        this.ScoreText.GetComponent<Text>().text =  "Score:" + this.m_iSumScore.ToString();
    }


    void OnCollisionEnter(Collision a_Collision)
    {
        if (a_Collision.gameObject.tag == "SmallStarTag")
        {
            this.m_iSumScore += m_iSmallStarScore;
        }
        else if (a_Collision.gameObject.tag == "LargeStarTag")
        {
            this.m_iSumScore += m_iLargeStarScore;
        }
        else if (a_Collision.gameObject.tag == "SmallCloudTag")
        {
            this.m_iSumScore += m_iSmallCloudScore;
        }
        else if (a_Collision.gameObject.tag == "LargeCloudTag")
        {
            this.m_iSumScore += m_iLargeCloudScore;
        }

    }
}
