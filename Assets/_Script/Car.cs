using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class Car : MonoBehaviour
{
    protected TextMeshProUGUI info;
    [SerializeField] GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
        {
            // Activate the canvas and set the text
            canvas.SetActive(true);
            DisplayText();
        }

    public virtual void DisplayText()
    {
        info.text = "I am a generic shape";
    }
}

