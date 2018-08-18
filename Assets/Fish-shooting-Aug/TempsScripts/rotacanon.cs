using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacanon : MonoBehaviour
{
    public float speed = 90f;
    public Transform noiChua;
    public Object bullet, nextgun, pregun;
    public Transform tras;
    public int scorespend;
    public AudioSource Audio;
    public AudioClip gun;
    GameObject allbullet;
    private Animator aniguns;
    // Use this for initialization
    private void Awake()
    {
        aniguns = GetComponent<Animator>();
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        // su kien ban
        if (Input.GetKeyDown(KeyCode.Space))
        {
            aniguns.SetBool("Fire", true);
            //allbullet = (GameObject)Instantiate(bullet, tras.position, tras.rotation);
            Audio.PlayOneShot(gun);
            //// txtpoint.addcscore(-scorespend);
            //allbullet.transform.SetParent(noiChua, true);
        }
        else aniguns.SetBool("Fire", false);
        // doi sung sau
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(nextgun, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        // doi sung truoc
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate(pregun, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
