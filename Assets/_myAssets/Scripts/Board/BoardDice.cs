using System;
using UnityEngine;

public class BoardDice : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private GameObject _container;

    private void OnEnable()
    {
        GameUIBusSystem.OnClickRollButton += OnClickRollDice;
        BoardBusSystem.OnDiceRollResetted += OnDiceRollResetted;
    }
    private void OnDisable()
    {
        BoardBusSystem.OnDiceRollResetted -= OnDiceRollResetted;
        GameUIBusSystem.OnClickRollButton -= OnClickRollDice;
    }

    private void OnDiceRollResetted()
    {
        _container.SetActive(false);
    }

    private void OnClickRollDice()
    {
        int number = RandomDiceService.Instance.GetDiceNumber();

        _container.SetActive(true);
        _animator.Play($"{number}", 0, 0);

        BoardBusSystem.CallDiceRolled(number);
    }
}
