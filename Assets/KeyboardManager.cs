using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    BulletSeller bulletseller;
    private Player player1, player2, player3, player4;
    private Bullet bullet1, bullet2; //note

    public GameObject[] srcBullets, srcCannons, srcWebs;
    private GameObject bullet, cannon1, cannon2, cannon3, cannon4;
    private Transform bulletZone;

    // Use this for initialization
    void Awake()
    {
        bulletseller = new BulletSeller();
        srcBullets = Resources.LoadAll<GameObject>("Bullets");
        srcCannons = Resources.LoadAll<GameObject>("Cannons");
        srcWebs = Resources.LoadAll<GameObject>("Webs");
        player1 = new Player("player1", 100, 1);
        player2 = new Player("player2", 100, 1);
        player3 = new Player("player3", 100, 1);
        player4 = new Player("player4", 100, 1);


    }
    private void Start()
    {


        cannon1 = GameObject.Find("/CannonObject/baseCannon1/cannon");
        cannon2 = GameObject.Find("/CannonObject/baseCannon2/cannon");
        cannon3 = GameObject.Find("/CannonObject/baseCannon3/cannon");
        cannon4 = GameObject.Find("/CannonObject/baseCannon4/cannon");
        bulletZone = transform.Find("/CannonObject/bulletZone");

    }

    // Update is called once per frame
    void Update()
    {

        GetKeyToShoot();
        GetKeyToRotate();


    }
    void GetKeyToRotate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            cannon1.transform.localRotation = Quaternion.Euler(cannon1.transform.rotation.x, cannon1.transform.rotation.y, Mathf.Clamp(cannon1.transform.localRotation.eulerAngles.z + 1, 10, 170));

        }
        else if (Input.GetKey(KeyCode.W))
        {
            cannon1.transform.localRotation = Quaternion.Euler(cannon1.transform.rotation.x, cannon1.transform.rotation.y, Mathf.Clamp(cannon1.transform.localRotation.eulerAngles.z - 1, 10, 170));
        }
        if (Input.GetKey(KeyCode.E))
        {
            cannon2.transform.localRotation = Quaternion.Euler(cannon2.transform.rotation.x, cannon2.transform.rotation.y, Mathf.Clamp(cannon2.transform.localRotation.eulerAngles.z + 1, 10, 170));

        }
        else if (Input.GetKey(KeyCode.R))
        {
            cannon2.transform.localRotation = Quaternion.Euler(cannon2.transform.rotation.x, cannon2.transform.rotation.y, Mathf.Clamp(cannon2.transform.localRotation.eulerAngles.z - 1, 10, 170));
        }
        if (Input.GetKey(KeyCode.T))
        {
            cannon3.transform.localRotation = Quaternion.Euler(cannon3.transform.rotation.x, cannon3.transform.rotation.y, Mathf.Clamp(cannon3.transform.localRotation.eulerAngles.z + 1, 10, 170));

        }
        else if (Input.GetKey(KeyCode.Y))
        {
            cannon3.transform.localRotation = Quaternion.Euler(cannon3.transform.rotation.x, cannon3.transform.rotation.y, Mathf.Clamp(cannon3.transform.localRotation.eulerAngles.z - 1, 10, 170));
        }
        if (Input.GetKey(KeyCode.U))
        {
            cannon4.transform.localRotation = Quaternion.Euler(cannon4.transform.rotation.x, cannon4.transform.rotation.y, Mathf.Clamp(cannon4.transform.localRotation.eulerAngles.z + 1, 10, 170));

        }
        else if (Input.GetKey(KeyCode.I))
        {
            cannon4.transform.localRotation = Quaternion.Euler(cannon4.transform.rotation.x, cannon4.transform.rotation.y, Mathf.Clamp(cannon4.transform.localRotation.eulerAngles.z - 1, 10, 170));
        }
    }
    void GetKeyToShoot()
    {
        //nguoi choi 1 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            bullet = (GameObject)Instantiate(srcBullets[0], cannon1.transform.position, cannon1.transform.rotation);
            bullet.name = "bullet" + 1;
            bullet.transform.SetParent(bulletZone, true);

            bulletseller.SellBullet(player1);
            Debug.Log("player 1: " + player1.WatchWallet());


        }
        //nguoi choi 2 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            bullet = (GameObject)Instantiate(srcBullets[0], cannon2.transform.position, cannon2.transform.rotation);
            bullet.name = "bullet" + 2;
            bullet.transform.SetParent(bulletZone, true);

            bulletseller.SellBullet(player2);
            Debug.Log("player 2: " + player2.WatchWallet());

        }
        //nguoi choi 3 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            bullet = (GameObject)Instantiate(srcBullets[0], cannon3.transform.position, cannon3.transform.rotation);
            bullet.name = "bullet" + 3;
            bullet.transform.SetParent(bulletZone, true);

            bulletseller.SellBullet(player3);
            Debug.Log("player 3: " + player3.WatchWallet());

        }
        //nguoi choi 3 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            bullet = (GameObject)Instantiate(srcBullets[0], cannon4.transform.position, cannon4.transform.rotation);
            bullet.name = "bullet" + 4;
            bullet.transform.SetParent(bulletZone, true);

            bulletseller.SellBullet(player4);
            Debug.Log("player 4: " + player4.WatchWallet());

        }


    }
}
