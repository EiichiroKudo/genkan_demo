using UnityEngine;
using System.Collections;

public class HailWallController : MonoBehaviour {


	//カラーの設定（デフォルトは白色）
	float red = 255f;
	float green = 255f;
	float blue = 255f;

	//テクスチャの設定
	Texture hail;

	//カメラの角度
	float angle_x = 0f;
	float angle_y = 0f;
	float angle_z = 0f;
	//float angle2_x = 0f;
	//float angle2_y = 0f;
	//float angle2_z = 0f;


	//オブジェクトの取得
	GameObject camera;
	//GameObject camera2;
	GameObject hail_wall;


	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		camera = GameObject.Find("HailWallCamera");
		//camera2 = GameObject.Find("HailWallCamera2");
		hail_wall = GameObject.Find("HailWall");

		//テクスチャの読み込み(Resourcesフォルダの中)
		hail = (Texture)Resources.Load("hail");

		//粒のテクスチャの設定
		hail_wall.GetComponent<Renderer>().material.mainTexture = hail;

		//壁に表示させる粒の数
		hail_wall.GetComponent<ParticleSystem> ().emissionRate = 100f;

		//壁に表示させる粒の大きさ
		hail_wall.GetComponent<ParticleSystem> ().startSize = 0.3f;

		//壁に表示させる粒の速さ
		hail_wall.GetComponent<ParticleSystem> ().startSpeed = 25f;

		
	
	}
	
	// Update is called once per frame
	void Update () {

		/**********************************************************************************
		あられ（ひょう）の角度の設定
		***********************************************************************************/
		
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


		camera.transform.localRotation = Quaternion.Euler(angle_x,angle_y,angle_z);
		//camera2.transform.localRotation = Quaternion.Euler(angle2_x,angle2_y,angle2_z);

		/**********************************************************************************
		あられ（ひょう）の数の設定
		***********************************************************************************/

		//上限の設定
		if (hail_wall.GetComponent<ParticleSystem> ().emissionRate <= 175f) {

			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				hail_wall.GetComponent<ParticleSystem> ().emissionRate += 25f;
			}

		}

		//下限の設定
		if (hail_wall.GetComponent<ParticleSystem> ().emissionRate >= 50f) {

			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				hail_wall.GetComponent<ParticleSystem> ().emissionRate -= 25f;
			}

		}



		/**********************************************************************************
		あられ（ひょう）の大きさの設定
		***********************************************************************************/

		//上限の設定
		if (hail_wall.GetComponent<ParticleSystem> ().startSize <= 0.9f) {

			if (Input.GetKeyDown (KeyCode.Alpha7)) {
				hail_wall.GetComponent<ParticleSystem> ().startSize += 0.1f;
			}

		}

		//下限の設定
		if (hail_wall.GetComponent<ParticleSystem> ().startSize >= 0.4f) {

			if (Input.GetKeyDown (KeyCode.Alpha8)) {
				hail_wall.GetComponent<ParticleSystem> ().startSize -= 0.1f;
			}

		}


		/**********************************************************************************
		あられ（ひょう）の速さの設定
		***********************************************************************************/
		
		//上限の設定
		if (hail_wall.GetComponent<ParticleSystem> ().startSpeed <= 50f) {

			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				hail_wall.GetComponent<ParticleSystem> ().startSpeed += 5f;
			}

		}

		//下限の設定
		if(hail_wall.GetComponent<ParticleSystem>().startSpeed >= 25f){

			if(Input.GetKeyDown(KeyCode.Alpha4)){
				hail_wall.GetComponent<ParticleSystem> ().startSpeed -= 5f;
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
		hail_wall.GetComponent<ParticleSystem>().startColor = new Color(red/255,green/255,blue/255);
	

		//スペースキーですべての設定をリセット
		if (Input.GetKeyDown (KeyCode.Space)) {

			angle_z = 0f;
			//angle2_z = 0f;

			hail_wall.GetComponent<ParticleSystem> ().emissionRate = 100f;
			hail_wall.GetComponent<ParticleSystem> ().startSize = 0.3f;
			hail_wall.GetComponent<ParticleSystem> ().startSpeed = 25f;

			red = 255f;
			green = 255f;
			blue = 255f;

		}

	}
}
