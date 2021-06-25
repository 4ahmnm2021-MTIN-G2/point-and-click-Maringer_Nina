using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonManager : MonoBehaviour
{
    public GameObject Button;
    public UnityEvent clicked;

    private void OnMouseDown()
    {
       // Button.GetComponent<SpriteRenderer>().enabled = true;
        // GetComponent<SpriteRenderer>().enabled = false;

        clicked.Invoke();

        StartCoroutine(Deactivate());
    }

   

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(3);
        Button.GetComponent<SpriteRenderer>().enabled = false;
    }
}
