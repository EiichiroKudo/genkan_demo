using UnityEngine;
using System.Collections;

public class FlagGroundController : MonoBehaviour {

	//オブジェクトの取得
	GameObject light;

	//オブジェクトの取得
	//ライトを回転させる軸の中心
	GameObject center;

	//中心軸の角度
	float center_angle_y = 0f;

	//ライトの角度
	float light_angle_x = 45f;
	float light_angle_y = 90f;

	
	//光の強さ
	float light_power = 1.0f;

	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		light = GameObject.Find("Directional Light");

		//オブジェクトの取得
		center = GameObject.Find("center");

	
	}
	
	// Update is called once per frame
	void Update () {


		/********************************************************************
		光の向きの設定
		*********************************************************************/

		//角度の制限
		if (light_angle_x <= 89f) {

			if (Input.GetKey (KeyCode.T)) {
				light_angle_x += 1f;  
			}
		}

		if(light_angle_x >= 15f){
			if (Input.GetKey (KeyCode.Y)) {
				light_angle_x -= 1f;  
			}
		}


		//自動で影をうごかす
		//center_angle_y-= 0.1f;


		if(Input.GetKey(KeyCode.RightArrow)){
			center_angle_y += 1f;
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			center_angle_y -= 1f;
		}

		light.transform.localRotation = Quaternion.Euler(light_angle_x,light_angle_y, 0f);
		center.transform.rotation = Quaternion.Euler(0,center_angle_y,0);

		/********************************************************************
		光の強さの設定
		*********************************************************************/

		//力の制限
		if(light_power > 0f){
			if(Input.GetKeyDown(KeyCode.O)){
				light_power -= 0.1f;
			}
		}
		if(light_power < 1f){
			if(Input.GetKeyDown(KeyCode.I)){
				light_power += 0.1f;
			}
		}

		if(Input.GetKeyDown(KeyCode.Space)){
			light_power = 1.0f;
			light_angle_x = 45f;
		}


		//徐々に暗くする
		//light_power += 0.0025f;
		


		light.GetComponent<Light>().intensity = light_power;


		//スペースキーで全ての設定をリセット
		if(Input.GetKeyDown(KeyCode.Space)){

			center_angle_y = 0f;
			light_power = 1.0f;
			light_angle_x = 45f;

		}


	}
}
