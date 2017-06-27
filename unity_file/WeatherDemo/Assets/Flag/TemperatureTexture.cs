using UnityEngine;
using System.Collections;

public class TemperatureTexture : MonoBehaviour {
	public Texture imagenone;
	public Texture image_1;
	public Texture image_2;
	public Texture image_3;
	public Texture image_4;
	public Texture image_5;
	public Texture image_6;
	public Texture image_7;
	public Texture image_8;
	public Texture image_9;
	public Texture image_10;
	public Texture image_11;
	public Texture image_12;
	public Texture image_13;
	public Texture image_14;
	public Texture image_15;
	public Texture image_16;
	public Texture image_17;
	public Texture image_18;
	public Texture image_19;
	public Texture image_20;
	public Texture image_21;
	public Texture image_22;
	public Texture image_23;
	public Texture image_24;
	public Texture image_25;
	public Texture image_26;
	public Texture image_27;
	public Texture image_28;
	public Texture image_29;
	public Texture image_30;
	public Texture image_31;
	public Texture image_32;
	public Texture image_33;
	public Texture image_34;
	public Texture image_35;
	public Texture image_36;
	public Texture image_37;
	public Texture image_38;
	public Texture image_39;
	public Texture image_40;
	public Texture image_41;
	public Texture image0;
	public Texture image1;
	public Texture image2;
	public Texture image3;
	public Texture image4;
	public Texture image5;
	public Texture image6;
	public Texture image7;
	public Texture image8;
	public Texture image9;
	public Texture image10;
	public Texture image11;
	public Texture image12;
	public Texture image13;
	public Texture image14;
	public Texture image15;
	public Texture image16;
	public Texture image17;
	public Texture image18;
	public Texture image19;
	public Texture image20;
	public Texture image21;
	public Texture image22;
	public Texture image23;
	public Texture image24;
	public Texture image25;
	public Texture image26;
	public Texture image27;
	public Texture image28;
	public Texture image29;
	public Texture image30;
	public Texture image31;
	public Texture image32;
	public Texture image33;
	public Texture image34;
	public Texture image35;
	public Texture image36;
	public Texture image37;
	public Texture image38;
	public Texture image39;
	public Texture image40;
	public Texture image41;
	

	int count = 25;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(count > 41){
			if (Input.GetKeyDown (KeyCode.W)) {
				count -= 100;
			}
		}
		
		if(count <= 41 && count >= -41){
			if (Input.GetKeyDown (KeyCode.Q)) {
				count += 100;
			}
		}

