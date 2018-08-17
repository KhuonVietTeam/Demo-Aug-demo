using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// đạn bắn ra 
public class Bullet : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Bullet()
    {
        Value = 5;
    }
    public Bullet(int initialBulletType)
    {
        Value = initialBulletType;
    }
    public int Value { get; private set; }
    public void AddValue(int amount)
    {
        Value += amount;
    }
    public void SubValue(int amount)
    {
        Value -= amount;
    }
}
