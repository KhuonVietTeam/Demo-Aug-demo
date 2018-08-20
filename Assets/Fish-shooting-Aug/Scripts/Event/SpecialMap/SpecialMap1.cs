using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialMap1 : MonoBehaviour {
    public GameObject[] fish;
    public Transform noiChua;
    GameObject allfish;
    public int soLuong;
    private int temp = 0;
    private float t, rt = 0;
    float[] mang = new float[] { 0, 45, 90, 135, 180, -45, -90, -135 };
    // Use this for initialization
    void Start () {
        fish = Resources.LoadAll<GameObject>("Fishes/SpecialStage1");
	}
	
	// Update is called once per frame
	void Update () {
        if (FishManager.allFishCounter < soLuong)
        {
            if (temp == 4) temp = 0;
            if (Time.time - t > 0.5f)
            {
                for (int a = 0; a < 8; a++)
                {
                    allfish = (GameObject)Instantiate(fish[temp], new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, mang[a] = mang[a] - 10)));
                    FishManager.allFishCounter++;
                    t = Time.time;
                    allfish.transform.SetParent(noiChua, false);
                }
            }
            temp++;

        }
    }
}
