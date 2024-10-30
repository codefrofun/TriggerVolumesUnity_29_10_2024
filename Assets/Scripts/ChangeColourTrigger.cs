using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeColourTrigger : MonoBehaviour
{
    public GameObject targetObject; 
    private Renderer targetRenderer;
    public TMP_Text instructionText;

    private void Start()
    {
        targetObject.SetActive(false);
        targetRenderer = targetObject.GetComponent<Renderer>();
        instructionText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);
        instructionText.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(false);
        instructionText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (targetObject.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
        }
    }

    private void ChangeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        targetRenderer.material.color = newColor;
    }
}