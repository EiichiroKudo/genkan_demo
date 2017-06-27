using UnityEngine;
using System.Collections;

public class SnowGround2Controller : MonoBehaviour {

	//地面テクスチャの色の設定（初期値は白色）
	float red = 255f;
	float green = 255f;
	float blue = 255f;


	//雪の地面テクスチャ
	//GameObject snow_ground_texture1;
	GameObject snow_ground_texture2;

	//靴の足跡
	GameObject shoes;
	GameObject shoes_left1;
	GameObject shoes_right1;
	GameObject shoes_left2;
	GameObject shoes_right2;

	//動物の足跡
	GameObject foots;
	GameObject foot_left1;
	GameObject foot_right1;
	GameObject foot_left2;
	GameObject foot_right2;
	GameObject foot_left3;
	GameObject foot_right3;
	GameObject foot_left4;
	GameObject foot_right4;
	GameObject foot_left5;
	GameObject foot_right5;
	GameObject foot_left6;
	GameObject foot_right6;
	GameObject foot_left7;
	GameObject foot_right7;
	GameObject foot_left8;
	GameObject foot_right8;
	GameObject foot_left9;


	//画像の切り替えに使用する変数
	//int num = 0;

	//テクスチャの座標
	float ground_texture1_x = 0f;
	float ground_texture2_x = -15f;

	//時間の変数
	float time = 0f;


	// Use this for initialization
	void Start () {

		//雪の地面テクスチャ
		//snow_ground_texture1 = GameObject.Find("snow_ground1");
		snow_ground_texture2 = GameObject.Find("snowground2");

		//靴の足跡
		shoes = GameObject.Find ("shoes");
		Vector3 temp = new Vector3 (53f, 6f, -11f);
		shoes.transform.position = temp;
		shoes_left1 = GameObject.Find ("shoes_left1");
		shoes_right1 = GameObject.Find ("shoes_right1");
		shoes_left2 = GameObject.Find ("shoes_left2");
		shoes_right2 = GameObject.Find ("shoes_right2");

		//動物の足跡
		foots = GameObject.Find ("foots");
		Vector3 temp1 = new Vector3 (52f, 4.5f,-9f);
		foots.transform.position = temp1;
		foots.transform.Rotate (0f, 0f, 130f);
	
		foot_left1 = GameObject.Find ("foot_left1");
		foot_right1 = GameObject.Find ("foot_right1");
		foot_left2 = GameObject.Find ("foot_left2");
		foot_right2 = GameObject.Find ("foot_right2");
		foot_left3 = GameObject.Find ("foot_left3");
		foot_right3 = GameObject.Find ("foot_right3");
		foot_left4 = GameObject.Find ("foot_left4");
		foot_right4 = GameObject.Find ("foot_right4");
		foot_left5 = GameObject.Find ("foot_left5");
		foot_right5 = GameObject.Find ("foot_right5");
		foot_left6 = GameObject.Find ("foot_left6");
		foot_right6 = GameObject.Find ("foot_right6");
		foot_left7 = GameObject.Find ("foot_left7");
		foot_right7 = GameObject.Find ("foot_right7");
		foot_left8 = GameObject.Find ("foot_left8");
		foot_right8 = GameObject.Find ("foot_right8");
		foot_left9 = GameObject.Find ("foot_left9");


	
	}
	
