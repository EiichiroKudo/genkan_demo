using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorNum : MonoBehaviour {

	public float red = 255f;
	public float green = 255f;
	public float blue = 255f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//赤色の調整
		if (red <= 254f) {

			if (Input.GetKey (KeyCode.E)) {
				red += 1f;
			}

		}

		if (red >= 1f) {

			if (Input.GetKey (KeyCode.R)) {
				red -= 1f;
			}

		}


		//緑の調整
		if (green <= 254f) {

			if (Input.GetKey (KeyCode.F)) {
				green += 1f;
			}

		}

		if (green >= 1f) {
			
			if (Input.GetKey (KeyCode.G)) {
				green -= 1f;
			}

		}


		//青の調整
		if (blue <= 254f) {

			if (Input.GetKey (KeyCode.V)) {
				blue += 1f;
			}

		}

		if (blue >= 1f) {

			if (Input.GetKey (KeyCode.B)) {
				blue -= 1f;
			}
		}

		if (Input.GetKey (KeyCode.Space)) {
			red = 255f;
			green = 255f;
			blue = 255f;
		}


		this.GetComponent<Text>().text = "red:"+red.ToString()+"\n"+"green"+green.ToString()+"\n"+"blue:"+blue.ToString();
		//this.GetComponent<Text>().text = "green:"+green.ToString();

	}
}
