using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class onCollision : MonoBehaviour
{
    // private Text text;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("FPSController").SetActive(true); 
        GameObject.Find("Spaceship").transform.GetChild(1).gameObject.SetActive(false); 
        GameObject.Find("Spaceship").GetComponent<SC_SpaceshipController>().enabled = false;
        // GameObject.Find("FPSController(1)").GetComponent<AudioListener> ().enabled  =  false;

        // GameObject.Find("Camera").GetComponent<Camera>().active = false;
        // text = GetComponent<Text>();

		// start text off as completely transparent black
		// text.color = new Color(0, 0, 0, 0);
    }

    void OnTriggerEnter() {
		Debug.Log ("Collision Detected");
		GameObject.Find("FPSController").SetActive(false);
        GameObject.Find("Spaceship").transform.GetChild(1).gameObject.SetActive(true); 
        GameObject.Find("Spaceship").GetComponent<SC_SpaceshipController>().enabled = true;
        // GameObject.Find("ThirdPersonController").SetActive(true); 
        // GameObject.Find("FPSController(1)").GetComponent<AudioListener> ().enabled  =  true;
 
        // GameObject.Find("Camera").GetComponent<Camera>().active = true;
		// text.color = new Color(0, 0, 0, 1);
		// text.text = "Level Completed!";

	}
}
