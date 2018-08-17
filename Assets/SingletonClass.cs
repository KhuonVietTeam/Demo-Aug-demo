using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonClass : MonoBehaviour
{
    //public string Name = "NHAN";
    private static volatile SingletonClass instance;
    static object key = new object();
    public static SingletonClass Instance
    {
        get
        {
            if (instance == null)
            {
                lock (key)
                {
                    instance = new SingletonClass();
                }
            }
            return instance;
        }

       
    }

    private SingletonClass()
    {

    }
    public void Demo()
    {
        Debug.Log("Nhan dep trai");
    }
    public void Demo2(string s)
    {
        Debug.Log(s);
    }
}
