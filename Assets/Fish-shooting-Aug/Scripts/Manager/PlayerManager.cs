using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static int numPlayer = 8;

    //public static List<Player> player = new List<Player>();
    public static Player[] player = new Player[4];

    private void Awake()
    {



        player[0] = new Player("player" + 1, 0, 0);
        player[1] = new Player("player" + 2, 0, 0);
        player[2] = new Player("player" + 3, 0, 0);
        player[3] = new Player("player" + 4, 0, 0);

        //player1 = new Player("player1", 0, 0);
        //player2 = new Player("player2", 0, 0);
        //player3 = new Player("player3", 0, 0);
        //player4 = new Player("player4", 0, 0);    
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

        player[0] = new Player("player" + 1, 100, 0);
        player[1] = new Player("player" + 2, 100, 0);
        player[2] = new Player("player" + 3, 100, 0);
        player[3] = new Player("player" + 4, 100, 0);
    }

}
