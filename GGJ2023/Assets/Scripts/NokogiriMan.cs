using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NokogiriMan : MonoBehaviour
{
    //public Animator animator;  // アニメーターコンポーネント取得用
    public Image sliderimage;
    public Slider slider;
    float nowGauge;
    float maxGauge;
    float minGauge;
    bool maxfloat;
    float randomfloatmin;
    float randomfloatmax;
    bool gauge = true;
    float gaugetimer;
    public float gaugespeed;
    Vector3 pos;
    public Animator sawmanAnim;
    public float movetimer;
    bool moving = true;
    // Start is called before the first frame update
    void Start()
    {
        nowGauge = 0;
        maxGauge = 100;
        minGauge = 0;
        slider.maxValue = maxGauge;
        slider.minValue = minGauge;
        randomfloatmin = Random.Range(30, 50);
        randomfloatmax = Random.Range(60, 80);
        pos.z = -4; 
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            pos.x += Time.deltaTime * 10;
            sawmanAnim.SetBool("Run", true);
            if (pos.x >= 50)
            {
                moving = false;
                if (gauge)
                {
                    nowGauge = 0;
                    gauge = false;
                }
                if (nowGauge >= randomfloatmin && nowGauge <= randomfloatmax)
                {
                    Debug.Log("成功");
                    sawmanAnim.SetTrigger("Success");
                }
                else if (nowGauge < randomfloatmin)
                {
                    Debug.Log("失敗");
                    sawmanAnim.SetTrigger("NotSuccess");
                }
                else if (nowGauge > randomfloatmax)
                {
                    Debug.Log("切りすぎ");
                    sawmanAnim.SetTrigger("NotSuccess");
                }
            }
        }
        else
        {
            //sawmanAnim.SetBool("Run", false);
            movetimer += Time.deltaTime;
            if (movetimer >= 1.6)
            {
                moving = true;
                pos.x = Random.Range(-50,30);
                movetimer = 0;
            }
        }
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
        /*if (Input.GetKeyUp (KeyCode.Space)) {
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
        }*/
        //ゲージの値を取得
        transform.position = pos;
        slider.value = nowGauge;
        //ゲージが動かせる状態(走っている状態)ならば
        if (gauge)
        {
            //sliderimage.color = new Color(nowGauge, 1 - nowGauge, 0, 1);
            gaugespeed = 100 + Random.Range(-100,100);
            if (!maxfloat)
            {
                //ゲージの上昇
                nowGauge += Time.deltaTime * gaugespeed;
            }
            else
            {
                //ゲージの下降
                nowGauge -= Time.deltaTime * gaugespeed;
            }
            if (nowGauge >= maxGauge)
            {
                //ゲージが上限まで達したら下がるように
                maxfloat = true;
            }
            else if (nowGauge <= minGauge)
            {
                //ゲージが下限まで達したら上がるように
                maxfloat = false;
            }
            if (nowGauge >= randomfloatmin && nowGauge <= randomfloatmax)
            {
                //Debug.Log("成功");
                //成功の判定
                sliderimage.color = new Color(0, 1, 0, 1);
                
            }
            else if (nowGauge < randomfloatmin)
            {
                //失敗の判定
                sliderimage.color = new Color(1, 0, 0, 1);
                
            }
            else if (nowGauge > randomfloatmax)
            {
                //切りすぎの判定
                sliderimage.color = new Color(0, 1, 1, 1);
                
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gauge = false;
            }
        }
        else
        {
            //gaugetimer += Time.deltaTime;
            
            //sawmanAnim.SetBool("Run", false);
            
            if(pos.x <= 30)
            {
                randomfloatmin = Random.Range(30, 50);
                randomfloatmax = Random.Range(60, 80);
                nowGauge = 0;
                
            }
        }
    }
}
