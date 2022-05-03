using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoxController : MonoBehaviour
{

    public string infoText;

    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("canvas");

        canvas.GetComponent<Canvas>(). enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            GameObject.FindGameObjectWithTag("info").GetComponent<Text>().text = infoText;
            canvas.GetComponent<Canvas>(). enabled = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){
            GameObject.FindGameObjectWithTag("info").GetComponent<Text>().text = "";
            canvas.GetComponent<Canvas>(). enabled = false;
        }
    }
}
