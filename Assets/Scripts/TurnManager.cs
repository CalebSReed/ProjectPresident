using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TurnManager : MonoBehaviour
{
    [SerializeField] private int currentTurn;
    [SerializeField] private TextMeshProUGUI turnCounter;

    public event EventHandler OnTurnStart;
    public event EventHandler OnTurnEnd;

    private void Start()
    {
        StartTurn();
    }

    public void StartTurn()
    {
        turnCounter.text = $"Turn: {currentTurn}";
        OnTurnStart?.Invoke(this, System.EventArgs.Empty);
    }

    public void EndTurn()
    {
        currentTurn++;
        UpdateTurnHUD();
        OnTurnEnd?.Invoke(this, System.EventArgs.Empty);
    }

    public void UpdateTurnHUD()
    {
        turnCounter.text = $"Turn: {currentTurn}";
    }
}
