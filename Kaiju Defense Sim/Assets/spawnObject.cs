using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// modified from source code provided by TheFlyingKeyboard
// licensed under MIT license, © 2017 TheFlyingKeyboard
// theflyingkeyboard.net
public class spawnObject : MonoBehaviour {
    public GameObject artillery;
    public GameObject infantry;
    public GameObject tank;
    public int type = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnPosition.z = 0.0f;
            switch (type) {
                case 0:
                    //do nothing
                    break;
                case 1:
                    GameObject inf = Instantiate(infantry, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    break;
                case 2:
                    GameObject tan = Instantiate(tank, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    break;
                case 3:
                    GameObject art = Instantiate(artillery, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    break;
            }
            
        }
    }
}
