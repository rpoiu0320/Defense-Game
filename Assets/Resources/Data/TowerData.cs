using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "TowerData", menuName = "Data/Tower")] // 우클릭하여 생성할 때 매뉴에 추가되는걸 알 수 있음
public class TowerData : ScriptableObject//, ISerializationCallbackReceiver
{                     // 데이터 저장소로 사용
                      //public TowerInfo[] Towers;

    //public void OnAfterDeserialize()
    //{
    //    //tower = Towers;
    //}

    //public void OnBeforeSerialize()
    //{

    //}

    [SerializeField] public Tower tower;
}
