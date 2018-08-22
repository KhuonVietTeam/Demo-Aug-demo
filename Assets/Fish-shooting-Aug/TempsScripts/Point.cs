using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    //public List<GameObject> scoreZone = new List<GameObject>();
    public GameObject thisNumber;
    private GameObject[] srcNumbers;
    int oldValue = 0;
    int nghin = 0;
    int tram = 0;
    int chuc = 0;
    int donvi = 0;
    // Use this for initialization
    void Awake()
    {
        srcNumbers = Resources.LoadAll<GameObject>("Numbers");
        thisNumber = this.gameObject;

    }
    void Start()
    {
        Instantiate(srcNumbers[0], this.transform.position, this.transform.rotation).transform.SetParent(this.transform, true);

    }

    // Update is called once per frame
    void Update()
    {

        int Value = PlayerManager.player[int.Parse(this.transform.parent.name)-1].WatchWallet();


        if (Value - oldValue != 0)
        {
            switch (int.Parse(thisNumber.name))
            {
                case 9:
                    Destroy(this.gameObject.transform.GetChild(0).gameObject);
                    donvi = (Value % 100) % 10;
                    Instantiate(srcNumbers[donvi], this.transform.position, this.transform.rotation).transform.SetParent(this.transform,true);
                    break;

                case 99:
                    Destroy(this.gameObject.transform.GetChild(0).gameObject);
                    chuc = (Value % 100) / 10;
                    Instantiate(srcNumbers[chuc], this.transform.position, this.transform.rotation).transform.SetParent(this.transform, true);
                    break;

                case 999:
                    Destroy(this.gameObject.transform.GetChild(0).gameObject);
                    tram = (Value % 1000) / 100;
                    Instantiate(srcNumbers[tram], this.transform.position, this.transform.rotation).transform.SetParent(this.transform, true);
                    break;

                case 9999:
                    Destroy(this.gameObject.transform.GetChild(0).gameObject);
                    nghin = Value / 1000;
                    Instantiate(srcNumbers[nghin], this.transform.position, this.transform.rotation).transform.SetParent(this.transform, true);
                    break;

            }

            oldValue = Value;
        }

    }
}
