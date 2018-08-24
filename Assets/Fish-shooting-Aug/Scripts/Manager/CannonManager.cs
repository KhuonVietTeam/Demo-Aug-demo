using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager:MonoBehaviour  {
    //public static GameObject[] cannon;

    //public List<GameObject> cannon = new List<GameObject>();
    public static int numCannon = 4;
    public static GameObject[] cannon=new GameObject[4];
    public static GameObject[] srcCannons;
    public static float rotationEuler = 2;
    
    public static List<GameObject> cannonZone = new List<GameObject>();
    //public Transform temp;
    int counter = 0;

    private void Awake()
    {
        // load gameobject
        srcCannons = Resources.LoadAll<GameObject>("Cannons");

    }
    private void Start()
    {
        for(int i =0; i < numCannon; i++)
        {
            cannonZone.Add(GameObject.Find("CannonObject/baseCannon" + (i + 1)));

        }
        foreach (GameObject i in cannonZone)
        {
            
            cannon[counter]=(GameObject)Instantiate(srcCannons[0], i.transform.position, i.transform.rotation);
            cannon[counter].transform.Rotate(new Vector3(i.transform.rotation.x, i.transform.rotation.y, i.transform.rotation.z+90));
            cannon[counter].name = "cannon";
            cannon[counter].transform.SetParent(i.transform, true);
            counter++;
        }
    } // khởi tạo 4 súng trên 4 ụ súng được đặt sẵn
    public static void GetKeyToControl(int orderPlayer, KeyCode SubKey, KeyCode AddKey)
    {
        

        if (Input.GetKey(SubKey)) {

                cannon[orderPlayer].transform.localRotation = Quaternion.Euler(cannon[orderPlayer].transform.rotation.x, cannon[orderPlayer].transform.rotation.y, Mathf.Clamp(cannon[orderPlayer].transform.localRotation.eulerAngles.z + rotationEuler, 10, 170));

            
        }
        if (Input.GetKey(AddKey))
        {
           
                cannon[orderPlayer].transform.localRotation = Quaternion.Euler(cannon[orderPlayer].transform.rotation.x, cannon[orderPlayer].transform.rotation.y, Mathf.Clamp(cannon[orderPlayer].transform.localRotation.eulerAngles.z - rotationEuler, 10, 170));

            
        }

    } // hàm thay đổi góc quay
    static void ChangeGunPrefabs(Player player,int IntanCanon)
    {
        float rota = cannon[GetIDFromName(player)].transform.localRotation.eulerAngles.z;
        Destroy(cannon[GetIDFromName(player)]);
        cannon[GetIDFromName(player)] = (GameObject)Instantiate(srcCannons[IntanCanon], cannonZone[GetIDFromName(player)].transform.position, cannonZone[GetIDFromName(player)].transform.rotation);
        cannon[GetIDFromName(player)].transform.Rotate(new Vector3(cannonZone[GetIDFromName(player)].transform.rotation.x, cannonZone[GetIDFromName(player)].transform.rotation.y, rota));
        cannon[GetIDFromName(player)].name = "cannon";
        cannon[GetIDFromName(player)].transform.SetParent(cannonZone[GetIDFromName(player)].transform, true);

    } // hàm thay đổi hình ảnh súng
    public static void ChangeGun(Player player) // hàm gọi class cannon thay đổi súng 
    {
        if (player.WatchBullet() >= 150)
        {
            CannonManager.ChangeGunPrefabs(player, 6);
            
        }
        else if (player.WatchBullet() >= 125)
        {
            CannonManager.ChangeGunPrefabs(player, 5);
        }
        else if (player.WatchBullet() >= 100)
        {
            CannonManager.ChangeGunPrefabs(player, 4);
        }
        else if (player.WatchBullet() >= 75)
        {
            CannonManager.ChangeGunPrefabs(player, 3);
        }
        else if (player.WatchBullet() >= 50)
        {
            CannonManager.ChangeGunPrefabs(player, 2);
        }
        else if (player.WatchBullet() >= 25)
        {
            CannonManager.ChangeGunPrefabs(player, 1);
        }
        else
        {
            CannonManager.ChangeGunPrefabs(player, 0);
        }
    }
    static int GetIDFromName(Player player) // lấy id từ thuộc tính name của player. cần thêm thuộc tính id cho player
    {
        for(int i = 1; i <= numCannon; i++)
        {
            if (player.name == "player" + i)
                return --i;
        }
        return -1;
    }
}
