using UnityEngine;
using System.Collections;

public class Temperature : MonoBehaviour {

	//オブジェクトの取得
	GameObject cloth;

	//気温の設定
	Texture imagenone;
	Texture image_1;
	Texture image_2;
	Texture image_3;
	Texture image_4;
	Texture image_5;
	Texture image_6;
	Texture image_7;
	Texture image_8;
	Texture image_9;
	Texture image_10;
	Texture image_11;
	Texture image_12;
	Texture image_13;
	Texture image_14;
	Texture image_15;
	Texture image_16;
	Texture image_17;
	Texture image_18;
	Texture image_19;
	Texture image_20;
	Texture image_21;
	Texture image_22;
	Texture image_23;
	Texture image_24;
	Texture image_25;
	Texture image_26;
	Texture image_27;
	Texture image_28;
	Texture image_29;
	Texture image_30;
	Texture image_31;
	Texture image_32;
	Texture image_33;
	Texture image_34;
	Texture image_35;
	Texture image_36;
	Texture image_37;
	Texture image_38;
	Texture image_39;
	Texture image_40;
	Texture image_41;
	Texture image0;
	Texture image1;
	Texture image2;
	Texture image3;
	Texture image4;
	Texture image5;
	Texture image6;
	Texture image7;
	Texture image8;
	Texture image9;
	Texture image10;
	Texture image11;
	Texture image12;
	Texture image13;
	Texture image14;
	Texture image15;
	Texture image16;
	Texture image17;
	Texture image18;
	Texture image19;
	Texture image20;
	Texture image21;
	Texture image22;
	Texture image23;
	Texture image24;
	Texture image25;
	Texture image26;
	Texture image27;
	Texture image28;
	Texture image29;
	Texture image30;
	Texture image31;
	Texture image32;
	Texture image33;
	Texture image34;
	Texture image35;
	Texture image36;
	Texture image37;
	Texture image38;
	Texture image39;
	Texture image40;
	Texture image41;


	//気温テクスチャ切り替え用変数
	int count = 25;


	// Use this for initialization
	void Start () {

		//オブジェクトの取得
		cloth = GameObject.Find("cloth");

		//テクスチャの読み込み
		image_1 = (Texture)Resources.Load("image_1");
		image_2 = (Texture)Resources.Load("image_2");
		image_3 = (Texture)Resources.Load("image_3");
		image_4 = (Texture)Resources.Load("image_4");
		image_5 = (Texture)Resources.Load("image_5");
		image_6 = (Texture)Resources.Load("image_6");
		image_7 = (Texture)Resources.Load("image_7");
		image_8 = (Texture)Resources.Load("image_8");
		image_9 = (Texture)Resources.Load("image_9");
		image_10 = (Texture)Resources.Load("image_10");
		image_11 = (Texture)Resources.Load("image_11");
		image_12 = (Texture)Resources.Load("image_12");
		image_13 = (Texture)Resources.Load("image_13");
		image_14 = (Texture)Resources.Load("image_14");
		image_15 = (Texture)Resources.Load("image_15");
		image_16 = (Texture)Resources.Load("image_16");
		image_17 = (Texture)Resources.Load("image_17");
		image_18 = (Texture)Resources.Load("image_18");
		image_19 = (Texture)Resources.Load("image_19");
		image_20 = (Texture)Resources.Load("image_20");
		image_21 = (Texture)Resources.Load("image_21");
		image_22 = (Texture)Resources.Load("image_22");
		image_23 = (Texture)Resources.Load("image_23");
		image_24 = (Texture)Resources.Load("image_24");
		image_25 = (Texture)Resources.Load("image_25");
		image_26 = (Texture)Resources.Load("image_26");
		image_27 = (Texture)Resources.Load("image_27");
		image_28 = (Texture)Resources.Load("image_28");
		image_29 = (Texture)Resources.Load("image_29");
		image_30 = (Texture)Resources.Load("image_30");
		image_31 = (Texture)Resources.Load("image_31");
		image_32 = (Texture)Resources.Load("image_32");
		image_33 = (Texture)Resources.Load("image_33");
		image_34 = (Texture)Resources.Load("image_34");
		image_35 = (Texture)Resources.Load("image_35");
		image_36 = (Texture)Resources.Load("image_36");
		image_37 = (Texture)Resources.Load("image_37");
		image_38 = (Texture)Resources.Load("image_38");
		image_39 = (Texture)Resources.Load("image_39");
		image_40 = (Texture)Resources.Load("image_40");
		image_41 = (Texture)Resources.Load("image_41");
		image0 = (Texture)Resources.Load("image0");
		image1 = (Texture)Resources.Load("image1");
		image2 = (Texture)Resources.Load("image2");
		image3 = (Texture)Resources.Load("image3");
		image4 = (Texture)Resources.Load("image4");
		image5 = (Texture)Resources.Load("image5");
		image6 = (Texture)Resources.Load("image6");
		image7 = (Texture)Resources.Load("image7");
		image8 = (Texture)Resources.Load("image8");
		image9 = (Texture)Resources.Load("image9");
		image10 = (Texture)Resources.Load("image10");
		image11 = (Texture)Resources.Load("image11");
		image12 = (Texture)Resources.Load("image12");
		image13 = (Texture)Resources.Load("image13");
		image14 = (Texture)Resources.Load("image14");
		image15 = (Texture)Resources.Load("image15");
		image16 = (Texture)Resources.Load("image16");
		image17 = (Texture)Resources.Load("image17");
		image18 = (Texture)Resources.Load("image18");
		image19 = (Texture)Resources.Load("image19");
		image20 = (Texture)Resources.Load("image20");
		image21 = (Texture)Resources.Load("image21");
		image22 = (Texture)Resources.Load("image22");
		image23 = (Texture)Resources.Load("image23");
		image24 = (Texture)Resources.Load("image24");
		image25 = (Texture)Resources.Load("image25");
		image26 = (Texture)Resources.Load("image26");
		image27 = (Texture)Resources.Load("image27");
		image28 = (Texture)Resources.Load("image28");
		image29 = (Texture)Resources.Load("image29");
		image30 = (Texture)Resources.Load("image30");
		image31 = (Texture)Resources.Load("image31");
		image32 = (Texture)Resources.Load("image32");
		image33 = (Texture)Resources.Load("image33");
		image34 = (Texture)Resources.Load("image34");
		image35 = (Texture)Resources.Load("image35");
		image36 = (Texture)Resources.Load("image36");
		image37 = (Texture)Resources.Load("image37");
		image38 = (Texture)Resources.Load("image38");
		image39 = (Texture)Resources.Load("image39");
		image40 = (Texture)Resources.Load("image40");
		image41 = (Texture)Resources.Load("image41");
	
	
	}
	
