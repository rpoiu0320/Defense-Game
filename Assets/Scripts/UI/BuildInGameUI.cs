using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildInGameUI : InGameUI
{
    private TowerPlace towerPlace;

    protected override void Awake()
    {
        base.Awake();

        buttons["Blocker"].onClick.AddListener(() => { GameManager.UI.CloseInGameUI(this); });
        buttons["ArchorButton"].onClick.AddListener(() => { BuildArchorTower(); });
        buttons["CanonButton"].onClick.AddListener(() => { BuildCanonTower(); });
    }

    public void BuildArchorTower()
    {
        TowerData archerTowerData = GameManager.Resource.Load<TowerData>("Data/ArcherTowerData");
        towerPlace.BuildTower(archerTowerData);
        GameManager.UI.CloseInGameUI(this);
    }

    public void BuildCanonTower()
    {
        TowerData canonTowerData = GameManager.Resource.Load<TowerData>("Data/CanonTowerData");
        towerPlace.BuildTower(canonTowerData);
        GameManager.UI.CloseInGameUI(this);
    }

    public void SetTowerPlace(TowerPlace towerPlace)
    {
        this.towerPlace = towerPlace;
    }
}
