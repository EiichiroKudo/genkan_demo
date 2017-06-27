using UnityEngine;
using System.Collections;

public class RainWallController : MonoBehaviour {

	//カラーの設定（デフォルトは水色）
	float red = 51f;
	float green = 102f;
	float blue = 127f;

	//オブジェクトの取得
	GameObject camera;
	//GameObject camera2;

	GameObject rain;

	//カメラの角度
	float angle_x = -90f;
	float angle_y = 0f;
	float angle_z = 0f;
	//float angle2_x = -90f;
	//float angle2_y = 0f;
	//float angle2_z = 0f;
	


	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		camera = GameObject.Find("RainWallCamera");
		//camera2 = GameObject.Find("RainWallCamera2");
		rain = GameObject.Find("RainWall");

		//雨粒の初期サイズ
		rain.GetComponent<ParticleSystem>().startSize = 0.1f;

		//雨粒の初期スピード
		rain.GetComponent<ParticleSystem>().startSpeed = 25f;

		//雨粒の初期の量
		rain.GetComponent<ParticleSystem> ().emissionRate = 200f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		/******************************************************************
		 角度の設定
		 ******************************************************************/

		//角度の制限
		if (angle_z <= 90f && angle_z >= -80f) {

			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				angle_z -= 5f;
				//angle2_z -= 5f;
			}

		}

		//角度の制限
		if (angle_z <= 80f && angle_z >= -90f) {

			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				angle_z += 5f;
				//angle2_z += 5f;
			}

		}

		

		camera.transform.localRotation = Quaternion.Euler(angle_x, angle_y, angle_z);
		//camera2.transform.localRotation = Quaternion.Euler(angle2_x, angle2_y, angle2_z);


		/******************************************************************
		 サイズの設定
		 ******************************************************************/

		 //上限の設定
		if (rain.GetComponent<ParticleSystem> ().startSize <= 0.5f) {
			if (Input.GetKeyDown (KeyCode.Alpha7)) {
				rain.GetComponent<ParticleSystem> ().startSize += 0.1f;
			}
		}

		//下限の設定
		if(rain.GetComponent<ParticleSystem> ().startSize > 0.2f){
			if (Input.GetKeyDown (KeyCode.Alpha8)) {
				rain.GetComponent<ParticleSystem> ().startSize -= 0.1f;
			}
		}



		/******************************************************************
		 色の設定
		 ******************************************************************/

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


		rain.GetComponent<ParticleSystem>().startColor = new Color(red/255,green/255,blue/255);



		/******************************************************************
		 スピードの設定
		 ******************************************************************/

		 //上限の設定
		if (rain.GetComponent<ParticleSystem> ().startSpeed <= 43f) {

			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				rain.GetComponent<ParticleSystem> ().startSpeed += 2f;
			}

		}

		//下限の設定
		if (rain.GetComponent<ParticleSystem> ().startSpeed >= 17f) {

			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				rain.GetComponent<ParticleSystem> ().startSpeed -= 2f;
			}

		}



		/******************************************************************
		 量の設定
		 ******************************************************************/

		 //上限の設定
		if (rain.GetComponent<ParticleSystem> ().emissionRate <= 450f) {

			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				rain.GetComponent<ParticleSystem> ().emissionRate += 50f;
			}

		}


		//下限の設定
		if (rain.GetComponent<ParticleSystem> ().emissionRate >= 100f) {


			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				rain.GetComponent<ParticleSystem> ().emissionRate -= 50f;
			}


		}

		//雨の降り始め、やむ前の表現
		if (Input.GetKeyDown (KeyCode.Alpha9)) {
				rain.GetComponent<ParticleSystem> ().emissionRate = 15f;
			}
		if(rain.GetComponent<ParticleSystem> ().emissionRate <= 16f){
			if (Input.GetKeyDown (KeyCode.Alpha0)) {
					rain.GetComponent<ParticleSystem> ().emissionRate = 200f;
				}	
			}	

			

		//スペースキーで全ての設定をリセット
		if (Input.GetKeyDown (KeyCode.Space)) {

			angle_z = 0f;
			//angle2_z = 0f; 

			rain.GetComponent<ParticleSystem> ().startSize = 0.1f;
			rain.GetComponent<ParticleSystem> ().startSpeed = 25f;
			rain.GetComponent<ParticleSystem> ().emissionRate = 200f;

			red = 51f;
			green = 102f;
			blue = 127f;

		}


	}
}
