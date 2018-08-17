using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour {
    
    public GameObject[] srcBullets, srcCannons, srcWebs;
    private GameObject bullet, cannon1, cannon2, cannon3, cannon4;
    private Transform bulletZone;

    // Use this for initialization
    void Awake () {
        srcBullets = Resources.LoadAll<GameObject>("Bullets");
        srcCannons = Resources.LoadAll<GameObject>("Cannons");
        srcWebs = Resources.LoadAll<GameObject>("Webs");
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
    void Update () {
        //nguoi choi 1 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            bullet = (GameObject)Instantiate(srcBullets[0], cannon1.transform.position, cannon1.transform.rotation);
            bullet.name = "bullet" + 1;
            bullet.transform.SetParent(bulletZone, true);

                    }
        //nguoi choi 2 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            bullet = (GameObject)Instantiate(srcBullets[0], cannon2.transform.position, cannon2.transform.rotation);
            bullet.name = "bullet" + 2;
            bullet.transform.SetParent(bulletZone, true);

        }
        //nguoi choi 3 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            bullet = (GameObject)Instantiate(srcBullets[0], cannon3.transform.position, cannon3.transform.rotation);
            bullet.name = "bullet" + 3;
            bullet.transform.SetParent(bulletZone, true);

        }
        //nguoi choi 3 Bắn
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            bullet = (GameObject)Instantiate(srcBullets[0], cannon4.transform.position, cannon4.transform.rotation);
            bullet.name = "bullet" + 4;
            bullet.transform.SetParent(bulletZone, true);

        }
    }
}
