using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSinGroup : MonoBehaviour {
    private float frameCounter = 0;
    public float speed = 0;
    public bool isMove;
    // Use this for initialization
    void Start()
    {
        isMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
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
