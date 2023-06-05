using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler
{
    [SerializeField] Color normal;
    [SerializeField] Color onMouse;

    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left");
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        renderer.material.color = onMouse;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        renderer.material.color = normal;
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
