using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableButton : MonoBehaviour
{
    //public Text ObjectText;
    public UnityEvent clicked;
    


    private void OnMouseDown()
    {
        //ObjectText.text = this.gameObject.name;
        

        clicked.Invoke();

        //Instantiate(Button, currentPosition.position, currentPosition.rotation);
    }




}
