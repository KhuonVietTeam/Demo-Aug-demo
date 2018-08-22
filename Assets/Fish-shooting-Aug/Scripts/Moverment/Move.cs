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
        speed = Random.Range(speedMin, speedMax);

        if (isMove)
        {
            if (this.gameObject.name == "fish1" | this.gameObject.name == "fish2")
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

        transform.Translate(Time.deltaTime * speed, 0, 0);
    }
    void MoveSin()
    {
        float vl = Random.Range(0, 10);
        if (vl < 8)
        {
            transform.Translate(Time.deltaTime * speed, 0, 0);
        }
        else
        {
            frameCounter++;
            if (frameCounter < 60)
            {
                transform.Rotate(new Vector3(0, 0, 1));
            }
            if (frameCounter > 60)
            {
                transform.Rotate(new Vector3(0, 0, -1));
            }
            if (frameCounter == 120)
            {
                frameCounter = 0;
            }
            transform.Translate(Time.deltaTime * speed, 0, 0);
        }
    }
}