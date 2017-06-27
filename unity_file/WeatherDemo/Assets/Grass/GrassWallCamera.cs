using UnityEngine;
using System.Collections;

public class GrassWallCamera : MonoBehaviour {

	//カメラの座標調整
	float camera_position_x = 123.32f;
	float camera_position_y = 362f;
	float camera_position_z = 6.69f;
	//float camera2_position_x = 123.32f;
	//float camera2_position_y = 362f;
	//float camera2_position_z = 6.69f;


	//オブジェクトの取得
	GameObject camera;
	//GameObject camera2;

	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		camera = GameObject.Find("GrassWallCamera");
		//camera2 = GameObject.Find("GrassWallCamera2");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.LeftArrow)){
			camera_position_x += 0.1f;
			//camera2_position_x += 0.1f;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			camera_position_x -= 0.1f;
			//camera2_position_x -= 0.1f;
		}

		if(Input.GetKey(KeyCode.UpArrow)){
			camera_position_y += 0.1f;
			//camera2_position_y += 0.1f;
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			camera_position_y -= 0.1f;
			//camera2_position_y -= 0.1f;
		}

		if(Input.GetKey(KeyCode.X)){
			camera_position_z += 0.1f;
			//camera2_position_z += 0.1f;
		}
		if(Input.GetKey(KeyCode.Z)){
			camera_position_z -= 0.1f;
			//camera2_position_z -= 0.1f;
		}


		camera.transform.position = new Vector3(camera_position_x,camera_position_y,camera_position_z);
		//camera2.transform.position = new Vector3(camera2_position_x,camera2_position_y,camera2_position_z);

	}
}
