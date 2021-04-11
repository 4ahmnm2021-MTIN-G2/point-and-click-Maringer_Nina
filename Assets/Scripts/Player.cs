﻿using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform thisTransform;
    public Vector3 playerPos;
    public Vector3 mousePos;
    public Vector3 worldPos;
    public float speed = 5f;
   

    void Start()
    {
        playerPos = thisTransform.position;
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            playerPos = new Vector3(worldPos.x, worldPos.y, thisTransform.position.z);

        }

        thisTransform.position = Vector3.MoveTowards(thisTransform.position, playerPos, speed);

       
    }
}
