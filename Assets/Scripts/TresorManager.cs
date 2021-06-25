using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresorManager : MonoBehaviour
{
    public bool number1 { get; set; }
    public bool number2 { get; set; }
    public bool number3 { get; set; }
    public bool number4 { get; set; }
    public bool number5 { get; set; }

    public GameObject TresorUI;
    public GameObject Key;

    // Update is called once per frame
    void Update()
    {
        if (number5 == true)
        {
            Debug.Log("YOU GET THE KEY");
            TresorUI.SetActive(false);
            Key.SetActive(true);
        }
    }
}
