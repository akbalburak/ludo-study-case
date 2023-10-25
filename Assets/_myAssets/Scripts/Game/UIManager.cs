using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _loadingUI;
    [SerializeField] private GameObject _gameUI;

    private void OnEnable()
    {
        GameBusSystem.OnPlaygroundLoading += OnPlaygroundLoading;
        GameBusSystem.OnPlaygroundLoaded += OnPlaygroundLoaded;
    }
    private void OnDisable()
    {
        GameBusSystem.OnPlaygroundLoading -= OnPlaygroundLoading;
        GameBusSystem.OnPlaygroundLoaded -= OnPlaygroundLoaded;
    }

    private void OnPlaygroundLoading()
    {
        _loadingUI.SetActive(true);
        _gameUI.SetActive(false);
    }
    private void OnPlaygroundLoaded()
    {
        _loadingUI.SetActive(false);
        _gameUI.SetActive(true);
    }
}
