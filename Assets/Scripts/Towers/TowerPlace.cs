using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler //, IDragHandler
{
    [SerializeField] Color normal;
    [SerializeField] Color onMouse;

    private Renderer ren;

    private void Awake()
    {
        ren = GetComponent<Renderer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //if(eventData.button == PointerEventData.InputButton.Left)
        //{
        //    Debug.Log("Left");
        //}
        //else if (eventData.button == PointerEventData.InputButton.Right)
        //{
        //    Debug.Log("Right");
        //}

        BuildInGameUI buildUI = GameManager.UI.ShowInGameUI<BuildInGameUI>("UI/BuildInGameUI");
        //buildUI.SetTowerPlace(this);
        //buildUI.SetTarget(transform);
        //buildUI.SetOffset(new Vector3(200, 0));
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ren.material.color = onMouse;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ren.material.color = normal;
    }

    //public void OnDrag(PointerEventData eventData)
    //{
    //    throw new System.NotImplementedException();
    //}
}
