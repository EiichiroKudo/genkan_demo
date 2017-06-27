using UnityEngine;
using System.Collections;

public class FlagWallController : MonoBehaviour {

	//色の設定（デフォルトは赤色）
	float red = 255f;
	float green = 0f;
	float blue = 0f;

	//布の座標
	float cloth_x = 1.76f;
	float cloth_y = 55.24f;
	float cloth_z = -39.94f;

	//ポールの座標と高さの設定
	float pole_x = -0.2f;
	float pole_y = 53.24f;
	float pole_z = -40f;
	float pole_scale_x = 0.2f;
	float pole_scale_y = 7f;
	float pole_scale_z = 0.2f;

	//風のなびきの設定
	float ran_x = 0f;
	float ran_y = 0f;
	float ran_z = 0f;
	float ex_x = 0f;
	float ex_y = 0f;
	float ex_z = 0f;
	

	//オブジェクトの取得
	GameObject cloth;

	//オブジェクトの取得
	GameObject pole;

	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		cloth = GameObject.Find("cloth");
		pole = GameObject.Find("pole");
	
	}
	
	// Update is called once per frame
	void Update () {

	/**********************************************************************
	色の設定
	***********************************************************************/


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

		cloth.GetComponent<Renderer> ().material.color = new Color (red/255,green/255,blue/255);


	/**********************************************************************
	旗の高さの設定
	***********************************************************************/	

		//布の高さ
		//上限の設定
		if(cloth_y < 58.2f){
			if(Input.GetKey(KeyCode.Z)){
				cloth_y += 0.1f;
			}
		}
		//下限の設定
		if (cloth_y > 54.2f) {
			if (Input.GetKey (KeyCode.X)) {
				cloth_y -= 0.1f;
			}
		}


		//ポールの高さ
		//上限の設定
		if(pole_scale_y < 10f){
			if(Input.GetKey(KeyCode.Z)){
			pole_scale_y += 0.1f;	
			pole_y += 0.05f;		
			}
		}

		//下限の設定
		if(pole_scale_y > 6f){
			if(Input.GetKey(KeyCode.X)){		
			pole_scale_y -= 0.1f;
			pole_y -= 0.05f;
			}
		}


		cloth.transform.position = new Vector3(cloth_x,cloth_y,cloth_z);
		pole.transform.position = new Vector3(pole_x,pole_y,pole_z);
		pole.transform.localScale = new Vector3 (pole_scale_x,pole_scale_y,pole_scale_z);	


	/**********************************************************************
	風のなびきの設定
	***********************************************************************/

	if(Input.GetKeyDown(KeyCode.D)){
			ran_x = 0f;
			ex_y = 0f;
			ex_x = 0f;
		}
		if (ex_y > 0f) {
			if (Input.GetKeyDown (KeyCode.S)) {
				ran_x -= 2f;
				ex_y -= 1f;
				ex_x -= 10f;

			}
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			ran_x += 2f;
			ex_y += 1f;
			ex_x += 10f;
		}

		cloth.transform.GetComponent<Cloth>().randomAcceleration = new Vector3(ran_x,ran_y,ran_z);
		cloth.transform.GetComponent<Cloth>().externalAcceleration = new Vector3(ex_x,ex_y,ex_z);




		//スペースキーで全ての設定をリセット
		if (Input.GetKeyDown (KeyCode.Space)) {

			red = 255f;
			green = 0f;
			blue = 0f;

			cloth_y = 55.24f;
			pole_scale_y = 7f;
			pole_y = 53.24f;

		}

	}
}
