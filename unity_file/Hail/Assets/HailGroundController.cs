using UnityEngine;
using System.Collections;

public class HailGroundController : MonoBehaviour {


	//カラーの設定（デフォルトは白色）
	float red = 255f;
	float green = 255f;
	float blue = 255f;

	//テクスチャの設定
	Texture hail;

	//オブジェクトの取得
	GameObject hail_ground_emission;
	GameObject hail_ground;


	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		hail_ground = GameObject.Find("HailGroundGrain");

		//テクスチャの読み込み
		hail = (Texture)Resources.Load("hail");

		//粒のテクスチャの設定
		hail_ground.GetComponent<Renderer>().material.mainTexture = hail;


		//HailGround(オブジェクト)の取得
		hail_ground_emission = GameObject.Find("HailGround");
		//床に表示させる粒の数
		hail_ground_emission.GetComponent<ParticleSystem> ().emissionRate = 30f;

		//床に表示させる粒の大きさ
		hail_ground.GetComponent<ParticleSystem>().startSize = 0.2f;

		//床に表示させる粒の色
		hail_ground.GetComponent<ParticleSystem>().startColor = new Color(red/255,green/255,blue/255); //デフォルトの色は白

		//粒のテクスチャの設定
		GetComponent<Renderer>().material.mainTexture = hail;
	
	}
	
	// Update is called once per frame
	void Update () {

		/**********************************************************************************
		あられ（ひょう）の数の設定
		***********************************************************************************/

		//上限を設定
		if (hail_ground_emission.GetComponent<ParticleSystem> ().emissionRate <= 51f) {

			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				hail_ground_emission.GetComponent<ParticleSystem> ().emissionRate += 7f;
			}

		}


		//下限を設定
		if (hail_ground_emission.GetComponent<ParticleSystem> ().emissionRate >= 16f) {

			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				hail_ground_emission.GetComponent<ParticleSystem> ().emissionRate -= 7f;
			}

		}



		/**********************************************************************************
		あられ（ひょう）の大きさの設定
		***********************************************************************************/

		//大きさの上限を設定
		if(hail_ground.GetComponent<ParticleSystem>().startSize <= 0.9f){

			if (Input.GetKeyDown (KeyCode.Alpha7)) {
				hail_ground.GetComponent<ParticleSystem> ().startSize += 0.1f;
			}

		}

		//大きさの下限を設定
		if (hail_ground.GetComponent<ParticleSystem> ().startSize >= 0.2f) {

			if (Input.GetKeyDown (KeyCode.Alpha8)) {
				hail_ground.GetComponent<ParticleSystem> ().startSize -= 0.1f;
			}

		}


		/**********************************************************************************
		あられ（ひょう）の色の設定
		***********************************************************************************/

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


		//設定したrgbの値を実際に適用させる
		hail_ground.GetComponent<ParticleSystem>().startColor = new Color(red/255,green/255,blue/255);


		//スペースキーですべての設定をリセット
		if (Input.GetKeyDown (KeyCode.Space)) {

			hail_ground_emission.GetComponent<ParticleSystem> ().emissionRate = 10f;
			hail_ground.GetComponent<ParticleSystem> ().startSize = 0.2f;

			red = 255f;
			green = 255f;
			blue = 255f;

		}

	
	}
}
