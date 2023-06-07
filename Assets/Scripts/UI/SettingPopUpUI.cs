using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopUpUI : PopUpUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["ContinueButton"].onClick.AddListener(() => { GameManager.UI.CloswPopUpUI(); });
        buttons["SettingsButton"].onClick.AddListener(() => { GameManager.UI.ShowPopUpUI("UI/ConfigPopUpUI"); });
    }
}
