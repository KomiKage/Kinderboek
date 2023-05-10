using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHover : MonoBehaviour
{
    private GameObject hoverObject;

    private void Start()
    {
        hoverObject = this.gameObject;
    }

    void OnMouseOver()
    {
        Debug.Log("Mouse is over GameObject.");
        hoverObject.transform.localScale = new Vector3(2,2,2);
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is no longer on GameObject.");
        hoverObject.transform.localScale -= Vector3.one;
    }
}
