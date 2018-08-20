using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public static Player player1, player2, player3, player4;
    
    private void Awake()
    {
        
        player1 = new Player("player1", 0, 0);
        player2 = new Player("player2", 0, 0);
        player3 = new Player("player3", 0, 0);
        player4 = new Player("player4", 0, 0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Demo();
        }
    }
    private void Demo()
    {

        player1 = new Player("player1", 100, 0);
        player2 = new Player("player2", 100, 0);
        player3 = new Player("player3", 100, 0);
        player4 = new Player("player4", 100, 0);
    }

}
