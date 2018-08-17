using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{

    private void Awake()
    {


    }
    private void Start()
    {


    }
    public Wallet()
    {
        Value = 0;
    }
    public Wallet(int initialAmount)
    {
        Value = initialAmount;
    }

    public int Value { get; private set; }

    public void AddMoney(int amount)
    {
        Value += amount;
    }

    public void SubMoney(int amount)
    {
        Value -= amount;
    }
    public void Info()
    {
        Debug.Log("Amount: " + Value);

    }
}


