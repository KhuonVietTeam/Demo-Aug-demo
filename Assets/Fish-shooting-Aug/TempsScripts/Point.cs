using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public GameObject[] numbers;
    public GameObject Nghin;
    public GameObject Tram;
    public GameObject Chuc;
    public GameObject DonVi;
    int temp;
    GameObject counter1;
    GameObject counter2;
    GameObject counter3;
    GameObject counter4;
    int nghin =0;
    int tram = 0;
    int chuc = 0;
    int donvi =0;
    // Use this for initialization
    void Awake()
    {
        numbers = Resources.LoadAll<GameObject>("Numbers");
    }
    void Start () {
        counter4 = (GameObject)Instantiate(numbers[nghin], Nghin.transform.position, Nghin.transform.rotation);
        counter3 = (GameObject)Instantiate(numbers[tram], Tram.transform.position, Tram.transform.rotation);
        counter2 = (GameObject)Instantiate(numbers[chuc], Chuc.transform.position, Chuc.transform.rotation);
        counter1 = (GameObject)Instantiate(numbers[donvi], DonVi.transform.position, DonVi.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        int value = FishShooted.pointvalue;
        if (value - temp != 0)
        {
            //Debug.Log(value);
            //Debug.Log(value1);
            nghin = value / 1000;
            tram = (value % 1000) / 100;
            chuc = (value % 100) / 10;
            donvi = (value % 100) % 10;
            Destroy(counter4);
            counter4 = (GameObject)Instantiate(numbers[nghin], Nghin.transform.position, Nghin.transform.rotation);
            Destroy(counter3);
            counter3 = (GameObject)Instantiate(numbers[tram], Tram.transform.position, Tram.transform.rotation);
            Destroy(counter2);
            counter2 = (GameObject)Instantiate(numbers[chuc], Chuc.transform.position, Chuc.transform.rotation);
            Destroy(counter1);
            counter1 = (GameObject)Instantiate(numbers[donvi], DonVi.transform.position, DonVi.transform.rotation);
            temp = value;
        }
    }
}
