using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class volumeTrigger : MonoBehaviour {
    public Text volume;
    void OnTriggerEnter(Collider other)
    {
        //On Trigger set the penny volume in the side panel to whatever the penny's value is.
            volume.GetComponent<Text>().text = string.Concat(other.GetComponent<Penny>().volume.ToString());
    }
}
