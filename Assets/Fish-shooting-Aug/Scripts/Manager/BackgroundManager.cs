using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackgroundManager : MonoBehaviour {
    public static int changeStage = 0;
    GameObject srcWave;
    private void Awake()
    {
        srcWave = Resources.Load<GameObject>("Wave");
    }
    // Use this for initialization
    void Start () {

    }
    void Waving()
    {
        Instantiate(srcWave, this.transform.position, this.transform.rotation).transform.SetParent(GameObject.Find("WaveZone").transform, false);
        Instantiate(srcWave, this.transform.position, this.transform.rotation).transform.SetParent(GameObject.Find("WaveZone").transform, false);

    }

    // Update is called once per frame
    void Update () {


        if (changeStage!=0)
        {
            
            switch (changeStage)
            {
                case 1:
                    if(this.transform.GetChild(3).GetComponent<Image>().fillAmount == 1)
                    {
                        Waving();
                    }
                    this.transform.GetChild(3).GetComponent<Image>().fillAmount -= (0.001f * 3.25f);
                    this.transform.GetChild(3).GetComponent<Image>().fillOrigin = 0; // 1 trai qua phai, 0 la nguoc lai

                    if (this.transform.GetChild(3).GetComponent<Image>().fillAmount == 0)
                    {
                        changeStage = 0;

                    }
                    
                    break;

                case 2:
                    if (this.transform.GetChild(2).GetComponent<Image>().fillAmount == 1)
                    {
                        Waving();
                    }
                    this.transform.GetChild(2).GetComponent<Image>().fillAmount -= (0.001f * 3.25f);
                    if (this.transform.GetChild(2).GetComponent<Image>().fillAmount == 0)
                    {
                        changeStage = 0;

                    }
                    break;

                case 3:
                    if (this.transform.GetChild(1).GetComponent<Image>().fillAmount == 1)
                    {
                        Waving();
                    }
                    this.transform.GetChild(1).GetComponent<Image>().fillAmount -= (0.001f * 3.25f);
                    if (this.transform.GetChild(1).GetComponent<Image>().fillAmount == 0)
                    {
                        changeStage = 0;

                    }
                    break;

                case 4:
                    if (this.transform.GetChild(3).GetComponent<Image>().fillAmount == 0)
                    {
                        Waving();
                    }
                    this.transform.GetChild(3).GetComponent<Image>().fillOrigin = 1; //DAO CHIEU -> ORIGIN
                    this.transform.GetChild(3).GetComponent<Image>().fillAmount += (0.001f * 3.25f);


                    if (this.transform.GetChild(3).GetComponent<Image>().fillAmount == 1)
                    {
                        this.transform.GetChild(1).GetComponent<Image>().fillAmount = 1f;
                        this.transform.GetChild(2).GetComponent<Image>().fillAmount = 1f;
                        changeStage = 0;

                    }
                    break;
            }
        }

    }
}
