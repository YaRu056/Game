using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//按左鍵
        {
            ScoreTextScript.coinAmount = 0;//金幣數量歸零
            SceneManager.LoadScene("StartScene");//跳到遊戲場景
        }
    }
}
