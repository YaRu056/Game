using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_generator : MonoBehaviour
{
    public GameObject weaponPrefab;//宣告物件
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(weaponPrefab) as GameObject;//動態生成weaponPrefab的物件
            int px = Random.Range(-9,4);//x為-9~4的一個隨機數
            go.transform.position = new Vector3(px, 17, 0);//物件生成的位置
        }
    }
}
