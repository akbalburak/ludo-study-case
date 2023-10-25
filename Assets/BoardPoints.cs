using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPoints : MonoBehaviour
{
    [SerializeField] private Transform _greenPointParent;

    private int _currentDiceNumber;

    private void OnEnable()
    {
        BoardBusSystem.OnClickPawn += OnClickPawn;
        BoardBusSystem.OnDiceRolled += OnDiceRolled;
    }
    private void OnDisable()
    {
        BoardBusSystem.OnClickPawn -= OnClickPawn;
        BoardBusSystem.OnDiceRolled -= OnDiceRolled;
    }

    private void OnDiceRolled(int number)
    {
        _currentDiceNumber = number;
    }

    private void OnClickPawn(object sender, EventArgs e)
    {
        if (_currentDiceNumber == 0)
            return;

        BoardPawn pawn = (BoardPawn)sender;

        // WE MAKE SURE PAWN DIDN'T EXCEED THE END POINT.
        int nextPosition = pawn.CurrentPosition + _currentDiceNumber;
        if (nextPosition >= _greenPointParent.childCount)
            return;

        Transform nextPoint = _greenPointParent.GetChild(nextPosition - 1);
        pawn.UpdatePosition(nextPosition, nextPoint.position);

        _currentDiceNumber = 0;

        BoardBusSystem.CallDiceRollResetted();
    }
}
