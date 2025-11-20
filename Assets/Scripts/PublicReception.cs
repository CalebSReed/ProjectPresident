using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicReception : MonoBehaviour
{
    public float currentPublicReception { get; private set; }
    [SerializeField] private int startingPublicReception;

    private void Awake()
    {
        SetPublicReception(startingPublicReception);
    }

    public void SetPublicReception(float val)
    {
        currentPublicReception = val;
    }

    public void ChangePublicReception(float val)
    {
        currentPublicReception += val;
    }
}
