using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasury : MonoBehaviour
{
    public float currentMoney {  get; private set; }
    [SerializeField] private int startingMoneyAmount;

    private void Awake()
    {
        SetMoney(startingMoneyAmount);
    }

    public void SetMoney(float val)
    {
        currentMoney = val;
    }

    public void ChangeMoney(float val)
    {
        currentMoney += val;
    }
}
