using UnityEngine;
using System.Collections;

public class SnowWallController : MonoBehaviour {

	//色の設定（デフォルトは白色）
	float red = 255f;
	float green = 255f;
	float blue = 255f;

	//オブジェクトの取得
	GameObject camera;
	//GameObject camera2;

	//カメラの角度
	float angle_x = 0f;
	float angle_y = 0f;
	float angle_z = 0f;
	//float angle2_x = 0f;
	//float angle2_y = 0f;
	//float angle2_z = 0f;

	//オブジェクトの取得
	GameObject snowwallimage;
	GameObject SnowWall;



	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		camera = GameObject.Find("SnowWallCamera");
		//camera2 = GameObject.Find("SnowWallCamera2");
		SnowWall = GameObject.Find("SnowWall");

		//オブジェクトの取得
		snowwallimage = GameObject.Find("snowwallimage");

		//雪の初期サイズ
		SnowWall.GetComponent<ParticleSystem> ().startSize = 0.5f;

		//雪の初期スピード
		SnowWall.GetComponent<ParticleSystem> ().startSpeed = 5f;

		//雪の初期の数
		SnowWall.GetComponent<ParticleSystem> ().emissionRate = 100f;


	
	}
	
	// Update is called once per frame
	void Update () {

		/****************************************************************
		角度の設定
		*****************************************************************/

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


		/****************************************************************
		サイズの設定
		*****************************************************************/

		//上限の設定
		if (SnowWall.GetComponent<ParticleSystem> ().startSize <= 1f) {

			if (Input.GetKeyDown (KeyCode.Alpha7)) {
				SnowWall.GetComponent<ParticleSystem> ().startSize += 0.1f;
			}

		}

		//下限の設定
		if (SnowWall.GetComponent<ParticleSystem> ().startSize >= 0.4f) {

			if (Input.GetKeyDown (KeyCode.Alpha8)) {
				SnowWall.GetComponent<ParticleSystem> ().startSize -= 0.1f;
			}

		}


		/****************************************************************
		スピードの設定
		*****************************************************************/

		//上限の設定
		if (SnowWall.GetComponent<ParticleSystem> ().startSpeed <= 19f) {

			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				SnowWall.GetComponent<ParticleSystem> ().startSpeed += 1f;
			}

		}

		//下限の設定
		if(SnowWall.GetComponent<ParticleSystem>().startSpeed >= 6f){

			if(Input.GetKeyDown(KeyCode.Alpha4)){
				SnowWall.GetComponent<ParticleSystem> ().startSpeed -= 1f;
			}

		}


		/****************************************************************
		数の設定
		*****************************************************************/

		//上限の設定
		if (SnowWall.GetComponent<ParticleSystem> ().emissionRate <= 175f) {

			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				SnowWall.GetComponent<ParticleSystem> ().emissionRate += 25f;
			}

		}


		//下限の数
		if (SnowWall.GetComponent<ParticleSystem> ().emissionRate >= 50f) {

			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				SnowWall.GetComponent<ParticleSystem> ().emissionRate -= 25f;
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


		SnowWall.GetComponent<ParticleSystem>().startColor = new Color(red/255,green/255,blue/255);
		snowwallimage.GetComponent<SpriteRenderer>().color = new Color(red/255,green/255,blue/255);

		//スペースキーで全ての設定をリセット
		if (Input.GetKey (KeyCode.Space)) {

			angle_z = 0f;
			//angle2_z = 0f;

			SnowWall.GetComponent<ParticleSystem> ().startSize = 0.5f;
			SnowWall.GetComponent<ParticleSystem> ().startSpeed = 5f;
			SnowWall.GetComponent<ParticleSystem> ().emissionRate = 100f;

			red = 255f;
			green = 255f;
			blue = 255f;
		}
	
	}
}
