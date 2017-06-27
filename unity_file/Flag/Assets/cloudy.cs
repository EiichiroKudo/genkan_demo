using UnityEngine;
using System.Collections;

public class cloudy : MonoBehaviour {

	GameObject cloud1;
	GameObject cloud2;
	GameObject cloud3;
	GameObject cloud4;
	GameObject cloud5;


	float speed1 = 0.1f;
	float speed2 = 0.08f;
	float speed3 = 0.12f;
	float speed4 = 0.09f;
	float speed5 = 0.1f;


	int onoff = 0; //雲のオンオフ
	int num = 3; //雲の数

	float x1 = -12f;
	float y1 = 22f;
	float z1 = 20f;

	float x2 = -10f;
	float y2 = 20f;
	float z2 = 5f;

	float x3 = -10f;
	float y3 = 18f;
	float z3 = 10f;

	float x4 = -11f;
	float y4 = 19f;
	float z4 = 5f;

	float x5 = -10f;
	float y5 = 20f;
	float z5 = 7f;

	float scale1 = 0.08f;
	float scale2 = 0.08f;
	float scale3 = 0.08f;
	float scale4 = 0.08f;
	float scale5 = 0.08f;

	float border1 = 100f;
	float border2 = 100f;
	float border3 = 100f;
	float border4 = 100f;
	float border5 = 100f;
	

	// Use this for initialization
	void Start () {
		
		cloud1 = GameObject.Find("cloud");
		cloud2 = GameObject.Find("cloud2");
		cloud3 = GameObject.Find("cloud3");
		cloud4 = GameObject.Find("cloud4");
		cloud5 = GameObject.Find("cloud5");

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Alpha0)){
			onoff++;
		}


		if(onoff % 2 == 0){
			 x1 = -20f;
			 y1 = 22f;
			 z1 = 25f;

			 x2 = -10f;
			 y2 = 20f;
			 z2 = 35f;

			 x3 = -15f;
			 y3 = 18f;
			 z3 = 30f;

			 x4 = 45f;
			 y4 = 20f;
			 z4 = -5f;

			 x5 = 45f;
			 y5 = 20f;
			 z5 = 10f;

			Vector3 temp1 = new Vector3(x1,y1,z1);
			cloud1.transform.position = temp1;

			Vector3 temp2 = new Vector3(x2,y2,z2);
			cloud2.transform.position = temp2;

			Vector3 temp3 = new Vector3(x3,y3,z3);
			cloud3.transform.position = temp3;

			Vector3 temp4 = new Vector3(x4,y4,z4);
			cloud4.transform.position = temp4;

			Vector3 temp5 = new Vector3(x5,y5,z5);
			cloud5.transform.position = temp5;

		}


		//雲をOnにしている場合
		if(onoff % 2 == 1){

			if(num < 5){
				if(Input.GetKeyDown(KeyCode.Alpha7)){
					num++;
				}
			}

			if(num > 1){
				if(Input.GetKeyDown(KeyCode.Alpha8)){
					num--;
				}
			}


			switch(num){
				case 1:
					x1 = -20f;
					x2 = 45f;
					x3 = 45f;
					x4 = 45f;
					x5 = 45f;
					break;

				case 2:
					x1 = -20f;
					x2 = 45f;
					x3 = -15f;
					x4 = 45f;
					x5 = 45f;
					break;

				case 3:
					x1 = -20f;
					x2 = -10f;
					x3 = -15f;
					x4 = 45f;
					x5 = 54f;
					break;

				case 4:
					x1 = -20f;
					x2 = -10f;
					x3 = -15f;
					x4 = -10f;
					x5 = 45f;
					break;

				case 5:
					x1 = -20f;
					x2 = -10f;
					x3 = -15f;
					x4 = -10f;
					x5 = -11f;
					break;

				default:
					break;

			}



			if(Input.GetKeyDown(KeyCode.Alpha3)){
				speed1 += 0.1f;
				speed2 += 0.1f;
				speed3 += 0.1f;
				speed4 += 0.1f;
				speed5 += 0.1f;
			}

			if(speed1 > 0.1f || speed2 > 0.05f){
				if(Input.GetKeyDown(KeyCode.Alpha4)){
					speed1 -= 0.05f;
					speed2 -= 0.05f;
					speed3 -= 0.05f;
					speed4 -= 0.05f;
					speed5 -= 0.05f;
				}
			}
	
			z1 += speed1;
			z2 += speed2;
			z3 += speed3;
			z4 += speed4;
			z5 += speed5;


			if(z1 >= border1){
				z1 = 20f;
			}
			if(z2 >= border2){
				z2 = 25f;
			}
			if(z3 >= border3){
				z3 = 22f;
			}
			if(z4 >= border4){
				z4 = 15f;
			}
			if(z5 >= border5){
				z5 = 10f;
			}
			
			Vector3 temp1 = new Vector3(x1,y1,z1);
			cloud1.transform.position = temp1;

			Vector3 temp2 = new Vector3(x2,y2,z2);
			cloud2.transform.position = temp2;

			Vector3 temp3 = new Vector3(x3,y3,z3);
			cloud3.transform.position = temp3;

			Vector3 temp4 = new Vector3(x4,y4,z4);
			cloud4.transform.position = temp4;

			Vector3 temp5 = new Vector3(x5,y5,z5);
			cloud5.transform.position = temp5;


			if(Input.GetKeyDown(KeyCode.Alpha5)){

				scale1 += 0.01f;
				scale2 += 0.01f;
				scale3 += 0.01f;
				scale4 += 0.01f;
				scale5 += 0.01f;

				border1 += 5f;
				border2 += 5f;
				border3 += 5f;
				border4 += 5f;
				border5 += 5f;

			}
			if(scale2 > 0.04f){
				if(Input.GetKeyDown(KeyCode.Alpha6)){

					scale1 -= 0.01f;
					scale2 -= 0.01f;
					scale3 -= 0.01f;
					scale4 -= 0.01f;
					scale5 -= 0.01f;

					border1 -= 5f;
					border2 -= 5f;
					border3 -= 5f;
					border4 -= 5f;
					border5 -= 5f;
					
				}
			}

			cloud1.transform.localScale = new Vector3(scale1,scale1,scale1);
			cloud2.transform.localScale = new Vector3(scale2,scale2,scale2);
			cloud3.transform.localScale = new Vector3(scale3,scale3,scale3);
			cloud4.transform.localScale = new Vector3(scale4,scale4,scale4);
			cloud5.transform.localScale = new Vector3(scale5,scale5,scale5);


		}

	}
}
