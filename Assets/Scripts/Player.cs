using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {

       if (Input.GetMouseButtonDown(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * 5);

       
    }
}
