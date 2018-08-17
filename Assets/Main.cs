using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        SingletonClass.Instance.Demo();
        SingletonClass.Instance.Demo2("yeah");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
