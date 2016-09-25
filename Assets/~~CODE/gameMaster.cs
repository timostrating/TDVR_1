using UnityEngine;
using System.Collections;

public class gameMaster : MonoBehaviour {
	public bool cheatSheetIsOpend = false;              // of de cheatSheet is geopend
	private GameObject Clone;                           // het kopie van de prefab dat in de wereld wordt gezet
    private Camera camera;

	public GameObject cheatSheetPrefab;                 // de prefab waar een clone van wordt gemaakt

	// gebruik dit om dingen te doen voordat de scene is geladen
	void Awake() {
        // de game master wordt aangemaakt in de MENU scene en wordt doorgegeven van scene naar scene
        DontDestroyOnLoad(transform.gameObject);
	}

	// gebruik dit voor initialization
	void Start () {
        camera = Camera.current;
	}
	
	// De Update wordt iedere Frame aangeroepen
	void Update () {
		// cheat screen wordt ge instantiate ALS er op ` wordt gedrukt Als hij al bestaat dan wordt hi weg gehaald
		if (Input.GetKeyDown(KeyCode.BackQuote) ) {
			if (!cheatSheetIsOpend) {
                // Clone = (GameObject)GameObject.Instantiate(cheatSheetPrefab, new Vector3(5, 5, 5), Quaternion.identity);
				Clone = (GameObject)GameObject.Instantiate(cheatSheetPrefab);
				cheatSheetIsOpend = true;
			}
			else if (cheatSheetIsOpend) { 
				Destroy(Clone, 0);
				cheatSheetIsOpend = false;
			}
		}
	}



    // public test die enkel als beschikbaarheids test geld
	public void DebugTest (string text) {
		Debug.Log(text);
	}

    // public quit die unity altijd stop zet
	public void Quit () {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}