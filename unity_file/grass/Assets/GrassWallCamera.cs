using UnityEngine;
using System.Collections;

public class GrassWallCamera : MonoBehaviour {

	//カメラの座標調整
	float camera_position_x = 298f;
	float camera_position_y = 2f;
	float camera_position_z = 3.5f;

	//オブジェクトの取得
	GameObject camera;

	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		camera = GameObject.Find("WallCamera");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.LeftArrow)){
			camera_position_x += 0.1f;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			camera_position_x -= 0.1f;
		}

		if(Input.GetKey(KeyCode.UpArrow)){
			camera_position_y += 0.1f;
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			camera_position_y -= 0.1f;
		}

		if(Input.GetKey(KeyCode.X)){
			camera_position_z += 0.1f;
		}
		if(Input.GetKey(KeyCode.Z)){
			camera_position_z -= 0.1f;
		}


		camera.transform.position = new Vector3(camera_position_x,camera_position_y,camera_position_z);

	}
}
