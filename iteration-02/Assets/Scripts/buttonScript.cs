using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonScript : MonoBehaviour {

	public Text text;

	public void buttonPushed() {
		Debug.Log("Pushed !");
		text.text = "New text is pushed";
	}

	public void buttonTriggered() {
		Debug.Log("Triggered !");
		text.text = "New text is triggered";
	}
}
