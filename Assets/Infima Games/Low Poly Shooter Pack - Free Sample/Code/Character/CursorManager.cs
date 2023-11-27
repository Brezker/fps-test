using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CursorManager : MonoBehaviour
{
    private bool cursorLocked = true;

    private void Start()
    {
        // Bloquea el cursor y lo hace invisible al inicio del juego.
        LockCursor();
    }

    private void Update()
    {
        // Aquí puedes agregar lógica adicional según tus necesidades.
    }

    public void LockCursor()
    {
        cursorLocked = true;
        UpdateCursorState();
    }

    public void UnlockCursor()
    {
        cursorLocked = false;
        UpdateCursorState();
    }

    private void UpdateCursorState()
    {
        Cursor.lockState = cursorLocked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !cursorLocked;
    }
}


