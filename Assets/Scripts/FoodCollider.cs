using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCollider : MonoBehaviour
{

    public string infoText;
    public string foodTag;

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

    void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){



    if(Input.GetKeyDown(KeyCode.Space)){

        Destroy(GameObject.FindGameObjectWithTag(foodTag));
        GameObject.FindGameObjectWithTag("info").GetComponent<Text>().text = "";
        canvas.GetComponent<Canvas>(). enabled = false;

    }
        }
    }
}
