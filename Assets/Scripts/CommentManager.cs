﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CommentManager : MonoBehaviour
{


    void Update()
    {

        if (gameObject.activeInHierarchy)

            gameObject.SetActive(true);


        StartCoroutine(Deactivate());
    }


    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }



}
