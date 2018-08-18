using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
 
    int counter = 0; //tranh viec bullet vao point-to-shot Zone thi bi can ban luc o hang code addforce
    public GameObject srcweb;
    private GameObject web;
    public float power = 1000f;
    private Transform WebZone;

    private void Start()
    {
        //getcomponent
         WebZone= transform.Find("/WebZone");

    }
    void OnTriggerEnter2D(Collider2D taget)
    {
        if (taget.gameObject.tag == "FirePoint" && counter == 0)
        {
            counter++;
            GetComponent<Rigidbody2D>().AddForce(transform.up * power);
        }
        // khi vien dan cham vao ca
        // khoi tao 1 web tai vi tri va cham
        if (taget.gameObject.tag == "fish")
        {
            
            web= (GameObject)Instantiate(srcweb, transform.position,transform.rotation);
            web.name = "web";
            web.transform.SetParent(WebZone, true);
            web.GetComponent<WebInfo>().firer = this.gameObject.GetComponent<BulletInfo>().firer;
            web.GetComponent<WebInfo>().rangePower = this.gameObject.GetComponent<BulletInfo>().rangePower;
            Destroy(this.gameObject);

        }
    }
}