	// Update is called once per frame
	void Update () {

		/******************************************************************
		地面のテクスチャの切り替え
		*******************************************************************/

		/*if(Input.GetKeyDown(KeyCode.P)){
			num++;
		}


		switch(num % 2){
			case 0 :
				ground_texture1_x = 0f;
				ground_texture2_x = -15f;
				snow_ground_texture1.transform.position = new Vector3(ground_texture1_x,0f,4.78f);
				snow_ground_texture2.transform.position = new Vector3(ground_texture2_x,0f,4.78f);
				break;

			case 1 :
				ground_texture1_x = -15f;
				ground_texture2_x = 0f;
				snow_ground_texture1.transform.position = new Vector3(ground_texture1_x,0f,4.78f);
				snow_ground_texture2.transform.position = new Vector3(ground_texture2_x,0f,4.78f);
				break;

			default :
				break;
		}*/


		/******************************************************************
		靴の足跡の設定
		*******************************************************************/

		//起動してからの時間を計測
		time += Time.deltaTime;

		//時間経過によって足跡を配置
		if (time > 1f) {
			Vector3 temp = new Vector3 (-1f, -3.9f, 1.5f);
			shoes_left1.transform.localPosition = temp;
		}

		if (time > 2f) {
			Vector3 temp = new Vector3 (-0.5f, -3.2f, 1.5f);
			shoes_right1.transform.localPosition = temp;
		}

		if (time > 3f) {
			Vector3 temp = new Vector3 (-1f, -2.5f, 1.5f);
			shoes_left2.transform.localPosition = temp;
		}

		if (time > 4f) {
			Vector3 temp = new Vector3 (-0.5f, -1.8f, 1.5f);
			shoes_right2.transform.localPosition = temp;
		}

		


		/******************************************************************
		動物の足跡の設定
		*******************************************************************/

		if(time > 0.25f){
			Vector3 temp = new Vector3 (53.4f, 7f, -9.8f);
			foot_left1.transform.position = temp;
		}

		if(time > 0.5f){
			Vector3 temp = new Vector3 (53.2f, 7f, -9.76f);
			foot_right1.transform.position = temp;
		}

		if(time > 0.75f){
			Vector3 temp = new Vector3 	(53.3f, 7f, -9.6f);
			foot_left2.transform.position = temp;
		}
	
		if(time > 1f){
			Vector3 temp = new Vector3 (53.1f, 7f, -9.55f);
			foot_right2.transform.position = temp;
		}

		if(time > 1.25f){
			Vector3 temp = new Vector3 (53.2f, 7f, -9.45f);
			foot_left3.transform.position = temp;
		}

		if(time > 1.5f){
			Vector3 temp = new Vector3 (53f, 7f, -9.4f);
			foot_right3.transform.position = temp;
		}

		if(time > 1.75f){
			Vector3 temp = new Vector3 (53.1f, 7f, -9.25f);
			foot_left4.transform.position = temp;
		}

		if(time > 2f){
			Vector3 temp = new Vector3 (52.9f, 7f, -9.2f);
			foot_right4.transform.position = temp;
		}

		if(time > 2.25f){
			Vector3 temp = new Vector3 (53f, 7f, -9.05f);
			foot_left5.transform.position = temp;
		}

		if(time > 2.5f){
			Vector3 temp = new Vector3 (52.8f, 7f, -8.97f);
			foot_right5.transform.position = temp;
		}

		if (time > 2.75f) {
			Vector3 temp = new Vector3 (52.9f, 7f, -8.85f);
			foot_left6.transform.position = temp;
		}

		if (time > 3f) {
			Vector3 temp = new Vector3 (52.7f,7f,-8.825f);
			foot_right6.transform.position = temp;
		}

		if (time > 3.25f) {
			Vector3 temp = new Vector3 (52.8f,7f,-8.65f);
			foot_left7.transform.position = temp;
		}

		if (time > 3.5f) {
			Vector3 temp = new Vector3 (52.6f,7f,-8.55f);
			foot_right7.transform.position = temp;
		}

		if (time > 3.75f) {
			Vector3 temp = new Vector3 (52.7f,7f,-8.4f);
			foot_left8.transform.position = temp;
		}

		if (time > 4f) {
			Vector3 temp = new Vector3 (52.55f, 7f, -8.3f);
			foot_right8.transform.position = temp;
		}

		if(time > 4.25){
			Vector3 temp = new Vector3 (52.6f, 7f, -8.15f);
			foot_left9.transform.position = temp;
		}

		/******************************************************************
		一定時間が経過すると足跡を元に戻す
		*******************************************************************/

		
		if (time > 5f) {
			Vector3 temp = new Vector3 (0f, 0f, -1f);
			Vector3 temp2 = new Vector3(0f,0f,0f);

			shoes_left1.transform.localPosition = temp2;
			shoes_right1.transform.localPosition = temp2;
			shoes_left2.transform.localPosition = temp2;
			shoes_right2.transform.localPosition = temp2;

			foot_left1.transform.position = temp;
			foot_right1.transform.position = temp;
			foot_left2.transform.position = temp;
			foot_right2.transform.position = temp;
			foot_left3.transform.position = temp;
			foot_right3.transform.position = temp;
			foot_left4.transform.position = temp;
			foot_right4.transform.position = temp;
			foot_left5.transform.position = temp;
			foot_right5.transform.position = temp;
			foot_left6.transform.position = temp;
			foot_right6.transform.position = temp;
			foot_left7.transform.position = temp;
			foot_right7.transform.position = temp;
			foot_left8.transform.position = temp;
			foot_right8.transform.position = temp;
			foot_left9.transform.position = temp;

			time = 0f;

		}


		/******************************************************************
		地面の色の設定
		*******************************************************************/
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

		if (Input.GetKey (KeyCode.Space)) {
			red = 255f;
			green = 255f;
			blue = 255f;
		}

		//snow_ground_texture1.GetComponent<SpriteRenderer>().color = new Color(red/255,green/255,blue/255);
		snow_ground_texture2.GetComponent<SpriteRenderer>().color = new Color(red/255,green/255,blue/255);
	
	}
}
