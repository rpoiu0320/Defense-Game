using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "TowerData", menuName = "Data/Tower")] // ��Ŭ���Ͽ� ������ �� �Ŵ��� �߰��Ǵ°� �� �� ����
public class TowerData : ScriptableObject//, ISerializationCallbackReceiver
{                     // ������ ����ҷ� ���
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
