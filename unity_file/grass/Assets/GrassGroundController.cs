using UnityEngine;
using System.Collections;

public class GrassGroundController : MonoBehaviour {

	//カメラの座標調整
	float camera_position_x = 240f;
	float camera_position_y = 9.7f;
	float camera_position_z = 174f;

	//光の強さ
	float power = 1f;

	//光の角度
	float light_angle_x = 90f;
	float light_angle_y = 0f;
	float light_angle_z = 0f;

	//オブジェクトの取得
	GameObject camera;

	//オブジェクトの取得
	GameObject light;


	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		camera = GameObject.Find("GroundCamera");

		//オブジェクトの取得
		light = GameObject.Find("Directional Light");
	
	}
	
	// Update is called once per frame
	void Update () {

		/************************************************************
		カメラの移動（上下左右奥手前）
		*************************************************************/

		if(Input.GetKey(KeyCode.D)){
			camera_position_x += 0.25f;
		}
		if(Input.GetKey(KeyCode.A)){
			camera_position_x -= 0.25f;
		}

		if(Input.GetKey(KeyCode.E)){
			camera_position_y += 0.1f;
		}
		if(Input.GetKey(KeyCode.Q)){
			camera_position_y -= 0.1f;
		}

		if(Input.GetKey(KeyCode.W)){
			camera_position_z += 0.25f;
		}
		if(Input.GetKey(KeyCode.S)){
			camera_position_z -= 0.25f;
		}


		camera.transform.position = new Vector3(camera_position_x,camera_position_y,camera_position_z);


		/************************************************************
		ライトの光量の設定
		*************************************************************/

		//下限の設定
		if(power > 0f){
			if(Input.GetKeyDown(KeyCode.O)){
				power -= 0.1f;
			}
		}

		//上限の設定
		if(power < 1f){
			if(Input.GetKeyDown(KeyCode.I)){
				power += 0.1f;
			}
		}

		light.transform.localRotation = Quaternion.Euler(light_angle_x,light_angle_y,light_angle_z);
		light.GetComponent<Light>().intensity = power;

	
	}
}
