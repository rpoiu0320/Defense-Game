using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// UI 바인딩 사용

public class InfoSceneUI : SceneUI
{
    public TMP_Text heartText;
    public TMP_Text coinText;

    protected override void Awake()
    {
        base.Awake();

        //heartText = texts["HeartText"];
        //coinText = texts["CoinText"];

        //heartText.text = 10.ToString();

        texts["HeartText"].text = "10";
        texts["CoinText"].text = "100";
    }
}
