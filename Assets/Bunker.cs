using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunker : MonoBehaviour {
    //public GameObject[] _srcBullets,_srcCannons,_srcWebs;
    private void Awake()
    {
        srcBullets = Resources.LoadAll<GameObject>("Bullets");
        srcCannons = Resources.LoadAll<GameObject>("Cannons");
        srcWebs = Resources.LoadAll<GameObject>("Webs");
    }
    // Use this for initialization
    public Bunker() {


    }
    public GameObject[] srcBullets, srcCannons, srcWebs;
    // Update is called once per frame
    void Update () {
		
	}
}
