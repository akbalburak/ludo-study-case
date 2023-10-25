using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Button _rollButton;
    [SerializeField] private Button _returnAllPawnsButton;

    // Start is called before the first frame update
    void Awake()
    {
        _rollButton.onClick.RemoveAllListeners();
        _rollButton.onClick.AddListener(OnClickRollButton);

        _returnAllPawnsButton.onClick.RemoveAllListeners();
        _returnAllPawnsButton.onClick.AddListener(OnClickReturnAllPawns);
    }

    private void OnClickRollButton()
    {
        GameUIBusSystem.CallClickRollButton();
    }
    private void OnClickReturnAllPawns()
    {
        BoardBusSystem.CallClickReturnAllPawns();
    }
}
