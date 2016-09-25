using UnityEngine;
using System.Collections;

public class menuMaster : MonoBehaviour {
    private bool b_pressToStart;
	private Camera camera;

	public GameObject pressToStartObject;
	public GameObject mainWindow;
    public GameObject settingsWindow;
    public GameObject newGameWindow;
    public GameObject newGameMaker;

    // gebruik dit om dingen te doen voordat de scene is geladen
	void Awake () {
        mainWindow.SetActive(false);
        settingsWindow.SetActive(false);
        newGameWindow.SetActive(false);
        newGameMaker.SetActive(false);
	}

    // gebruik dit voor initialization
	void Start () {
        // de eerste active camera wordt gepakt
        //camera = Camera.allCameras;
	}

    // De Update wordt iedere Frame aangeroepen
    void Update() {
        if (!b_pressToStart && Input.anyKeyDown) {
			Destroy(pressToStartObject, .1f);
            b_pressToStart = true;
		}

        else if (b_pressToStart) {
            mainWindow.SetActive(true);
            b_pressToStart = false;
            // Camera.main.fieldOfView = 80;
		}
	}
}
