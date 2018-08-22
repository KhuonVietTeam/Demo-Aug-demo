using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
<<<<<<< HEAD
    float speed;
    int choice;
    float time;
    public float speedMin;
    public float speedMax;
    public Vector3 pos;
    public float frameCounter;
    // Use this for initialization
    void Start()
    {
=======
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

>>>>>>> origin/master
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(speedMin, speedMax);
<<<<<<< HEAD
        choice = Random.Range(0, 2);
        switch (choice)
        {
            case 0:
                DiThang(speed);
                break;
            case 1:
                DiHinhSin(speed);
                break;

        }
        StartCoroutine(timecounter());
    }
    private void DiThang(float speed)
    {
        transform.Translate(Time.deltaTime * speed, 0, 0);
    }
    private void DiHinhSin(float speed)
    {
        speed = Random.Range(speedMin, speedMax);
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
    private void MoveCircle(float speed)
    {
        transform.Rotate(new Vector3(0, 0, 1));
        transform.Translate(Time.deltaTime * speed, 0, 0);
    }
    IEnumerator timecounter()
    {
        time = Random.Range(5, 10);
        yield return new WaitForSeconds(time);
    }
}
=======

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
>>>>>>> origin/master
