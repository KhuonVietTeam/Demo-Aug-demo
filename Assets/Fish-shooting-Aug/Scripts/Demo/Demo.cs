using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    private GameObject Text1, Text2, Text3, Text4;

    // Use this for initialization
    private void Awake()
    {
        Text1 = GameObject.Find("/Scoreboard/Panel/Player1/Text");
        Text2 = GameObject.Find("/Scoreboard/Panel/Player2/Text");
        Text3 = GameObject.Find("/Scoreboard/Panel/Player3/Text");
        Text4 = GameObject.Find("/Scoreboard/Panel/Player4/Text");

    }
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        Text1.GetComponent<Text>().text = "" + PlayerManager.player[0].WatchWallet();
        Text2.GetComponent<Text>().text = "" + PlayerManager.player[1].WatchWallet();
        Text3.GetComponent<Text>().text = "" + PlayerManager.player[2].WatchWallet();
        Text4.GetComponent<Text>().text = "" + PlayerManager.player[3].WatchWallet();
    }

    public void func1()
    {
        EventManager.coinbuyer.BuyCoin(PlayerManager.player[0]);
    }
    public void func2()
    {
        EventManager.coinbuyer.BuyCoin(PlayerManager.player[1]);
    }
    public void func3()
    {
        EventManager.coinbuyer.BuyCoin(PlayerManager.player[2]);
    }
    public void func4()
    {
        EventManager.coinbuyer.BuyCoin(PlayerManager.player[3]);
    }

}
