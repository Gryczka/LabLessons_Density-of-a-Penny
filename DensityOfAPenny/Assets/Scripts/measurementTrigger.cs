using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class measurementTrigger : MonoBehaviour {
    public Text width;
    public Text diameter;
    public Text calculatedVolume;
    bool widthIsSet = false;
    bool diameterIsSet = false;
    void OnTriggerEnter(Collider other)
    {
        //On Trigger set the penny measurement in the side panel to whatever the penny's value is.
        if (other.GetComponent<Penny>().rotated)
        {
            width.GetComponent<Text>().text = string.Concat(other.GetComponent<Penny>().width.ToString());
            widthIsSet = true;
        }
        else {
            diameter.GetComponent<Text>().text = string.Concat(other.GetComponent<Penny>().diameter.ToString());
            diameterIsSet = true;
        }
    }

    void Update()
    {
        //If both width and diameter are set, calculate the volume and set the volume in the side panel.
        if(widthIsSet && diameterIsSet)
        {
            calculatedVolume.GetComponent<Text>().text = (Mathf.PI * Mathf.Pow((float.Parse(diameter.text) / 2), 2) * float.Parse(width.text)).ToString("0.00");
        }
    }
}
