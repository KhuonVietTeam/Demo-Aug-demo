using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public static Player player1, player2, player3, player4;
    private void Awake()
    {
        player1 = new Player("player1", 100, 1);
        player2 = new Player("player2", 10, 1);
        player3 = new Player("player3", 10, 1);
        player4 = new Player("player4", 10, 1);
    }
    

}