	// Update is called once per frame
	void Update () {

		/****************************************************************
		気温の設定
		*****************************************************************/

		//気温表示のOff
		if(count > 41){
			if (Input.GetKeyDown (KeyCode.W)) {
				count -= 100;
			}
		}
		
		//気温表示のOn
		if(count <= 41 && count >= -41){
			if (Input.GetKeyDown (KeyCode.Q)) {
				count += 100;
			}
		}

		//上限の設定
		if(count < 41){
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				count += 1;
			}
		}

		//下限の設定
		if(count > -41){
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				count -= 1;
			}
		}



		//テクスチャの適用
		switch(count){
		case -1:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_1;
			break;
		case -2:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_2;
			break;	
		case -3:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_3;
			break;	
		case -4:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_4;
			break;	
		case -5:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_5;
			break;
		case -6:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_6;
			break;
		case -7:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_7;
			break;
		case -8:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_8;
			break;	
		case -9:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_9;
			break;
		case -10:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_10;
			break;
		case -11:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_11;
			break;
		case -12:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_12;
			break;	
		case -13:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_13;
			break;	
		case -14:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_14;
			break;	
		case -15:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_15;
			break;
		case -16:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_16;
			break;
		case -17:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_17;
			break;
		case -18:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_18;
			break;	
		case -19:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_19;
			break;	
		case -20:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_20;
			break;
		case -21:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_21;
			break;
		case -22:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_22;
			break;	
		case -23:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_23;
			break;	
		case -24:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_24;
			break;	
		case -25:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_25;
			break;
		case -26:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_26;
			break;
		case -27:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_27;
			break;
		case -28:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_28;
			break;	
		case -29:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_29;
			break;
		case -30:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_30;
			break;
		case -31:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_31;
			break;
		case -32:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_32;
			break;	
		case -33:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_33;
			break;	
		case -34:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_34;
			break;	
		case -35:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_35;
			break;
		case -36:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_36;
			break;
		case -37:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_37;
			break;
		case -38:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_38;
			break;	
		case -39:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_39;
			break;
		case -40:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_40;
			break;
		case -41:
			cloth.GetComponent<Renderer> ().material.mainTexture = image_41;
			break;
		case 0:
			cloth.GetComponent<Renderer> ().material.mainTexture = image0;
			break;
		case 1:
			cloth.GetComponent<Renderer> ().material.mainTexture = image1;
			break;
		case 2:
			cloth.GetComponent<Renderer> ().material.mainTexture = image2;
			break;	
		case 3:
			cloth.GetComponent<Renderer> ().material.mainTexture = image3;
			break;	
		case 4:
			cloth.GetComponent<Renderer> ().material.mainTexture = image4;
			break;	
		case 5:
			cloth.GetComponent<Renderer> ().material.mainTexture = image5;
			break;
		case 6:
			cloth.GetComponent<Renderer> ().material.mainTexture = image6;
			break;
		case 7:
			cloth.GetComponent<Renderer> ().material.mainTexture = image7;
			break;
		case 8:
			cloth.GetComponent<Renderer> ().material.mainTexture = image8;
			break;	
		case 9:
			cloth.GetComponent<Renderer> ().material.mainTexture = image9;
			break;	
		case 10:
			cloth.GetComponent<Renderer> ().material.mainTexture = image10;
			break;	
		case 11:
			cloth.GetComponent<Renderer> ().material.mainTexture = image11;
			break;
		case 12:
			cloth.GetComponent<Renderer> ().material.mainTexture = image12;
			break;	
		case 13:
			cloth.GetComponent<Renderer> ().material.mainTexture = image13;
			break;
		case 14:
			cloth.GetComponent<Renderer> ().material.mainTexture = image14;
			break;	
		case 15:
			cloth.GetComponent<Renderer> ().material.mainTexture = image15;
			break;
		case 16:
			cloth.GetComponent<Renderer> ().material.mainTexture = image16;
			break;	
		case 17:
			cloth.GetComponent<Renderer> ().material.mainTexture = image17;
			break;
		case 18:
			cloth.GetComponent<Renderer> ().material.mainTexture = image18;
			break;	
		case 19:
			cloth.GetComponent<Renderer> ().material.mainTexture = image19;
			break;
		case 20:
			cloth.GetComponent<Renderer> ().material.mainTexture = image20;
			break;
		case 21:
			cloth.GetComponent<Renderer> ().material.mainTexture = image21;
			break;
		case 22:
			cloth.GetComponent<Renderer> ().material.mainTexture = image22;
			break;	
		case 23:
			cloth.GetComponent<Renderer> ().material.mainTexture = image23;
			break;	
		case 24:
			cloth.GetComponent<Renderer> ().material.mainTexture = image24;
			break;	
		case 25:
			cloth.GetComponent<Renderer> ().material.mainTexture = image25;
			break;
		case 26:
			cloth.GetComponent<Renderer> ().material.mainTexture = image26;
			break;
		case 27:
			cloth.GetComponent<Renderer> ().material.mainTexture = image27;
			break;
		case 28:
			cloth.GetComponent<Renderer> ().material.mainTexture = image28;
			break;	
		case 29:
			cloth.GetComponent<Renderer> ().material.mainTexture = image29;
			break;	
		case 30:
			cloth.GetComponent<Renderer> ().material.mainTexture = image30;
			break;	
		case 31:
			cloth.GetComponent<Renderer> ().material.mainTexture = image31;
			break;
		case 32:
			cloth.GetComponent<Renderer> ().material.mainTexture = image32;
			break;	
		case 33:
			cloth.GetComponent<Renderer> ().material.mainTexture = image33;
			break;
		case 34:
			cloth.GetComponent<Renderer> ().material.mainTexture = image34;
			break;	
		case 35:
			cloth.GetComponent<Renderer> ().material.mainTexture = image35;
			break;
		case 36:
			cloth.GetComponent<Renderer> ().material.mainTexture = image36;
			break;	
		case 37:
			cloth.GetComponent<Renderer> ().material.mainTexture = image37;
			break;
		case 38:
			cloth.GetComponent<Renderer> ().material.mainTexture = image38;
			break;	
		case 39:
			cloth.GetComponent<Renderer> ().material.mainTexture = image39;
			break;
		case 40:
			cloth.GetComponent<Renderer> ().material.mainTexture = image40;
			break;	
		case 41:
			cloth.GetComponent<Renderer> ().material.mainTexture = image41;
			break;

		default :
			cloth.GetComponent<Renderer> ().material.mainTexture = imagenone;
			break;
		}
	
	}
}
