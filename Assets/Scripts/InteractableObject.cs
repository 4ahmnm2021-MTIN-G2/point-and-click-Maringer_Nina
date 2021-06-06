using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class InteractableObject : MonoBehaviour
{
    public Text ObjectText;
    public UnityEvent clicked;

    private void OnMouseDown()
    {
        ObjectText.text = this.gameObject.name;
        //this.gameObject.SetActive(true);
        ObjectText.GetComponent<Text>().enabled = true;
       // GetComponent<SpriteRenderer>().enabled = false;

        clicked.Invoke();

        StartCoroutine(Deactivate());
    }

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(3);
        ObjectText.GetComponent<Text>().enabled = false;
    }


}
