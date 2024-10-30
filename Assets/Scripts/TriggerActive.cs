using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActive : MonoBehaviour
{
    public GameObject targetObject; 
    public Light spotlight;      
    private Color originalColor;  

    void Start()
    {
        if (spotlight != null)
        {
            originalColor = spotlight.color;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(false);
        ChangeSpotlightColor();
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(true);
        ResetSpotlightColor();
    }

    private void ChangeSpotlightColor()
    {
        if (spotlight != null)
        {
            spotlight.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    private void ResetSpotlightColor()
    {
        if (spotlight != null)
        {
            spotlight.color = originalColor;
        }
    }
}
