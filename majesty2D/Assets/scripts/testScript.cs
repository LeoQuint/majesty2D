using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NSP_Game;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ESubGroundLayer l1 = ESubGroundLayer.DEBUG1 | ESubGroundLayer.MOD2 | ESubGroundLayer.MOD5;
        Debug.Log(l1.ToString());
        ESubGroundLayer l2 = ESubGroundLayer.DEBUG1;
        Debug.Log(l2.ToString().GetType());

        Debug.Log(l1.GetHashCode());
        Debug.Log(l2.HasFlag(ESubGroundLayer.DEBUG1));
        Debug.Log(l2.HasFlag(ESubGroundLayer.MOD6));
        Debug.Log(l1.HasFlag(ESubGroundLayer.MOD2 | ESubGroundLayer.MOD5));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
