using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public Timer timer;
    GameObject sawman;
    NokogiriMan sawmanscript;
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

        sawman = GameObject.Find("SawMan");
        sawmanscript = sawman.GetComponent<NokogiriMan>();
    }

    // 更新処理
    void Update()
    {
    }

    // タイムアップ処理
    void onTimeup() {
        Debug.Log ("time up");
    }

    public void BadEndScene()
    {

    }

    public void NormOverEndScene()
    {

    }

    public void HappyEndScene()
    {

    }

    public void NoNormEndScene()
    {

    }

    public void BreakSawEndScene()
    {

    }
}
