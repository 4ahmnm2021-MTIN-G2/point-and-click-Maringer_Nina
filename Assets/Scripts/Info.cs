using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject InfoText;

    // Start is called before the first frame update
    void Start()
    {
        InfoText.SetActive(true);

        StartCoroutine(Deactivate());
    }

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(45);
        gameObject.SetActive(false);
    }

}
