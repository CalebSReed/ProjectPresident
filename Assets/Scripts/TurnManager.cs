using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TurnManager : MonoBehaviour
{
    private int currentTurn;
    [SerializeField]
    private TextMeshProUGUI turnCounter;

    public event EventHandler OnTurnStart;
    public event EventHandler OnTurnEnd;

    public void StartTurn()
    {
        turnCounter.text = $"Turn: {currentTurn}";
        OnTurnStart?.Invoke(this, System.EventArgs.Empty);
    }

    public void EndTurn()
    {
        OnTurnEnd?.Invoke(this, System.EventArgs.Empty);
    }
}
