using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseDirector : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//按下左鍵
        {
            ScoreTextScript.coinAmount = 0;//金幣數量歸零
            SceneManager.LoadScene("GameScene");//跳到遊戲畫面
        }
    }
}
