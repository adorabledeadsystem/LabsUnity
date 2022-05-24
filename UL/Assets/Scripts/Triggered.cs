using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggered : MonoBehaviour
{
    public Text myText;
    public bool flag = false;
    public string objname;
    public GameObject PanelName;
    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            myText.text = objname;
            PanelName.SetActive(true);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        flag = true;
        objname = other.name;
    }
    public void OnTriggerExit(Collider other)
    {
        flag = false;
        myText.text = "";
        PanelName.SetActive(false);
    }
}
