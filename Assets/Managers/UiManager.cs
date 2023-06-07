using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    private static EventSystem eventSystem;
    private void Awake()
    {
        eventSystem = GameManager.Resource.Instantiate<EventSystem>("UI/EventSystem");
        eventSystem.transform.parent = transform;
        eventSystem.name = "EventSystem";
    }
}
