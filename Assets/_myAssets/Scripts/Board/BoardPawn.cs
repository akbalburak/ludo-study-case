using System;
using UnityEngine;

public class BoardPawn : MonoBehaviour
{
    public int CurrentPosition => _positionIndex;

    private Vector3 _initialPosition;
    private int _positionIndex;

    private void Awake()
    {
        _initialPosition = transform.position;
    }
    private void OnEnable()
    {
        BoardBusSystem.OnClickReturnAllPawns += OnClickReturnAllPawns;
    }
    private void OnDisable()
    {
        BoardBusSystem.OnClickReturnAllPawns -= OnClickReturnAllPawns;
    }

    private void OnClickReturnAllPawns()
    {
        transform.position = _initialPosition;
        _positionIndex = 0;
    }

    public void OnMouseDown()
    {
        BoardBusSystem.CallClickPawn(this);
    }

    public void UpdatePosition(int newPosition, Vector3 position)
    {
        _positionIndex = newPosition;
        transform.position = position;
    }
}
