using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    
	public void RotatePenny () {
        transform.Rotate(new Vector3(90f,0f,0f));
	}
	
}
