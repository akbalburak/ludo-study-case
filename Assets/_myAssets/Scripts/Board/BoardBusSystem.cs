using System;

public static class BoardBusSystem
{

    public static EventHandler OnClickPawn;
    public static void CallClickPawn(BoardPawn boardPawn)
    {
        OnClickPawn?.Invoke(boardPawn, EventArgs.Empty);
    }

    public static Action OnClickReturnAllPawns;
    public static void CallClickReturnAllPawns()
    {
        OnClickReturnAllPawns?.Invoke();
    }

    public static Action<int> OnDiceRolled;
    public static void CallDiceRolled(int number)
    {
        OnDiceRolled?.Invoke(number);
    }

    public static Action OnDiceRollResetted;
    public static void CallDiceRollResetted()
    {
        OnDiceRollResetted?.Invoke();
    }
}