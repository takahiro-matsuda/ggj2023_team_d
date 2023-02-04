using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NokogiriMan : MonoBehaviour
{
    public Animator animator;  // アニメーターコンポーネント取得用
    public Image sliderimage;
    public Slider slider;
    float nowGauge;
    float maxGauge;
    float minGauge;
    bool maxfloat;
    // Start is called before the first frame update
    void Start()
    {
        nowGauge = 0;
        maxGauge = 1;
        minGauge = 0;
        slider.maxValue = maxGauge;
        
        slider.minValue = minGauge;
    }

    // Update is called once per frame
    void Update()
    {
        // 左に移動
        // if (Input.GetKey (KeyCode.LeftArrow)) {
        //     this.transform.Translate (-0.1f,0.0f,0.0f);
        // }
        // // 右に移動
        // if (Input.GetKey (KeyCode.RightArrow)) {
        //     this.transform.Translate (0.1f,0.0f,0.0f);
        // }
        // // 前に移動
        // if (Input.GetKey (KeyCode.UpArrow)) {
        //     this.transform.Translate (0.0f,0.0f,0.1f);
        // }
        // // 後ろに移動
        // if (Input.GetKey (KeyCode.DownArrow)) {
        //     this.transform.Translate (0.0f,0.0f,-0.1f);
        // }

        // スペース入力
        if (Input.GetKeyUp (KeyCode.Space)) {
            Debug.Log ("input space");

            // アニメーション再生（ノコギリを引く）
            if (animator.enabled)
            {
                animator.enabled = false;
            }
            else {
                animator.enabled = true;
            }

            // SE再生（ノコギリをひく）
        }
        slider.value = nowGauge;
        sliderimage.color = new Color(nowGauge, 1 - nowGauge, 0, 1);
        //nowGauge += Time.deltaTime/2;
        if (!maxfloat)
        {
            nowGauge += Time.deltaTime;
        }
        else
        {
            nowGauge -= Time.deltaTime;
        }
        if (nowGauge >= maxGauge)
        {
            maxfloat = true;
        }
        else if (nowGauge <= minGauge)
        {
            maxfloat = false;
        }
    }
}
