using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class t : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (Eval ("1 + 1 * 3- 1"));
		Debug.Log (a);
		Debug.Log (b);
		Debug.Log (c);
		Debug.Log (d);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private static char[] splitsymbol = new char[5] { '+', '-', '*', '/' ,' '};
	private static char[] splitnumber = new char[11] { '1', '2', '3', '4',' ', '5', '6', '7', '8', '9', '0' };
	private static string[] numbers = new string[4];
	private static double[] keys = new double[4];
	private static int index = 0;
	private static string[] symbols = new string[3];
	private static double a;
	private static double b;
	private static double c;
	private static double d;
	public static double Eval(string s)
	{
		index = 0;
		numbers = s.Split(splitsymbol,4,StringSplitOptions.RemoveEmptyEntries);
		symbols = s.Split(splitnumber,4,StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < 4; i++)
		{
			double.TryParse(numbers[i], out keys[i]);
		}
		a = keys[0];
		b = keys[1];
		c = keys[2];
		d = keys[3];
		switch (symbols[0])
		{
		case "+":
			switch (symbols[1])
			{
			case "+":
				switch (symbols[2])
				{
				case "+":
					return (a + b + c + d);
					break;
				case "-":
					return (a + b + c - d);
					break;
				case "*":
					return (a + b + c * d);
					break;
				case "/":
					return (a + b + c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "-":
				switch (symbols[2])
				{
				case "+":
					return (a + b - c + d);
					break;
				case "-":
					return (a + b - c - d);
					break;
				case "*":
					return (a + b - c * d);
					break;
				case "/":
					return (a + b - c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "*":
				switch (symbols[2])
				{
				case "+":
					return (a + b * c + d);
					break;
				case "-":
					return (a + b * c - d);
					break;
				case "*":
					return (a + b * c * d);
					break;
				case "/":
					return (a + b * c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "/":
				switch (symbols[2])
				{
				case "+":
					return (a + b / c + d);
					break;
				case "-":
					return (a + b / c - d);
					break;
				case "*":
					return (a + b / c * d);
					break;
				case "/":
					return (a + b / c / d);
					break;
				default:
					return (0);
					break;
				}
				break;

			default:
				return (0);
				break;
			}
			break;
		case "-":
			switch (symbols[1])
			{
			case "+":
				switch (symbols[2])
				{
				case "+":
					return (a - b + c + d);
					break;
				case "-":
					return (a - b + c - d);
					break;
				case "*":
					return (a - b + c * d);
					break;
				case "/":
					return (a - b + c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "-":
				switch (symbols[2])
				{
				case "+":
					return (a - b - c + d);
					break;
				case "-":
					return (a - b - c - d);
					break;
				case "*":
					return (a - b - c * d);
					break;
				case "/":
					return (a - b - c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "*":
				switch (symbols[2])
				{
				case "+":
					return (a - b * c + d);
					break;
				case "-":
					return (a - b * c - d);
					break;
				case "*":
					return (a - b * c * d);
					break;
				case "/":
					return (a - b * c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "/":
				switch (symbols[2])
				{
				case "+":
					return (a - b / c + d);
					break;
				case "-":
					return (a - b / c - d);
					break;
				case "*":
					return (a - b / c * d);
					break;
				case "/":
					return (a - b / c / d);
					break;
				default:
					return (0);
					break;
				}
				break;

			default:
				return (0);
				break;
			}
			break;
		case "*":
			switch (symbols[1])
			{
			case "+":
				switch (symbols[2])
				{
				case "+":
					return (a * b + c + d);
					break;
				case "-":
					return (a * b + c - d);
					break;
				case "*":
					return (a * b + c * d);
					break;
				case "/":
					return (a * b + c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "-":
				switch (symbols[2])
				{
				case "+":
					return (a * b - c + d);
					break;
				case "-":
					return (a * b - c - d);
					break;
				case "*":
					return (a * b - c * d);
					break;
				case "/":
					return (a * b - c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "*":
				switch (symbols[2])
				{
				case "+":
					return (a * b * c + d);
					break;
				case "-":
					return (a * b * c - d);
					break;
				case "*":
					return (a * b * c * d);
					break;
				case "/":
					return (a * b * c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "/":
				switch (symbols[2])
				{
				case "+":
					return (a * b / c + d);
					break;
				case "-":
					return (a * b / c - d);
					break;
				case "*":
					return (a * b / c * d);
					break;
				case "/":
					return (a * b / c / d);
					break;
				default:
					return (0);
					break;
				}
				break;

			default:
				return (0);
				break;
			}
			break;

		case "/":
			switch (symbols[1])
			{
			case "+":
				switch (symbols[2])
				{
				case "+":
					return (a / b + c + d);
					break;
				case "-":
					return (a / b + c - d);
					break;
				case "*":
					return (a / b + c * d);
					break;
				case "/":
					return (a / b + c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "-":
				switch (symbols[2])
				{
				case "+":
					return (a / b - c + d);
					break;
				case "-":
					return (a / b - c - d);
					break;
				case "*":
					return (a / b - c * d);
					break;
				case "/":
					return (a / b - c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "*":
				switch (symbols[2])
				{
				case "+":
					return (a / b * c + d);
					break;
				case "-":
					return (a / b * c - d);
					break;
				case "*":
					return (a / b * c * d);
					break;
				case "/":
					return (a / b * c / d);
					break;

				default:
					return (0);
					break;
				}
				break;
			case "/":
				switch (symbols[2])
				{
				case "+":
					return (a / b / c + d);
					break;
				case "-":
					return (a / b / c - d);
					break;
				case "*":
					return (a / b / c * d);
					break;
				case "/":
					return (a / b / c / d);
					break;
				default:
					return (0);
					break;
				}
				break;

			default:
				return (0);
				break;
			}
			break;
		default:
			return (0);
			break;
		}

	}
}