		if(count < 41){
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				count += 1;
			}
		}

		if(count > -41){
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				count -= 1;
			}
		}

		switch(count){
		case -1:
			GetComponent<Renderer> ().material.mainTexture = image_1;
			break;
		case -2:
			GetComponent<Renderer> ().material.mainTexture = image_2;
			break;	
		case -3:
			GetComponent<Renderer> ().material.mainTexture = image_3;
			break;	
		case -4:
			GetComponent<Renderer> ().material.mainTexture = image_4;
			break;	
		case -5:
			GetComponent<Renderer> ().material.mainTexture = image_5;
			break;
		case -6:
			GetComponent<Renderer> ().material.mainTexture = image_6;
			break;
		case -7:
			GetComponent<Renderer> ().material.mainTexture = image_7;
			break;
		case -8:
			GetComponent<Renderer> ().material.mainTexture = image_8;
			break;	
		case -9:
			GetComponent<Renderer> ().material.mainTexture = image_9;
			break;
		case -10:
			GetComponent<Renderer> ().material.mainTexture = image_10;
			break;
		case -11:
			GetComponent<Renderer> ().material.mainTexture = image_11;
			break;
		case -12:
			GetComponent<Renderer> ().material.mainTexture = image_12;
			break;	
		case -13:
			GetComponent<Renderer> ().material.mainTexture = image_13;
			break;	
		case -14:
			GetComponent<Renderer> ().material.mainTexture = image_14;
			break;	
		case -15:
			GetComponent<Renderer> ().material.mainTexture = image_15;
			break;
		case -16:
			GetComponent<Renderer> ().material.mainTexture = image_16;
			break;
		case -17:
			GetComponent<Renderer> ().material.mainTexture = image_17;
			break;
		case -18:
			GetComponent<Renderer> ().material.mainTexture = image_18;
			break;	
		case -19:
			GetComponent<Renderer> ().material.mainTexture = image_19;
			break;	
		case -20:
			GetComponent<Renderer> ().material.mainTexture = image_20;
			break;
		case -21:
			GetComponent<Renderer> ().material.mainTexture = image_21;
			break;
		case -22:
			GetComponent<Renderer> ().material.mainTexture = image_22;
			break;	
		case -23:
			GetComponent<Renderer> ().material.mainTexture = image_23;
			break;	
		case -24:
			GetComponent<Renderer> ().material.mainTexture = image_24;
			break;	
		case -25:
			GetComponent<Renderer> ().material.mainTexture = image_25;
			break;
		case -26:
			GetComponent<Renderer> ().material.mainTexture = image_26;
			break;
		case -27:
			GetComponent<Renderer> ().material.mainTexture = image_27;
			break;
		case -28:
			GetComponent<Renderer> ().material.mainTexture = image_28;
			break;	
		case -29:
			GetComponent<Renderer> ().material.mainTexture = image_29;
			break;
		case -30:
			GetComponent<Renderer> ().material.mainTexture = image_30;
			break;
		case -31:
			GetComponent<Renderer> ().material.mainTexture = image_31;
			break;
		case -32:
			GetComponent<Renderer> ().material.mainTexture = image_32;
			break;	
		case -33:
			GetComponent<Renderer> ().material.mainTexture = image_33;
			break;	
		case -34:
			GetComponent<Renderer> ().material.mainTexture = image_34;
			break;	
		case -35:
			GetComponent<Renderer> ().material.mainTexture = image_35;
			break;
		case -36:
			GetComponent<Renderer> ().material.mainTexture = image_36;
			break;
		case -37:
			GetComponent<Renderer> ().material.mainTexture = image_37;
			break;
		case -38:
			GetComponent<Renderer> ().material.mainTexture = image_38;
			break;	
		case -39:
			GetComponent<Renderer> ().material.mainTexture = image_39;
			break;
		case -40:
			GetComponent<Renderer> ().material.mainTexture = image_40;
			break;
		case -41:
			GetComponent<Renderer> ().material.mainTexture = image_41;
			break;
		case 0:
			GetComponent<Renderer> ().material.mainTexture = image0;
			break;
		case 1:
			GetComponent<Renderer> ().material.mainTexture = image1;
			break;
		case 2:
			GetComponent<Renderer> ().material.mainTexture = image2;
			break;	
		case 3:
			GetComponent<Renderer> ().material.mainTexture = image3;
			break;	
		case 4:
			GetComponent<Renderer> ().material.mainTexture = image4;
			break;	
		case 5:
			GetComponent<Renderer> ().material.mainTexture = image5;
			break;
		case 6:
			GetComponent<Renderer> ().material.mainTexture = image6;
			break;
		case 7:
			GetComponent<Renderer> ().material.mainTexture = image7;
			break;
		case 8:
			GetComponent<Renderer> ().material.mainTexture = image8;
			break;	
		case 9:
			GetComponent<Renderer> ().material.mainTexture = image9;
			break;	
		case 10:
			GetComponent<Renderer> ().material.mainTexture = image10;
			break;	
		case 11:
			GetComponent<Renderer> ().material.mainTexture = image11;
			break;
		case 12:
			GetComponent<Renderer> ().material.mainTexture = image12;
			break;	
		case 13:
			GetComponent<Renderer> ().material.mainTexture = image13;
			break;
		case 14:
			GetComponent<Renderer> ().material.mainTexture = image14;
			break;	
		case 15:
			GetComponent<Renderer> ().material.mainTexture = image15;
			break;
		case 16:
			GetComponent<Renderer> ().material.mainTexture = image16;
			break;	
		case 17:
			GetComponent<Renderer> ().material.mainTexture = image17;
			break;
		case 18:
			GetComponent<Renderer> ().material.mainTexture = image18;
			break;	
		case 19:
			GetComponent<Renderer> ().material.mainTexture = image19;
			break;
		case 20:
			GetComponent<Renderer> ().material.mainTexture = image20;
			break;
		case 21:
			GetComponent<Renderer> ().material.mainTexture = image21;
			break;
		case 22:
			GetComponent<Renderer> ().material.mainTexture = image22;
			break;	
		case 23:
			GetComponent<Renderer> ().material.mainTexture = image23;
			break;	
		case 24:
			GetComponent<Renderer> ().material.mainTexture = image24;
			break;	
		case 25:
			GetComponent<Renderer> ().material.mainTexture = image25;
			break;
		case 26:
			GetComponent<Renderer> ().material.mainTexture = image26;
			break;
		case 27:
			GetComponent<Renderer> ().material.mainTexture = image27;
			break;
		case 28:
			GetComponent<Renderer> ().material.mainTexture = image28;
			break;	
		case 29:
			GetComponent<Renderer> ().material.mainTexture = image29;
			break;	
		case 30:
			GetComponent<Renderer> ().material.mainTexture = image30;
			break;	
		case 31:
			GetComponent<Renderer> ().material.mainTexture = image31;
			break;
		case 32:
			GetComponent<Renderer> ().material.mainTexture = image32;
			break;	
		case 33:
			GetComponent<Renderer> ().material.mainTexture = image33;
			break;
		case 34:
			GetComponent<Renderer> ().material.mainTexture = image34;
			break;	
		case 35:
			GetComponent<Renderer> ().material.mainTexture = image35;
			break;
		case 36:
			GetComponent<Renderer> ().material.mainTexture = image36;
			break;	
		case 37:
			GetComponent<Renderer> ().material.mainTexture = image37;
			break;
		case 38:
			GetComponent<Renderer> ().material.mainTexture = image38;
			break;	
		case 39:
			GetComponent<Renderer> ().material.mainTexture = image39;
			break;
		case 40:
			GetComponent<Renderer> ().material.mainTexture = image40;
			break;	
		case 41:
			GetComponent<Renderer> ().material.mainTexture = image41;
			break;

		default :
			GetComponent<Renderer> ().material.mainTexture = imagenone;
			break;
		}

	
	}
}