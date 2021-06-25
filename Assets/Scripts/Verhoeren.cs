using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Verhoeren : MonoBehaviour
{
    public bool conditionV1 { get; set; }
    public bool conditionV2 { get; set; }
    


    public GameObject comment1;

    void Update()
    {

        if (conditionV1 && conditionV2 == true)
        {
            Debug.Log("???");
            comment1.SetActive(true);
            StartCoroutine(Deactivate());
        }
    }

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(3);
        comment1.SetActive(false);
        Destroy(gameObject);

    }
}
