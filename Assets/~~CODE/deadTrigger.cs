using UnityEngine;
using System.Collections;

public class deadTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Debug bij enter van een collider 
    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
