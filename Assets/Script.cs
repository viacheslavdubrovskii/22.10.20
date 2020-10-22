using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public GameObject obj;

    private Light MyLight;

    private void Start()
    {
        MyLight = GetComponent<Light>();

    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            MyLight.enabled = !MyLight.enabled;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Destroy(obj);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
