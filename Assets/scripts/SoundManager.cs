using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip jump, coin;//設定音效變數
    static AudioSource audioSrc; 
    void Start()
    {
        jump = Resources.Load<AudioClip>("jump");//取得音檔來源放入變數中
        coin = Resources.Load<AudioClip>("coin");

        audioSrc = GetComponent<AudioSource>(); //取得音檔來源的要素並縮短程式碼
    }

    public static void PlaySound(string clip) 
    {
        switch (clip) {

            case "coin"://當Clip傳入值為coin時
                audioSrc.PlayOneShot(coin);//播放名為coin的音效一次
                break;
            case "jump":
                audioSrc.PlayOneShot(jump);
                break;
        }
    }

}
