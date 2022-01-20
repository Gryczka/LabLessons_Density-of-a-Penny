using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightTrigger : MonoBehaviour {
    public UnityEngine.UI.Text weight;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Penny>())
        {
            weight.text = collision.gameObject.GetComponent<Penny>().weight.ToString();
        }
    }
}
