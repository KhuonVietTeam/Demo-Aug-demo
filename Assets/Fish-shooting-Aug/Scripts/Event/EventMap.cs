using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMap : MonoBehaviour {
    public GameObject normalMap;
    public GameObject secialMap;
	// Use this for initialization
	void Start () {
        normalMap.gameObject.SetActive(false);
        secialMap.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(timecounter());

    }
    IEnumerator timecounter()
    {
        secialMap.gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        secialMap.gameObject.SetActive(false);
        normalMap.gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        normalMap.gameObject.SetActive(false);
    }
}
