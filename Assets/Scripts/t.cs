using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (Eval ("1 + 1"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private static char[] splitsymbol=new char[4]{'+','-','*','/'};
	private static char[] splitnumber=new char[10]{'1','2','3','4','5','6','7','8','9','0'};
	private static string[] numbers=new string[4];
	private static int[] keys = new int[4];
	private static int index=0;
	private static string[] symbols=new string[3];
	private static int a;
	private static int b;
	private static int c;
	private static int d;
	public static double Eval(string s){
		index = 0;
		numbers=s.Split(splitsymbol);
		symbols = s.Split (splitnumber);
		foreach (var i in numbers) {
			int.TryParse (i, out keys [index]);
		}
		a = keys [0];
		b = keys [1];
		c = keys [2];
		d = keys [3];
		switch (symbols[0]) {
		case "+":
			switch (symbols[1]) {
			case "+":
				switch (symbols[2]) {
				case "+":
					return(a + b + c+d);
					break;
				case "-":
					return(a + b + c-d);
					break;
				case "*":
					return(a + b + c*d);
					break;
				case "/":
					return(a + b + c/d);
					break;

				default:
					break;
				}
				break;
			case "-":
				switch (symbols[2]) {
				case "+":
					return(a + b - c+d);
					break;
				case "-":
					return(a + b - c-d);
					break;
				case "*":
					return(a + b - c*d);
					break;
				case "/":
					return(a + b -c/d);
					break;

				default:
					break;
				}
				break;
			case "*":
				switch (symbols[2]) {
				case "+":
					return(a + b *c+d);
					break;
				case "-":
					return(a + b *c-d);
					break;
				case "*":
					return(a + b *c*d);
					break;
				case "/":
					return(a + b *c/d);
					break;

				default:
					break;
				}
				break;
			case "/":
				switch (symbols[2]) {
				case "+":
					return(a + b /c+d);
					break;
				case "-":
					return(a + b /c-d);
					break;
				case "*":
					return(a + b /c*d);
					break;
				case "/":
					return(a + b /c/d);
					break;
				default:
					break;
				}
				break;

			default:
				break;
			}
			break;
		case "-":
			switch (symbols[1]) {
			case "+":
				switch (symbols[2]) {
				case "+":
					return(a-b + c+d);
					break;
				case "-":
					return(a-b + c-d);
					break;
				case "*":
					return(a-b + c*d);
					break;
				case "/":
					return(a-b + c/d);
					break;

				default:
					break;
				}
				break;
			case "-":
				switch (symbols[2]) {
				case "+":
					return(a-b - c+d);
					break;
				case "-":
					return(a-b - c-d);
					break;
				case "*":
					return(a-b - c*d);
					break;
				case "/":
					return(a-b -c/d);
					break;

				default:
					break;
				}
				break;
			case "*":
				switch (symbols[2]) {
				case "+":
					return(a-b *c+d);
					break;
				case "-":
					return(a-b *c-d);
					break;
				case "*":
					return(a-b *c*d);
					break;
				case "/":
					return(a-b *c/d);
					break;

				default:
					break;
				}
				break;
			case "/":
				switch (symbols[2]) {
				case "+":
					return(a-b /c+d);
					break;
				case "-":
					return(a-b /c-d);
					break;
				case "*":
					return(a-b /c*d);
					break;
				case "/":
					return(a-b /c/d);
					break;
				default:
					break;
				}
				break;

			default:
				break;
			}
			break;
		case "*":
			switch (symbols[1]) {
			case "+":
				switch (symbols[2]) {
				case "+":
					return(a*b + c+d);
					break;
				case "-":
					return(a*b + c-d);
					break;
				case "*":
					return(a*b + c*d);
					break;
				case "/":
					return(a*b + c/d);
					break;

				default:
					break;
				}
				break;
			case "-":
				switch (symbols[2]) {
				case "+":
					return(a*b - c+d);
					break;
				case "-":
					return(a*b - c-d);
					break;
				case "*":
					return(a*b - c*d);
					break;
				case "/":
					return(a*b -c/d);
					break;

				default:
					break;
				}
				break;
			case "*":
				switch (symbols[2]) {
				case "+":
					return(a*b *c+d);
					break;
				case "-":
					return(a*b *c-d);
					break;
				case "*":
					return(a*b *c*d);
					break;
				case "/":
					return(a*b *c/d);
					break;

				default:
					break;
				}
				break;
			case "/":
				switch (symbols[2]) {
				case "+":
					return(a*b /c+d);
					break;
				case "-":
					return(a*b /c-d);
					break;
				case "*":
					return(a*b /c*d);
					break;
				case "/":
					return(a*b /c/d);
					break;
				default:
					break;
				}
				break;

			default:
				break;
			}
			break;

		case "/":
			switch (symbols[1]) {
			case "+":
				switch (symbols[2]) {
				case "+":
					return(a/b + c+d);
					break;
				case "-":
					return(a/b + c-d);
					break;
				case "*":
					return(a/b + c*d);
					break;
				case "/":
					return(a/b + c/d);
					break;

				default:
					break;
				}
				break;
			case "-":
				switch (symbols[2]) {
				case "+":
					return(a/b - c+d);
					break;
				case "-":
					return(a/b - c-d);
					break;
				case "*":
					return(a/b - c*d);
					break;
				case "/":
					return(a/b -c/d);
					break;

				default:
					break;
				}
				break;
			case "*":
				switch (symbols[2]) {
				case "+":
					return(a/b *c+d);
					break;
				case "-":
					return(a/b *c-d);
					break;
				case "*":
					return(a/b *c*d);
					break;
				case "/":
					return(a/b *c/d);
					break;

				default:
					break;
				}
				break;
			case "/":
				switch (symbols[2]) {
				case "+":
					return(a/b /c+d);
					break;
				case "-":
					return(a/b /c-d);
					break;
				case "*":
					return(a/b /c*d);
					break;
				case "/":
					return(a/b /c/d);
					break;
				default:
					break;
				}
				break;

			default:
				break;
			}
			break;
		default:
			break;
		}
		return(0);
	}
}
