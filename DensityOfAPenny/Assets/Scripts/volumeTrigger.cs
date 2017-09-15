using UnityEngine;
using UnityEngine.UI;//Need this here to use Text component
using System.Collections;

public class volumeTrigger : MonoBehaviour {

    public Text var; //Volume text variable, to be updated when penny is appropriately measured
    void OnTriggerEnter(Collider other)
    {
        //On Trigger set the penny volume in the side panel to whatever the penny's value is.
            var.GetComponent<Text>().text = string.Concat(other.GetComponent<Penny>().volume.ToString());
    }
}
