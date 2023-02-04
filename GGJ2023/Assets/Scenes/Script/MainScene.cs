using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    public Timer timer;

    // 開始処理
    void Start()
    {
        // タイムアップの通知設定
        timer.onTimeupDelegate = onTimeup;

        // 制限時間を決める
        System.Random rnd = new System.Random();
        int time = rnd.Next(5, 10);//5から10（仮）

        // タイマー時間を設定
        timer.set(time);
        // タイマー開始
        timer.timerStart();
    }

    // 更新処理
    void Update()
    {
    }

    // タイムアップ処理
    void onTimeup() {
        Debug.Log ("time up");
    }
}
