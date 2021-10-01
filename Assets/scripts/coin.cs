using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player");  
    }
    void Update()
    {
        Vector2 p1 = transform.position;              
        Vector2 p2 = this.player.transform.position;  
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.5f;  
        float r2 = 1.5f;  
        if (d < r1 + r2)
        {
            ScoreTextScript.coinAmount += 1;//金幣數量+1
            SoundManager.PlaySound("coin");//播放coin音效
            Destroy(gameObject);//捨棄物件
        }
    }
}
