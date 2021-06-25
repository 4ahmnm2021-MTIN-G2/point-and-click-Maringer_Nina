using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public GameObject decision;

    void Start()
    {


        StartCoroutine(Timer());
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(300);
        decision.SetActive(true);
    }

}
