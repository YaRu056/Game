using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_controller : MonoBehaviour
{
    GameObject player;//宣告player物件
    void Start()
    {
        this.player = GameObject.Find("player");  // 找到player物件
    }
    void Update()
    {
        transform.Translate(0, 0.05f, 0);//物件向Y方向下降0.5F公尺
        if (transform.position.y < 2.0f)//當y的位置<2.0f時
        {
            Destroy(gameObject);//捨棄物件
        }
        Vector2 p1 = transform.position;              // 劍的圓心座標
        Vector2 p2 = this.player.transform.position;  // 遊戲角色的圓心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.05f;  // 劍的圓半徑
        float r2 = 1.0f;  // 遊戲角色的圓半徑
        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");  // 將衝突訊息傳遞給GameDirector
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);// 捨棄物件
        }
    }
}
