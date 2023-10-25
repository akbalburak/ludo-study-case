using System;

public static class GameBusSystem
{
    public static Action OnPlaygroundLoading;
    public static void CallPlaygroundLoading()
    {
        OnPlaygroundLoading?.Invoke();
    }

    public static Action OnPlaygroundLoaded;
    public static void CallPlaygroundLoaded()
    {
        OnPlaygroundLoaded?.Invoke();
    }
}