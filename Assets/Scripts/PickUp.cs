using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] Transform theDest;
    private float distance;
    private void Update()
    {
        distance = Vector3.Distance(this.transform.position, theDest.position);
    }

    private void OnMouseDown()
    {
        if (distance < 0.7f)
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = theDest; // or GameObject.Find("Destination").transform;
        }    
    }
    private void OnMouseUp()
    {
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
        this.transform.parent = null;
    }
}
