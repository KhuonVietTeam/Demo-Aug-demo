using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {


        CannonManager.GetKeyToControl(0, KeyCode.Q, KeyCode.W);
        CannonManager.GetKeyToControl(1, KeyCode.E, KeyCode.R);
        CannonManager.GetKeyToControl(2, KeyCode.T, KeyCode.Y);
        CannonManager.GetKeyToControl(3, KeyCode.U, KeyCode.I);


        BulletManager.GetKeyToChangeBullet(PlayerManager.player[0], KeyCode.A, KeyCode.S);
        BulletManager.GetKeyToChangeBullet(PlayerManager.player[1], KeyCode.D, KeyCode.F);
        BulletManager.GetKeyToChangeBullet(PlayerManager.player[2], KeyCode.G, KeyCode.H);
        BulletManager.GetKeyToChangeBullet(PlayerManager.player[3], KeyCode.J, KeyCode.K);

        BulletManager.GetKeyToShoot(0, PlayerManager.player[0], KeyCode.Alpha1);
        BulletManager.GetKeyToShoot(1, PlayerManager.player[1], KeyCode.Alpha2);
        BulletManager.GetKeyToShoot(2, PlayerManager.player[2], KeyCode.Alpha3);
        BulletManager.GetKeyToShoot(3, PlayerManager.player[3], KeyCode.Alpha4);



    }
    


    
}
