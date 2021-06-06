using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableButton : MonoBehaviour
{
    public Text ObjectText;
    public UnityEvent clicked;
    public Transform currentPosition;
    public Transform btnPosition;


    private void OnMouseDown()
    {
        ObjectText.text = this.gameObject.name;
        //this.gameObject.SetActive(false);

        clicked.Invoke();

        //btnPosition.position = currentPosition.position;
    }




}
