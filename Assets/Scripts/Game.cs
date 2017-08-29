using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Game : MonoBehaviour {
	public int score;//计分器
	public static int[,] Numbers;//这是数字排列库
	public static int[,] Symbols;//字符排列库
	public static int w,x,y,z;//这是数组的序列号
	public static int i;
	public string message;//debug用（没啥用）
	public int Life;//生命值计算
	private string ss;//答案文本
	//private int times;
	public Eval kk;//强奸的本质
	private static int yy;//符号玄学变量
	string score1;
	double equalation;
	string answer;
	bool passright;
	System.Random hello = new System.Random ();//这个东西是一把玄学大门的钥匙
	string cs;
	public static int index2;
	public static int[,] numberss = new int[4, 24];
	// Update is called once per frame
	void Update () {

	}
	/*void lala(){
		if (Life <= 0) {
			CancelInvoke ();
			GameObject.Find ("die").GetComponent<Canvas>().enabled=true;
			GameObject.Find ("UI System").SetActive (false);

			GameObject.Find ("Score").GetComponent<Text> ().text = "Last Score:" + score;
			GameObject.Find ("again").GetComponent<Button> ().enabled = true;
			CancelInvoke ();
		} else {
			GameObject.Find ("answer").GetComponent<UILabel> ().text = ss;
		}
	}*/

	//----------------------初始化------------------//

	void Start()
	{
	//	Numbers = new int[4,434006];
		Symbols = new int[3, 64];
		//i = 0;
		//times=-1;
		Life = 150;
		score = 0;
		//InvokeRepeating ("lala", 0.03f, 0.03f);
		//GameObject.Find ("UI System").SetActive (true);
		//GameObject.Find ("die").GetComponent<Canvas>().enabled=false;
		kk = (Eval)gameObject.GetComponent ("Eval");
		//GameObject.Find ("Camera").GetComponent<Camera> ().enabled = false;
		GameObject.Find ("Canvas2").GetComponent<Canvas>().enabled=false;

//		ArrayMaker ();
		i = 0;
		ArrayMaker2 ();

	}


	/*-------------方法事件库-------------*/
	public void begin()
	{
		InvokeRepeating ("timeless", 0, 1);
		Calc ();
		GameObject.Find ("Canvas").GetComponent<Canvas> ().enabled = false;
		GameObject.Find ("Canvas2").GetComponent<Canvas>().enabled=true;

	}
	void timeless(){
		score1 = "Score:" + score;
		GameObject.Find ("Score").GetComponent<Text> ().text = score1;
		Life--;//时间控制

	}
	int ttimes;

/*	void solving()
	{
		if (yy>=64) {
			passright = true;
			GameObject.Find ("pass").GetComponent<Button> ().interactable = true;
			Debug.Log ("Pass Right");
			CancelInvoke ("solving");
		}
		if (yy<=63) {
			if (index2 <= 23) {
				Calca (yy, i);
				ttimes++;
			} else {
				index2 = 0;
				ttimes++;
				yy++;
			}
		}
	}*/

	public void plus(){
		ss=ss+"+";//+
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void minus(){
		ss=ss+"-";//-
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void tt(){
		ss=ss+"*";//*
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void devide(){
		ss = ss + "/";//
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void close_f(){
		ss=ss+"(";//括号
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void close_b(){
		ss=ss+")";//括号
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void n1()
	{
		ss += " " + w+" ";
		GameObject.Find ("n1").GetComponent<Button>().interactable = false;
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;
	}
	public void n2()
	{
		ss += " " + x+" ";
		GameObject.Find ("n2").GetComponent<Button>().interactable = false;
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void n3()
	{
		ss += " " + y+" ";
		GameObject.Find ("n3").GetComponent<Button>().interactable = false;
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void n4()
	{
		ss += " " + z+" ";
		GameObject.Find ("n4").GetComponent<Button>().interactable = false;
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;

	}
	public void clear(){
		ss = "";//清空
		GameObject.Find ("Title2").GetComponent<Text> ().text = ss;
		//times = 0;
		GameObject.Find ("n1").GetComponent<Button>().interactable = true;
		GameObject.Find ("n2").GetComponent<Button>().interactable = true;
		GameObject.Find ("n3").GetComponent<Button>().interactable = true;
		GameObject.Find ("n4").GetComponent<Button>().interactable = true;
	}
	public void pass(){
		if (passright) {
			GameObject.Find ("Title2").GetComponent<Text> ().text = "Right!";
			score += 1;
			Calc ();
		} else {
			GameObject.Find ("Title2").GetComponent<Text> ().text = "Wrong!";
			score -= 5;
			Calc ();
		}
	}
	public void check(){//答案判断
		//if (times == 3) {
		Debug.Log ("yes");
	//	Debug.Log ("Time is" + times);
		Debug.Log (kk.Eva (ss));
		string answer = ""+kk.Eva (ss);
		int nn;
		int.TryParse (answer,out nn);
		if (nn==24 && passright) {
			Debug.Log ("Succeed");
			score+=5;
			//		times = -1;
			GameObject.Find ("Title2").GetComponent<Text> ().text = "Wonderful!";
			//		GameObject.Find ("Canvas").GetComponent<Canvas>().enabled=false;
			Calc();
			//Life = Life + 5;
		}
		else if(nn==24 && passright!=true)
		{
			Debug.Log ("Succeed");
			score+=3;
			//		times = -1;
			GameObject.Find ("Title2").GetComponent<Text> ().text = "Right!";
			//		GameObject.Find ("Canvas").GetComponent<Canvas>().enabled=false;
			Calc();
		} else{
			Debug.Log ("Try Again");
			//		GameObject.Find ("Label").GetComponent<UILabel> ().text = "Wrong!";
			//		GameObject.Find ("Canvas").GetComponent<Canvas>().enabled=false;
			//		times = -1;
			GameObject.Find ("Title2").GetComponent<Text> ().text = "Wrong!";
			score -= 3;
			Calc ();
			//Life = Life - 30;
		}
		//}
	}
	private void sleep()
	{
		//可以猜猜看有什么用233，真的是有用的东西
	}
	void Calc(){//游戏主机制，不可删
		GameObject.Find ("pass").GetComponent<Button> ().interactable = false;
		GameObject.Find ("n1").GetComponent<Button>().interactable = true;
		GameObject.Find ("n2").GetComponent<Button>().interactable = true;
		GameObject.Find ("n3").GetComponent<Button>().interactable = true;
		GameObject.Find ("n4").GetComponent<Button>().interactable = true;
		equalation = 0;
//		i = hello.Next (0, 434005);

		for (yy = 0; yy < 64 && equalation!=24.0000000000; yy++) {
			
			index2 = 0;
			w = hello.Next (1, 13);
			x = hello.Next (1, 13);
			y = hello.Next (1, 13);
			z = hello.Next (1, 13);
			f5 (w, x, y, z);
			index2 = 0;
			while (equalation!=24.0000000000 && index2<24) {
				Debug.Log ("equals " + equalation);
				Calca(yy,index2);
			}
//			answer = ""+kk.Eva(cs);
		}
		passright = equalation!=24.000000000000;
		GameObject.Find ("pass").GetComponent<Button> ().interactable = true;
	//	Debug.Log ("Answer is " + answer);
		Debug.Log ("equals " + equalation);
		ss = "";
	//	times = 0;
	//	GameObject.Find ("Label").GetComponent<UILabel> ().text = Numbers [0, i] + "   " + Numbers [1, i] + "   " + Numbers [2, i] + "   " + Numbers [3, i];
		GameObject.Find ("nn1").GetComponent<Text>().text=""+w;
		GameObject.Find ("nn2").GetComponent<Text>().text=""+x;
		GameObject.Find ("nn3").GetComponent<Text>().text=""+y;
		GameObject.Find ("nn4").GetComponent<Text>().text=""+z;//强暴转换
	//	InvokeRepeating ("cc", 0f, 0.03f);
	}
	public void reload(){
		SceneManager.LoadScene (0);
	}
	public static void ArrayMaker2(){
		int a = 1;
		int b = 1;
		int c = 1;
		for (a = 1; a <=4; a++)
		{
			Symbols[0, i] = a;
			Symbols[1, i] = a;
			Symbols[2, i] = a;
			i++;
		}
		for (a = 1;a<=4; a++)
		{
			for (b=1; b <= 4; b++)
			{
				if (b != a)
				{
					p1(a, a, b);
				}
			}
		}
		p2 (1, 2, 3);
		p2 (1, 2, 4);
		p2 (1, 3, 4);
		p2 (2, 3, 4);
		Debug.Log ("The max is " + i);
	}

	public void Calca(int a,int b){
		for (int index = 0; index <= 2; index++) {
			switch (Symbols[index,a]) {
			case 1:
				cs += "" + numberss[index, index2] + "+";
				Debug.Log ("The index: "+index);
				break;
			case 2:
				cs += "" + numberss [index, index2] + "-";
				Debug.Log ("The index: "+index);
				break;
			case 3:
				cs += "" + numberss [index, index2] + "*";
				Debug.Log ("The index: "+index);
				break;
			case 4:
				cs += "" + numberss [index, index2] + "/";
				Debug.Log ("The index: "+index);
				break;
			default:
				break;
			}
		}
		cs += "" + numberss [3, index2];
		Debug.Log (cs);
		equalation=t.Eval (cs);
		cs = " ";
		if (equalation == 24) {
			passright = false;
			GameObject.Find ("pass").GetComponent<Button> ().interactable = true;
			Debug.Log ("Pass Wrong");
			CancelInvoke ("solving");
		}
		index2++;
	}

	public static void f5(int a,int b,int c,int d)
	{
		numberss[0,index2] = a;
		numberss[1,index2] = b;
		numberss[2,index2] = c;
		numberss[3,index2] = d;
		index2++;
		numberss[0,index2] = a;
		numberss[1,index2] = b;
		numberss[2,index2] = d;
		numberss[3,index2] = c;
		index2++;
		numberss[0,index2] = a;
		numberss[1,index2] = c;
		numberss[2,index2] = b;
		numberss[3,index2] = d;
		index2++;
		numberss[0,index2] = a;
		numberss[1,index2] = c;
		numberss[2,index2] = d;
		numberss[3,index2] = b;
		index2++;
		numberss[0,index2] = a;
		numberss[1,index2] = d;
		numberss[2,index2] = b;
		numberss[3,index2] = c;
		index2++;
		numberss[0,index2] = a;
		numberss[1,index2] = d;
		numberss[2,index2] = c;
		numberss[3,index2] = b;
		index2++;
		numberss[0,index2] = b;
		numberss[1,index2] = a;
		numberss[2,index2] = c;
		numberss[3,index2] = d;
		index2++;
		numberss[0,index2] = b;
		numberss[1,index2] = a;
		numberss[2,index2] = d;
		numberss[3,index2] = c;
		index2++;
		numberss[0,index2] = b;
		numberss[1,index2] = c;
		numberss[2,index2] = a;
		numberss[3,index2] = d;
		index2++;
		numberss[0,index2] = b;
		numberss[1,index2] = c;
		numberss[2,index2] = d;
		numberss[3,index2] = a;
		index2++;
		numberss[0,index2] = b;
		numberss[1,index2] = d;
		numberss[2,index2] = a;
		numberss[3,index2] = c;
		index2++;
		numberss[0,index2] = b;
		numberss[1,index2] = d;
		numberss[2,index2] = c;
		numberss[3,index2] = a;
		index2++;
		numberss[0,index2] = c;
		numberss[1,index2] = a;
		numberss[2,index2] = b;
		numberss[3,index2] = d;
		index2++;
		numberss[0,index2] = c;
		numberss[1,index2] = a;
		numberss[2,index2] = d;
		numberss[3,index2] = b;
		index2++;
		numberss[0,index2] = c;
		numberss[1,index2] = b;
		numberss[2,index2] = a;
		numberss[3,index2] = d;
		index2++;
		numberss[0,index2] = c;
		numberss[1,index2] = b;
		numberss[2,index2] = d;
		numberss[3,index2] = a;
		index2++;
		numberss[0,index2] = c;
		numberss[1,index2] = d;
		numberss[2,index2] = a;
		numberss[3,index2] = b;
		index2++;
		numberss[0,index2] = c;
		numberss[1,index2] = d;
		numberss[2,index2] = b;
		numberss[3,index2] = a;
		index2++;
		numberss[0,index2] = d;
		numberss[1,index2] = a;
		numberss[2,index2] = b;
		numberss[3,index2] = c;
		index2++;
		numberss[0,index2] = d;
		numberss[1,index2] = a;
		numberss[2,index2] = c;
		numberss[3,index2] = b;
		index2++;
		numberss[0,index2] = d;
		numberss[1,index2] = b;
		numberss[2,index2] = a;
		numberss[3,index2] = c;
		index2++;
		numberss[0,index2] = d;
		numberss[1,index2] = b;
		numberss[2,index2] = c;
		numberss[3,index2] = a;
		index2++;
		numberss[0,index2] = d;
		numberss[1,index2] = c;
		numberss[2,index2] = a;
		numberss[3,index2] = b;
		index2++;
		numberss[0,index2] = d;
		numberss[1,index2] = c;
		numberss[2,index2] = b;
		numberss[3,index2] = a;
		index2++;
	}


	public static void p1(int a,int b,int c){
		Symbols [0, i] = a;
		Symbols [1, i] = a;
		Symbols [2, i] = c;
		i++;
		Symbols [0, i] = a;
		Symbols [1, i] = c;
		Symbols [2, i] = a;
		i++;
		Symbols [0, i] = c;
		Symbols [1, i] = a;
		Symbols [2, i] = a;
		i++;
	}

	public static void p2(int a,int b,int c)
	{
		Symbols [0, i] = a;
		Symbols [1, i] = b;
		Symbols [2, i] = c;
		i++;
		Symbols [0, i] = a;
		Symbols [1, i] = c;
		Symbols [2, i] = b;
		i++;
		Symbols [0, i] = b;
		Symbols [1, i] = a;
		Symbols [2, i] = c;
		i++;
		Symbols [0, i] = b;
		Symbols [1, i] = c;
		Symbols [2, i] = a;
		i++;
		Symbols [0, i] = c;
		Symbols [1, i] = a;
		Symbols [2, i] = b;
		i++;
		Symbols [0, i] = c;
		Symbols [1, i] = b;
		Symbols [2, i] = a;
		i++;
	}


}


