using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialStage : MonoBehaviour
{
    public GameObject[] srcfish;
    public GameObject[] fish;
    public Transform noiChua;
    public float timeStage = 60; //thoi gian 1 man choi
    public float specialTime = 30; //thoi gian ca di theo doi hinh
    public int soLuong;
    private int chon;
    private float WBoard = 1500 / 2;
    private float HBoard = 2200 / 2;    
    GameObject allfish;
    int b = 0, oldchange = 0, i = 0, k = 0;
    float vec, t = 0, timer = 0;
    private int temp = 0, dem = 0;
    private float rt = 0;
    public static bool stop = false, ins = true;
    float[] mang1 = new float[] { 0, 45, 90, 135, 180, -45, -90, -135, 0 };
    float[] diamond = new float[] { 0, 80, 160, 240, 320, 400, 320, 240, 160, 80, 0 };
    float[] rect = new float[] {400, 320, 240, 160, 80};
    float[] tri = new float[] {400, 320, 240, 160, 80, 0 };
    //
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    void Awake()
    {
        srcfish = Resources.LoadAll<GameObject>("Fishes/SpecialStage");
        fish = Resources.LoadAll<GameObject>("Fishes/FishSpecial");
        chon = Random.Range(0, 3);
        BackgroundManager.changeStage = 1;
    }
    //
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    void def()
    {
        i = 0;
        b = 0;
        timer = Time.time;
        stop = false;
    }
    //
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    void Update()
    {
        //if (FishManager.allFishCounter < soLuong)
        {
            /*if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (oldchange == 0) BackgroundManager.changeStage = 1;
                if (oldchange == 1) BackgroundManager.changeStage = 2;
                if (oldchange == 2) BackgroundManager.changeStage = 3;
                if (oldchange == 3) BackgroundManager.changeStage = 4;
                if (oldchange == 4) BackgroundManager.changeStage = 1;
            }*/
            switch (BackgroundManager.changeStage)
            {
                case 1:
                    oldchange = 1; FishManager.allFishCounter = 0;
                    def();
                    break;
                case 2:
                    oldchange = 2;
                    def();
                    break;
                case 3:
                    oldchange = 3;
                    def();
                    break;
                case 4:
                    oldchange = 4;
                    def();
                    break;
            }
            //
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //
            if (oldchange == 1 && BackgroundManager.changeStage == 0) //xac nhan doan code chuyen man da chay xong moi sinh ca      MAN 1
            {
                if (FishManager.allFishCounter < 0) //tai t thay so ca bi am
                {
                    GetComponent<Fishes>().enabled = true; //sau khi doi hinh dac biet chay xong thi cho intstantiate ca nhu binh thuong
                    //GetComponent<Fishes>().soLuong = 30;
                }
                if (Time.time - timer > timeStage)  //khi gop vao chuong trinh chinh thi goi bien thong bao chuyen man o day (bool)
                {                       
                    GetComponent<Fishes>().enabled = false; //stop instantiate ca de chuyen man
                    //GetComponent<Fishes>().soLuong = 0;

                    if (FishManager.allFishCounter < 0)
                    {
                        BackgroundManager.changeStage = 2; // khi gop chuong trinh chinh thi co the an di, doan nay chi dung de test local
                        //timer = Time.time;
                    }
                }
                Special1();
            }
            //
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //
            if (oldchange == 2 && BackgroundManager.changeStage == 0)       //MAN 2
            {
                
                if (Time.time - timer > specialTime && !stop)
                {print(Time.time - timer);
                    stop = true;
                    GetComponent<Fishes>().enabled = true;
                }               
                if (Time.time - timer > timeStage)
                {
                    print(FishManager.allFishCounter);
                    if (FishManager.allFishCounter < 0) BackgroundManager.changeStage = 3;
                    //timer = Time.time;
                    GetComponent<Fishes>().enabled = false;
                    stop = true;
                }
                if (!stop) Special2();
            }
            //
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //
            if (oldchange == 3 && BackgroundManager.changeStage == 0)       //MAN 3
            {
                if (Time.time - timer > specialTime && !stop)
                {
                    stop = true;
                    GetComponent<Fishes>().enabled = true;
                }
                if (Time.time - timer > timeStage)
                {
                    if (FishManager.allFishCounter < 0) BackgroundManager.changeStage = 4;
                    GetComponent<Fishes>().enabled = false;
                }
                if (!stop) Special3();
            }
            //
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //
            if (oldchange == 4 && BackgroundManager.changeStage == 0)       //MAN 4
            {
                if (!stop) Special4();
                if (Time.time - timer > timeStage)
                {
                    if (FishManager.allFishCounter < 0) BackgroundManager.changeStage = 1;
                    GetComponent<Fishes>().enabled = false;
                    //timer = Time.time;
                }
                if (Time.time - timer > specialTime && !stop)
                {
                    stop = true;
                    GetComponent<Fishes>().enabled = true;
                }
            }
        }
    }
    //
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    void Special1()
    {
        if (Time.time - t > 0.75f)
        {
            t = Time.time;
            chon = Random.Range(0, 3);
            i++;
            if (i < 14)
            {
                for (k = 0; k < (diamond[i] / 90); k++) // sinh ca tu bien trai man hinh
                {
                    allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, diamond[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                    FishManager.allFishCounter++;
                    allfish.transform.SetParent(noiChua, false);
                    allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, -diamond[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                    FishManager.allFishCounter++;
                    allfish.transform.SetParent(noiChua, false);
                }
                for (k = 0; k < (diamond[i] / 90); k++) //sinh ca tu bien phai cua man hinh
                {
                    allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(HBoard, diamond[k]), Quaternion.Euler(new Vector3(0, 0, 180)));
                    FishManager.allFishCounter++;
                    allfish.transform.SetParent(noiChua, false);
                    allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(HBoard, -diamond[k]), Quaternion.Euler(new Vector3(0, 0, 180)));
                    FishManager.allFishCounter++;
                    allfish.transform.SetParent(noiChua, false);
                }
            }
        }
    }
    //
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    void Special2()
    {
        if (dem == 4)
        {
            dem = 0;
            b++;
            if (b % 2 == 1)
            {
                t = Time.time;
                if ((b / 2) % 2 == 1) allfish = (GameObject)Instantiate(srcfish[4], new Vector3(-HBoard, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                else allfish = (GameObject)Instantiate(srcfish[5], new Vector3(-HBoard, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                FishManager.allFishCounter++;
                allfish.transform.SetParent(noiChua, false);
            }
        }
        if (Time.time - t > 0.75f)
        {
            t = Time.time;
            dem++;
            chon = Random.Range(0, 4);
            if (b % 2 == 0)
                if (dem == 1 || dem == 2)
                    for (k = 0; k < 6; k++) // sinh ca tu bien trai man hinh
                    {
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                        FishManager.allFishCounter++;
                        allfish.transform.SetParent(noiChua, false);
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, rect[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                        FishManager.allFishCounter++;
                        allfish.transform.SetParent(noiChua, false);
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, -rect[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                        FishManager.allFishCounter++;
                        allfish.transform.SetParent(noiChua, false);
                    }
                else
                    for (k = 0; k < 3; k++) // sinh ca tu bien trai man hinh
                    {
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, rect[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                        FishManager.allFishCounter++;
                        allfish.transform.SetParent(noiChua, false);
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, -rect[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                        FishManager.allFishCounter++;
                        allfish.transform.SetParent(noiChua, false);
                    }
            else
               if (dem == 1 || dem == 2)
                for (k = 0; k < 7; k++) // sinh ca tu bien trai man hinh
                {
                    allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, rect[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                    FishManager.allFishCounter++;
                    allfish.transform.SetParent(noiChua, false);
                    allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, -rect[k]), Quaternion.Euler(new Vector3(0, 0, 0)));
                    FishManager.allFishCounter++;
                    allfish.transform.SetParent(noiChua, false);
                    if (k == 6)
                    {
                        allfish = (GameObject)Instantiate(srcfish[chon], new Vector3(-HBoard, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
                        FishManager.allFishCounter++;
                        allfish.transform.SetParent(noiChua, false);
                    }
                }
        }
    }
    //
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    void Special3()
    {
        if (FishManager.allFishCounter < soLuong)
        {
            if (temp == 7) temp = 0;
            if (Time.time - t > 0.5f)
            {
                for (int a = 0; a < 8; a++)
                {
                    rt = mang1[a] -= 10;
                    allfish = (GameObject)Instantiate(fish[temp], new Vector3(), Quaternion.Euler(new Vector3(0, 0, rt)));
                    FishManager.allFishCounter++;
                    t = Time.time;
                    allfish.transform.SetParent(noiChua, false);
                }
            }
            temp++;

        }
    }
    //
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    void Special4()
    {
        b++;
        if (Time.time - t > 4f)
        {
            t = Time.time;
            if ((b / 2) % 2 == 1) allfish = (GameObject)Instantiate(srcfish[4], new Vector3(-HBoard, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            else allfish = (GameObject)Instantiate(srcfish[5], new Vector3(-HBoard, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            FishManager.allFishCounter++;
            allfish.transform.SetParent(noiChua, false);
        }
    }
}
