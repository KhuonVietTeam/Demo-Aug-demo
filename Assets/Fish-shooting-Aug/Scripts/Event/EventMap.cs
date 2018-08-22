using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMap : MonoBehaviour {
    public GameObject normalMap;
    public GameObject specialMap;
    public GameObject Fishes;
    private int counter = 0;
    
	// Use this for initialization
	void Start () {
        Fishes.gameObject.SetActive(false);
        normalMap.gameObject.SetActive(false);
        specialMap.gameObject.SetActive(false);
	}
    public static int flag = 1;
	// Update is called once per frame
	void Update ()
    {
        
        if (flag == 1)
        {
            StartCoroutine(timecounter());
        }
        if(counter == 0)
        {
            Fishes.gameObject.SetActive(true);
        }
        if(counter == 1)
        {
            Fishes.gameObject.SetActive(false);
        }
        if(counter >= 5)
        {
            specialMap.gameObject.SetActive(true);
        }

        switch (flagStage)
        {
            case 1:
                StartCoroutine(stageOne(time1));
                break;
            case 2:
                StartCoroutine (stageOne(time2));

                break;
        }

    }
    IEnumerator stageOne(float t)
    {
        flag = 0;
        // function FishMngStage1();
        yield return new WaitForSeconds(2);
        // fishmngStage1.enable =false;
        // destroy(fish);
        yield return new WaitForSeconds(2);
        // kirm tra mat do ca = 0

            //BackgroundManager.changeStage = .... (variable) 1234

        flag = 1;
       // Debug.Log(counter);
    }

    IEnumerator stageTwo(float t)
    {
        flag = 0;
        // function FishMngStage2();
        yield return new WaitForSeconds(2);
        // fishmngStage1.enable =false;
        // destroy(fish);
        yield return new WaitForSeconds(2);
        // kirm tra mat do ca = 0

        //BackgroundManager.changeStage = .... (variable) 1234

        flag = 2;
        // Debug.Log(counter);
    }
    IEnumerator stageFour(float t)
    {
        flag = 0;
        // function FishMngStage4();
        yield return new WaitForSeconds(2);
        // fishmngStage4.enable =false;
        // destroy(fish);
        yield return new WaitForSeconds(2);
        // kirm tra mat do ca = 0

        //BackgroundManager.changeStage = .... (variable) 1234

        flag = 1;
        // Debug.Log(counter);
    }

}
