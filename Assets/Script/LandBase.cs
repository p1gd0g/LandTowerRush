using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandBase : MonoBehaviour
{
    public Button button;

    void Awake()
    {
        button.onClick.AddListener(() =>
        {
            // print the name of the clicked object
            Debug.Log(gameObject.name);
        });
    }
}
