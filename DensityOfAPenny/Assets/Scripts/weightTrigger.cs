using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightTrigger : MonoBehaviour {
    public UnityEngine.UI.Text var;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Penny>())
        {
            var.text = collision.gameObject.GetComponent<Penny>().weight.ToString();
        }
    }
}
