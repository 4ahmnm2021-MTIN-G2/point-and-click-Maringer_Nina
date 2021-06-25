using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombinationItems : MonoBehaviour
{

    public bool condition1 { get; set; }
    public bool condition2 { get; set; }

    public bool condition3 { get; set; }
    public bool condition4{ get; set; }

    public GameObject NewItem;
    public GameObject NewTrigger;


    private void Update()
    {
        if (condition1 && condition2 == true)
        {
            NewItem.SetActive(true);
            NewTrigger.SetActive(true);
            Debug.Log("new item");
        }

        if (condition3 && condition4 == true)
        {
            NewItem.SetActive(true);
            NewTrigger.SetActive(true);
            Debug.Log("new item");
        }
    }

}
