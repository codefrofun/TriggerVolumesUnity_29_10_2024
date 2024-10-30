using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDeactive : MonoBehaviour
{
    public GameObject targetObject;

    void Start()
    {
        targetObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(false);
    }
}