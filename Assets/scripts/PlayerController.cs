using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//場景管理

public class PlayerController : MonoBehaviour
{
    Animator animator;
    GameObject player;//宣告Player物件
    public SpriteRenderer playerSr;
    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.player = GameObject.Find("player");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) //按住按鍵D
        {
            this.animator.SetTrigger("run");//播放跑步的動畫
        }
        if ( Input.GetKeyDown(KeyCode.A))
        {
            this.animator.SetTrigger("run");
        }
        if (Input.GetKeyUp(KeyCode.D))//放開按鍵D
        {
            this.animator.SetTrigger("idle");//播放空閒的動畫
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            this.animator.SetTrigger("idle");
        }
        if (Input.GetKey(KeyCode.R))//按住按鍵R
        {
            SceneManager.LoadScene("GameScene");//跳回遊戲開始的畫面
            ScoreTextScript.coinAmount = 0;//金幣數量歸零
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("ClearScene");//遇到Trigger 跳到成功畫面
    }
}