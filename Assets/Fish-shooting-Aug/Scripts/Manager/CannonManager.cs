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
    public static void ChangeGunPrefabs(int position,int IntanCanon)
    {
        //Debug.Log(" pos"+position + "cannon"+IntanCanon);
        float rota = cannon[position].transform.localRotation.eulerAngles.z;
        Destroy(cannon[position]);
        cannon[position] = (GameObject)Instantiate(srcCannons[IntanCanon], cannonZone[position].transform.position, cannonZone[position].transform.rotation);
        cannon[position].transform.Rotate(new Vector3(cannonZone[position].transform.rotation.x, cannonZone[position].transform.rotation.y, rota));
        cannon[position].name = "cannon";
        cannon[position].transform.SetParent(cannonZone[position].transform, true);
    } // hàm thay đổi hình ảnh súng
}
