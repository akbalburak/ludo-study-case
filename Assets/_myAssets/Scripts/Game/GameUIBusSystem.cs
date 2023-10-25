using System;

public static class GameUIBusSystem
{
    public static Action OnClickRollButton;
    public static void CallClickRollButton()
    {
        OnClickRollButton?.Invoke();
    }
}