using UnityEngine;
using System.Collections;

public class RainGroundController : MonoBehaviour {

	//カラーの設定（デフォルトは水色）
	float red = 51f;
	float green = 102f;
	float blue = 127f;

	//波紋のテクスチャの設定
	Texture ring1;
	Texture ring2;
	Texture ring3;
	Texture ring4;
	Texture ring5;
	Texture ring6;
	Texture ring7;
	Texture ring8;
	Texture ring9;
	Texture ring10;
	Texture ring11;

	//テクスチャ変更用の変数
	int count = 5;

	//オブジェクトの取得
	GameObject rainground;
	GameObject ring;


	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		rainground = GameObject.Find("RainGround");
		ring = GameObject.Find("Ring");
	
		//初期サイズ
		ring.GetComponent<ParticleSystem> ().startSize = 0.7f;

		//初期スピード
		ring.GetComponent<ParticleSystem> ().startLifetime = 0.5f;

		//初期の数
		rainground.GetComponent<ParticleSystem> ().emissionRate = 25f;


		//波紋のテクスチャの読み込み(Resourcesフォルダの中)
		ring1 = (Texture)Resources.Load("ring10");
		ring2 = (Texture)Resources.Load("ring15");
		ring3 = (Texture)Resources.Load("ring20");
		ring4 = (Texture)Resources.Load("ring25");
		ring5 = (Texture)Resources.Load("ring30");
		ring6 = (Texture)Resources.Load("ring35");
		ring7 = (Texture)Resources.Load("ring40");
		ring8 = (Texture)Resources.Load("ring45");
		ring9 = (Texture)Resources.Load("ring50");
		ring10 = (Texture)Resources.Load("ring55");
		ring11 = (Texture)Resources.Load("ring60");

	}
	
	// Update is called once per frame
	void Update () {

		/******************************************************************
		 サイズの設定
		 ******************************************************************/

		 //上限の設定
		if(ring.GetComponent<ParticleSystem> ().startSize <= 1.5){

			if(Input.GetKeyDown(KeyCode.H)){
				ring.GetComponent<ParticleSystem> ().startSize += 0.1f;
				ring.GetComponent<ParticleSystem> ().startLifetime += 0.02f;
			}

		}

		//下限の設定
		if(ring.GetComponent<ParticleSystem> ().startSize >= 0.5){

			if(Input.GetKeyDown(KeyCode.J)){
				ring.GetComponent<ParticleSystem> ().startSize -= 0.1f;
				ring.GetComponent<ParticleSystem> ().startLifetime -= 0.02f;
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


		ring.GetComponent<ParticleSystem>().startColor = new Color(red/255,green/255,blue/255);


		/******************************************************************
		 スピードの設定
		 ******************************************************************/

		 //上限の設定
		if (ring.GetComponent<ParticleSystem> ().startLifetime <= 0.9f) {

			if (Input.GetKeyDown (KeyCode.Y)) {
				ring.GetComponent<ParticleSystem> ().startLifetime += 0.1f;
			}

		}


		//下限の設定
		if (ring.GetComponent<ParticleSystem> ().startLifetime >= 0.4f) {

			if (Input.GetKeyDown (KeyCode.T)) {
				ring.GetComponent<ParticleSystem> ().startLifetime -= 0.1f;
			}

		}


		/******************************************************************
		 数の設定
		 ******************************************************************/

		 //上限を設定
		if (rainground.GetComponent<ParticleSystem> ().emissionRate <= 35f) {

			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				rainground.GetComponent<ParticleSystem> ().emissionRate += 5f;
			}

		}


		//下限を設定
		if (rainground.GetComponent<ParticleSystem> ().emissionRate >= 10f) {

			if (Input.GetKeyDown (KeyCode.Alpha6)) {
				rainground.GetComponent<ParticleSystem> ().emissionRate -= 5f;
			}

		}

		/******************************************************************
		 波紋の太さの設定
		 ******************************************************************/

		 if(count < 11){
			if(Input.GetKeyDown(KeyCode.O)){
				count += 1;
			}
		}

		if(count > 1){
			if(Input.GetKeyDown(KeyCode.P)){
				count -= 1;
			}
		}


		//テクスチャの割り当て
		switch(count){
			case 1:
			ring.GetComponent<Renderer>().material.mainTexture = ring1;
			break;

			case 2:
			ring.GetComponent<Renderer>().material.mainTexture = ring2;
			break;		

			case 3:
			ring.GetComponent<Renderer>().material.mainTexture = ring3;
			break;

			case 4:
			ring.GetComponent<Renderer>().material.mainTexture = ring4;
			break;	

			case 5:
			ring.GetComponent<Renderer>().material.mainTexture = ring5;
			break;

			case 6:
			ring.GetComponent<Renderer>().material.mainTexture = ring6;
			break;

			case 7:
			ring.GetComponent<Renderer>().material.mainTexture = ring7;
			break;		

			case 8:
			ring.GetComponent<Renderer>().material.mainTexture = ring8;
			break;

			case 9:
			ring.GetComponent<Renderer>().material.mainTexture = ring9;
			break;	

			case 10:
			ring.GetComponent<Renderer>().material.mainTexture = ring10;
			break;

			case 11:
			ring.GetComponent<Renderer>().material.mainTexture = ring11;
			break;	


			default:
			break;
		}





		//スペースキーで全ての設定をリセット
		if (Input.GetKeyDown (KeyCode.Space)) {

			ring.GetComponent<ParticleSystem> ().startSize = 0.7f;
			ring.GetComponent<ParticleSystem> ().startLifetime = 0.5f;
			rainground.GetComponent<ParticleSystem> ().emissionRate = 25f;

			red = 51f;
			green = 102f;
			blue = 127f;

			count = 5;

		}
			
	
	}
}
