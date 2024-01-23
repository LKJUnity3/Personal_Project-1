using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputMovement : TopDonwController
{
    private Camera _camera;

    public void Awake()
    {
        _camera = Camera.main;
    }
    public void FixedUpdate()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        _camera.transform.position = new Vector3(x, y, -10);
    }

    public void OnMove(InputValue value)
    {
        
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

}
