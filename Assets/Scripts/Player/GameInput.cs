using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    public static GameInput instance { get; private set; }

    public PlayerInputActions action { get; private set; }

    private void Awake()
    {
        instance = instance ?? this;

        action = new PlayerInputActions();
        action.Enable();
    }
    public Vector2 GetMovementVector()
    {
        return action.Player.Move.ReadValue<Vector2>();
    }

    public bool GetMenuInput()
    {
        return action.UI.MenuOpenClose.WasPressedThisFrame();
    }

    public bool GetUseInput()
    {
        return action.Player.Use.WasPressedThisFrame();
    }

}
