using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArray : MonoBehaviour {

    private int sizePos = 5;
    private int sizeRot = 2;
    private Vector3[,] posRot;

	// Use this for initialization
	void Start () {
        posRot = new Vector3[sizePos, sizeRot];
        for(int i=0; i < sizePos; i++)
        {
            for (int j = 0; j < sizeRot; j++)
            {
                posRot[i, j] = new Vector3(i,0,j);
                Debug.Log(posRot[i,j]);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
