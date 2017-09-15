using UnityEngine;
using UnityEngine.UI;//Need this here to use Text component
using System.Collections;

public class measurementTrigger : MonoBehaviour {
    public Text var;//width
    public Text var2;//diameter
    public Text var3;//calculated volume
    bool varIsSet = false;//bools track when both vars are set, to know when to calc and set the volume
    bool var2IsSet = false;
    void OnTriggerEnter(Collider other)
    {
        //On Trigger set the penny measurement in the side panel to whatever the penny's value is.
        if (other.GetComponent<Penny>().rotated)
        {
            var.GetComponent<Text>().text = string.Concat(other.GetComponent<Penny>().diameter.ToString());
            varIsSet = true;
        }
        else {
            var2.GetComponent<Text>().text = string.Concat(other.GetComponent<Penny>().width.ToString());
            var2IsSet = true;
        }
    }
    void Update()
    {
        if(varIsSet && var2IsSet)
        {
            //Placeholder, need to get values from penny
            var3.GetComponent<Text>().text = (Mathf.PI * Mathf.Pow((float.Parse(var.text) / 2), 2) * float.Parse(var2.text)).ToString("0.00");
        }
    }
}
