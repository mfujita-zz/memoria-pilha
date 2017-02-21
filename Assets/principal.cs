using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class principal : MonoBehaviour {

	public static int contador;
	public static string[] pilha;
	public Text contaJogadas;

	// Use this for initialization
	void Start () 
	{
		pilha = new string[10];
		contador = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			pilha [contador] = "Laranja";
			Debug.Log (pilha [contador]);

			contador = contador + 1;

			if (contador == 5) 
			{
				SceneManager.LoadScene ("cena2");
			}
		}

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			pilha [contador] = "Vermelha";
			Debug.Log (pilha [contador]);

			contador = contador + 1;

			if (contador == 5) 
			{
				SceneManager.LoadScene ("cena2");
			}
		}

		if (Input.GetKeyDown (KeyCode.D)) 
		{
			pilha [contador] = "Verde";
			Debug.Log (pilha [contador]);

			contador = contador + 1;

			if (contador == 5) 
			{
				SceneManager.LoadScene ("cena2");
			}
		}

		contaJogadas.text = contador.ToString ();		
	}
}
