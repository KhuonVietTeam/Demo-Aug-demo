using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEvent : MonoBehaviour
{
    Bunker bunker;
    private GameObject bullet,cannon1,cannon2;
    private void Start()
    {
        cannon1 = GameObject.Find("/CannonObject/baseCannon/cannon");
    }
    private void Awake()
    {
        bunker = new Bunker();
       
    }
    

    public void Shooted() {
        //Instantiate(new GameObject bunker.srcBullets[0], cannon1.transform.position, cannon1.transform.rotation);
        //bullet.transform.SetParent(noiChua, true);
    }
    

}
