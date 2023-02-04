using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NokogiriMan : MonoBehaviour
{
    public Animator animator;  // アニメーターコンポーネント取得用

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
