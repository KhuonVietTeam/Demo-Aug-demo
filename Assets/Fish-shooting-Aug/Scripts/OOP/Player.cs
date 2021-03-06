﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    //ham dung
    public Player()
    {
        //name = "Clone";
        //wallet = new Wallet(0);
        //bullet = new Bullet(0);
        
    }
    public Player(string _name, int _wallet, int _bullet)
    {
        name = _name;
        wallet = new Wallet(_wallet);
        bullet = new Bullet(_bullet);
    }

    public string name { get; private set; }
    //public Wallet wallet = new Wallet();
    private Wallet wallet;
    private Bullet bullet;

    public int WatchBullet()
    {
        return bullet.Value;
    }

    public int WatchWallet()
    {

        return wallet.Value;
    }

    public void AddBulletValue(int Value)
    {
        bullet.AddValue(Value);
    }

    public void SubBulletValue(int Value)
    {
        if(bullet.Value >= Value)
        {
            bullet.SubValue(Value);

        }
    }

    public int PayAmount(int amountToPay)
    {
        if (wallet.Value >= amountToPay)
        {
            wallet.SubMoney(amountToPay);
            return amountToPay;
        }
        return 0;
    }

    public void GetAmount(int amountToGet)
    {
        wallet.AddMoney(amountToGet);

    }

    public void Info()
    {
        Debug.Log("Name: " + name);
    }
}
