using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text MyScoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "Score : " + ScoreNum;
        
    }

    private void OnTriggerEnter2D(Collider2D �ble)
    {
        if (�ble.tag == "�ble")
        {
            ScoreNum += 10;
            MyScoreText.text = "Score : " + ScoreNum;
        }
        
    }

}
