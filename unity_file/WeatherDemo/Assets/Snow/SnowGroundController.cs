using UnityEngine;
using System.Collections;

public class SnowGroundController : MonoBehaviour {

	//色の設定（デフォルトは白色）
	float red = 255f;
	float green = 255f;
	float blue = 255f;

	//オブジェクトの取得
	GameObject snowgroundimage;

	//オブジェクトの取得
	GameObject snowgroundemission;

	//オブジェクトの取得
	GameObject snowground;


	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		snowgroundimage = GameObject.Find("snowgroundimage");

		//オブジェクトの取得
		snowground = GameObject.Find("SnowPile");

		//オブジェクトの取得
		snowgroundemission = GameObject.Find("SnowGround");
		//初期の数
		snowgroundemission.GetComponent<ParticleSystem> ().emissionRate = 10f;

		//初期のサイズの設定
		snowground.GetComponent<ParticleSystem> ().startSize = 0.5f;

	
	}
	
	// Update is called once per frame
	void Update () {

		/****************************************************************
		数の設定
		*****************************************************************/

		//上限の設定
		if (snowgroundemission.GetComponent<ParticleSystem> ().emissionRate <= 17.5f) {

			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				snowgroundemission.GetComponent<ParticleSystem> ().emissionRate += 2.5f;
			}

		}

		//下限の設定
		if (snowgroundemission.GetComponent<ParticleSystem> ().emissionRate >= 5f) {

			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				snowgroundemission.GetComponent<ParticleSystem> ().emissionRate -= 2.5f;
			}

		}


		/****************************************************************
		サイズの設定
		*****************************************************************/

		//上限の設定
		if (snowground.GetComponent<ParticleSystem> ().startSize <= 1f) {

			if (Input.GetKeyDown (KeyCode.Alpha7)) {
				snowground.GetComponent<ParticleSystem> ().startSize += 0.1f;
			}

		}

		//下限の設定
		if (snowground.GetComponent<ParticleSystem> ().startSize >= 0.4f) {

			if (Input.GetKeyDown (KeyCode.Alpha8)) {
				snowground.GetComponent<ParticleSystem> ().startSize -= 0.1f;
			}

		}


		/****************************************************************
		色の設定
		*****************************************************************/

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


		snowground.GetComponent<ParticleSystem>().startColor = new Color(red/255,green/255,blue/255);
		snowgroundimage.GetComponent<SpriteRenderer>().color = new Color(red/255,green/255,blue/255);


		if (Input.GetKey (KeyCode.Space)) {

			snowground.GetComponent<ParticleSystem> ().startSize = 0.5f;
			snowgroundemission.GetComponent<ParticleSystem> ().emissionRate = 10f;

			red = 255f;
			green = 255f;
			blue = 255f;

		}
	
	}
}
