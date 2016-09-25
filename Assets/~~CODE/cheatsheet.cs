using UnityEngine;
using System.Collections;

public class cheatsheet  : MonoBehaviour {
	private GameObject gameMasterObject;            // dit is het object dat de game master script bevat
	private gameMaster gameMaster;                  // dit is het scrpt 

    // gebruik dit voor initialization
	void Start () {
        // gameMaster script wordt gepakt 
		gameMasterObject = GameObject.Find("~~gameMaster");
		gameMaster = gameMasterObject.GetComponent<gameMaster>();
	}

    // De Update wordt iedere Frame aangeroepen
	void Update () {
	
	}

	public void LoadlevelOnNumber(int levelnumber) {
		Application.LoadLevel(levelnumber);
	}

	public void LoadlevelOnName(string levelname) {
		Application.LoadLevel(levelname.ToString());
	}

	public void Destroy(GameObject destoyable) {
		Destroy(destoyable, 0.1f);
		gameMaster.cheatSheetIsOpend = false;
	}
}