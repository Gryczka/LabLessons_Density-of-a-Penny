using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volumeCalculator : MonoBehaviour {
    public Text massVar;
    public Text volumeVar1;
    public Text volumeVar2;
    public Text densityVar1;
    public Text densityVar2;

	void Update () {
		if (massVar.text != "")
        {
            float mass = float.Parse(massVar.text);
            float vol1;
            float vol2;
            float dens1;
            float dens2;
            
            if (volumeVar1.text != "")
            {
                vol1 = float.Parse(volumeVar1.text);
                dens1 = mass / vol1;
                densityVar1.text = dens1.ToString("0.00");
            }

            if (volumeVar2.text != "")
            {
                vol2 = float.Parse(volumeVar2.text);
                dens2 = mass / vol2;
                densityVar2.text = dens2.ToString("0.00");
            }
        }
	}
}
