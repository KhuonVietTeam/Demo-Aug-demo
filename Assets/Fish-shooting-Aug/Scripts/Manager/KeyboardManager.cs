using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    private Bullet bullet1, bullet2; //note

    //public GameObject[] srcBullets, srcWebs;
    //BulletManager bulletmanager;

    // Use this for initialization
    void Awake()
    {
        //srcWebs = Resources.LoadAll<GameObject>("Webs");
        //bulletmanager = new BulletManager();



    }
    private void Start()
    {



        //bulletZone = transform.Find("/CannonObject/bulletZone");

    }

    // Update is called once per frame
    void Update()
    {

        //GetKeyToShoot();

        CannonManager.GetKeyToControl(0, KeyCode.Q, KeyCode.W);
        CannonManager.GetKeyToControl(1, KeyCode.E, KeyCode.R);
        CannonManager.GetKeyToControl(2, KeyCode.T, KeyCode.Y);
        CannonManager.GetKeyToControl(3, KeyCode.U, KeyCode.I);


        BulletManager.GetKeyToChangeBullet(PlayerManager.player1, KeyCode.A, KeyCode.S);
        BulletManager.GetKeyToChangeBullet(PlayerManager.player2, KeyCode.D, KeyCode.F);
        BulletManager.GetKeyToChangeBullet(PlayerManager.player3, KeyCode.G, KeyCode.H);
        BulletManager.GetKeyToChangeBullet(PlayerManager.player4, KeyCode.J, KeyCode.K);

        BulletManager.GetKeyToShoot(0, PlayerManager.player1, KeyCode.Alpha1);
        BulletManager.GetKeyToShoot(1, PlayerManager.player2, KeyCode.Alpha2);
        BulletManager.GetKeyToShoot(2, PlayerManager.player3, KeyCode.Alpha3);
        BulletManager.GetKeyToShoot(3, PlayerManager.player4, KeyCode.Alpha4);



    }
    void GetKeyToRotate()
    {
        //nguoi choi 1
        if (Input.GetKey(KeyCode.Q))
        {

        }
        else if (Input.GetKey(KeyCode.W))
        {
        }

        //nguoi choi 2
        if (Input.GetKey(KeyCode.E))
        {
            //cannon2.transform.localRotation = Quaternion.Euler(cannon2.transform.rotation.x, cannon2.transform.rotation.y, Mathf.Clamp(cannon2.transform.localRotation.eulerAngles.z + 2, 10, 170));

        }
        else if (Input.GetKey(KeyCode.R))
        {
            //cannon2.transform.localRotation = Quaternion.Euler(cannon2.transform.rotation.x, cannon2.transform.rotation.y, Mathf.Clamp(cannon2.transform.localRotation.eulerAngles.z - 2, 10, 170));
        }

        //nguoi choi 3
        if (Input.GetKey(KeyCode.T))
        {
            //cannon3.transform.localRotation = Quaternion.Euler(cannon3.transform.rotation.x, cannon3.transform.rotation.y, Mathf.Clamp(cannon3.transform.localRotation.eulerAngles.z + 2, 10, 170));

        }
        else if (Input.GetKey(KeyCode.Y))
        {
            //cannon3.transform.localRotation = Quaternion.Euler(cannon3.transform.rotation.x, cannon3.transform.rotation.y, Mathf.Clamp(cannon3.transform.localRotation.eulerAngles.z - 2, 10, 170));
        }

        //nguoi choi 4
        if (Input.GetKey(KeyCode.U))
        {
            //cannon4.transform.localRotation = Quaternion.Euler(cannon4.transform.rotation.x, cannon4.transform.rotation.y, Mathf.Clamp(cannon4.transform.localRotation.eulerAngles.z + 2, 10, 170));

        }
        else if (Input.GetKey(KeyCode.I))
        {
            //cannon4.transform.localRotation = Quaternion.Euler(cannon4.transform.rotation.x, cannon4.transform.rotation.y, Mathf.Clamp(cannon4.transform.localRotation.eulerAngles.z - 2, 10, 170));
        }
    }
    void GetKeyToShoot()
    {
        //nguoi choi 1 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {



        }
        //nguoi choi 2 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            if (PlayerManager.player2.WatchWallet() > 0)
            {
                //bullet = (GameObject)Instantiate(srcBullets[0], cannon2.transform.position, cannon2.transform.rotation);
                //bullet.name = "bullet" + 2;
                //bullet.transform.SetParent(bulletZone, true);

                //bullet.GetComponent<BulletInfo>().firer = PlayerManager.player2; //fill .firer to who is shooted
                //bullet.GetComponent<BulletInfo>().rangePower = PlayerManager.player2.WatchBullet(); //fill .rangePower to how many range of power

                EventManager.bulletseller.SellBullet(PlayerManager.player2);

                //Debug.Log("player 2: " + PlayerManager.player2.WatchWallet());

            }
            else
            {
                Debug.Log("player 2: Gameover");

            }

        }
        //nguoi choi 3 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (PlayerManager.player3.WatchWallet() > 0)
            {
                //bullet = (GameObject)Instantiate(srcBullets[0], cannon3.transform.position, cannon3.transform.rotation);
                //bullet.name = "bullet" + 3;
                //bullet.transform.SetParent(bulletZone, true);

                //bullet.GetComponent<BulletInfo>().firer = PlayerManager.player3; //fill .firer to who is shooted
                //bullet.GetComponent<BulletInfo>().rangePower = PlayerManager.player3.WatchBullet(); //fill .rangePower to how many range of power

                EventManager.bulletseller.SellBullet(PlayerManager.player3);

                //Debug.Log("player 3: " + PlayerManager.player3.WatchWallet());

            }
            else
            {
                Debug.Log("player 3: Gameover");

            }
        }

        //nguoi choi 3 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

            if (PlayerManager.player4.WatchWallet() > 0)
            {
                //bullet = (GameObject)Instantiate(srcBullets[0], cannon4.transform.position, cannon4.transform.rotation);
                //bullet.name = "bullet" + 4;
                //bullet.transform.SetParent(bulletZone, true);

                //bullet.GetComponent<BulletInfo>().firer = PlayerManager.player4; //fill .firer to who is shooted
                //bullet.GetComponent<BulletInfo>().rangePower = PlayerManager.player4.WatchBullet(); //fill .rangePower to how many range of power

                EventManager.bulletseller.SellBullet(PlayerManager.player4);

                //Debug.Log("player 4: " + PlayerManager.player4.WatchWallet());

            }
            else
            {
                Debug.Log("player 4: Gameover");

            }

        }


    }
}
