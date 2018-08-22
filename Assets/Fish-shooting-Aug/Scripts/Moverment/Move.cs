using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedMin;
    public float speedMax;
    private float speed;
    public Vector3 pos;
    public float frameCounter;
    public bool isMove;
    // Use this for initialization
    void Start()
    {
        isMove = true;
        speed = 2f;

    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            if (this.gameObject.name == "fish1" | this.gameObject.name == "fish2") // loai ca 1 2 thi di chuyen hinh sin
            {
                MoveSin();
            }
            else
            {
                MoveNomal();
            }
        }
    }
    void MoveNomal()
    {
        transform.Translate(Time.deltaTime * speed, 0, 0); // di chuyen thẩng
    }
    void MoveSin()
    {
        speed = Random.Range(speedMin, speedMax);
        float vl = Random.Range(0, 10);
        if (vl < 8)
        {
            transform.Translate(Time.deltaTime * speed, 0, 0);
        }
        else
        {
            frameCounter++;
            if (frameCounter < 60) // lắc qua trái 60 frame thì lắc lại phên phải
            {
                transform.Rotate(new Vector3(0, 0, 1));
            }
            if (frameCounter > 60) // lắc qua phải
            {
                transform.Rotate(new Vector3(0, 0, -1));
            }
            if (frameCounter == 120) //reset để tiếp túc lắc trái
            {
                frameCounter = 0;
            }
            transform.Translate(Time.deltaTime * speed, 0, 0); // di chiuyeern theo hướng lắc
        }
    }
}