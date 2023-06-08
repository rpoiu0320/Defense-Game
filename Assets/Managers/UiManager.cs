using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// UI Stack 구조 찾아보기
public class UIManager : MonoBehaviour
{
    private EventSystem eventSystem;

    private Canvas popUpCanvas;
    private Stack<PopUpUI> popUpStack;

    private Canvas windowCanvas;
    // private List<WindowUI> windowList;

    private Canvas inGameCanvas;

    private void Awake()
    {
        eventSystem = GameManager.Resource.Instantiate<EventSystem>("UI/EventSystem");
        eventSystem.transform.parent = transform;
        eventSystem.name = "EventSystem";

        popUpCanvas = GameManager.Resource.Instantiate<Canvas>("UI/Canvas");
        popUpCanvas.name = "PopUpCanvas";
        popUpCanvas.sortingOrder = 100;

        popUpStack = new Stack<PopUpUI>();

        windowCanvas = GameManager.Resource.Instantiate<Canvas>("UI/Canvas");
        windowCanvas.name = "WindowCanvas";
        windowCanvas.sortingOrder = 10;

        inGameCanvas = GameManager.Resource.Instantiate<Canvas>("UI/Canvas");
        inGameCanvas.name = "InGameCanvas";
        inGameCanvas.sortingOrder = 1;
    }

    public T ShowPopUpUI<T>(T popUpUI) where T : PopUpUI
    {
        if(popUpStack.Count > 0)
        {
            PopUpUI prevUI = popUpStack.Peek();
            prevUI.gameObject.SetActive(false);
        }

        T ui = GameManager.Pool.GetUI(popUpUI);
        ui.transform.SetParent(popUpCanvas.transform, false); // 부모의 이동을 따라가지 않음
        
        popUpStack.Push(ui);

        Time.timeScale = 0f;

        return ui;
    }

    public void ShowPopUpUI(string path)
    {
        PopUpUI ui = GameManager.Resource.Load<PopUpUI>(path);
        ShowPopUpUI(ui);
    }

    public void CloswPopUpUI()
    {
        PopUpUI ui = popUpStack.Pop();
        GameManager.Pool.ReleaseUI(ui.gameObject);

        if(popUpStack.Count > 0)
        {
            PopUpUI curUI = popUpStack.Peek();
            curUI.gameObject.SetActive(true);
        }
        if(popUpStack.Count == 0)
        {
            Time.timeScale = 1f;
        }
    }

    public void ShowWindowUI(WindowUI windowUI)
    {
        WindowUI ui = GameManager.Pool.GetUI(windowUI);
        ui.transform.SetParent(windowCanvas.transform, false);
    }

    public void ShowWindowUI(string path)
    {
        WindowUI ui = GameManager.Resource.Load<WindowUI>(path);
        ShowWindowUI(ui);
    }

    public void SelectWindowUI(WindowUI windowUI)
    {
        windowUI.transform.SetAsLastSibling();      // 계층구조상 맨 아래로
    }

    public void CloseWindowUI(WindowUI windowUI)
    {
        GameManager.Pool.ReleaseUI(windowUI.gameObject);
    }

    public T ShowInGameUI<T>(T inGameUI) where T : InGameUI
    {
        T ui = GameManager.Pool.GetUI(inGameUI);
    }
}