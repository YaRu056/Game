using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//增加UI程式
using UnityEngine.SceneManagement;//場景管理

public class GameDirector : MonoBehaviour
{
    GameObject health_bar;//宣告health_bar物件
    void Start()
    {
        this.health_bar = GameObject.Find("health_bar");
    }
    public void DecreaseHp()
    {
        this.health_bar.GetComponent<Image>().fillAmount -= 0.1f;//圖片減少0.1f
        if (this.health_bar.GetComponent<Image>().fillAmount == 0) //如果圖片減到0時
        {
           SceneManager.LoadScene("LoseScene");//轉到失敗的場景
        }
    }
}
