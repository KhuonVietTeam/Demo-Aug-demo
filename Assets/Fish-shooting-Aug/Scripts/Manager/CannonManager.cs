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
    
    public List<GameObject> cannonZone = new List<GameObject>();
    //public Transform temp;
    int counter = 0;

    private void Awake()
    {
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



    }
    public static void GetKeyToControl(int orderPlayer, KeyCode SubKey, KeyCode AddKey)
    {
        

        if (Input.GetKey(SubKey)) {

                cannon[orderPlayer].transform.localRotation = Quaternion.Euler(cannon[orderPlayer].transform.rotation.x, cannon[orderPlayer].transform.rotation.y, Mathf.Clamp(cannon[orderPlayer].transform.localRotation.eulerAngles.z + rotationEuler, 10, 170));

            
        }
        if (Input.GetKey(AddKey))
        {
           
                cannon[orderPlayer].transform.localRotation = Quaternion.Euler(cannon[orderPlayer].transform.rotation.x, cannon[orderPlayer].transform.rotation.y, Mathf.Clamp(cannon[orderPlayer].transform.localRotation.eulerAngles.z - rotationEuler, 10, 170));

            
        }

    }
}
