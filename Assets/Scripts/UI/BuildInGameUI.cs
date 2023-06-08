using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildInGameUI : InGameUI
{
    protected override void Awake()
    {
        base.Awake();

        //buttons["Blocker"].onClick.AddListener(() => { CloseInGameUI(); });
    }
}
