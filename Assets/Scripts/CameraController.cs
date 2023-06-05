using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] float zoomSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float padding;

    Vector3 moveDir;
    private float zoomScroll;

    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        Zoom();
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveDir.y * moveSpeed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * moveDir.x * moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnPointer(InputValue value)
    {
        Vector2 mousePos = value.Get<Vector2>();

        if (mousePos.x <= padding)
            moveDir.x -= 1;
        else if (mousePos.x >= Screen.width - padding)
            moveDir.x += 1;
        else
            moveDir.x = 0;
    }

    private void Zoom()
    {
        /*Camera.main.*/transform.Translate(Vector3.forward * zoomScroll * zoomSpeed * Time.deltaTime, Space.Self);
    }

    private void OnZoom(InputValue value)
    {
        zoomScroll = value.Get<Vector2>().y;
    }
}
