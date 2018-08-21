using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialMap : MonoBehaviour {
    // Use this for initializationư
    public GameObject[] xFish;
    public Transform noiChua;
    GameObject allfish;
    public int soLuong;
    private int temp = 0;
    private float t, rt = 0;
    float[] mang1 = new float[] { 0, 45, 90, 135, 180, -45, -90, -135};
    void Awake()
    {
        xFish = Resources.LoadAll<GameObject>("Fishes/XFishSpecial");
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (FishManager.allFishCounter < soLuong)
        {
            if (temp == 3) temp = 0;
            if (Time.time - t > 0.5f)
            {
                for (int a = 0; a < 8; a++)
                {
                    allfish = (GameObject)Instantiate(xFish[temp], new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, mang1[a])));
                    FishManager.allFishCounter++;
                    t = Time.time;
                    allfish.transform.SetParent(noiChua, false);
                }
            }
            temp++;

        }
    }
}
