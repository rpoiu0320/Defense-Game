using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingSceneUI : SceneUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["InfoButton"].onClick.AddListener(() => { OpenInfoWindowUI(); });
        buttons["VolumeButton"].onClick.AddListener(() => { Debug.Log("Volume"); });
        buttons["SettingButton"].onClick.AddListener(() => { OpenPausePopUpUI(); });
    }

    public void OpenInfoWindowUI()
    {
        GameManager.UI.ShowWindowUI("UI/InfoWindowUI");
    }

    public void OpenPausePopUpUI()
    {
        //PopUpUI ui = GameManager.Resource.Load<PopUpUI>("UI/Image");
        //GameManager.UI.ShowPopUpUI(ui);

        GameManager.UI.ShowPopUpUI("UI/SettingPopUpUI");
    }
}