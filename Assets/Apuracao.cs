using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Apuracao : principal {

	public Text mostraSituacao;
	public int acertos = 0;
	public int erros = 0;

	// Use this for initialization
	void Start () 
	{
		contador = contador - 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			if (pilha [contador] == "Laranja") 
			{
				mostraSituacao.text = "Acertou Miseravi!";
				contador = contador - 1;
				acertos = acertos + 1;
			} 
			else 
			{
				mostraSituacao.text = "Errou!!!";
				erros = erros + 1;
			}
		}

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			if (pilha [contador] == "Vermelha") 
			{
				mostraSituacao.text = "Acertou Miseravi!";
				contador = contador - 1;
				acertos = acertos + 1;
			} 
			else 
			{
				mostraSituacao.text = "Errou!!!";
				erros = erros + 1;
			}
		}

		if (Input.GetKeyDown (KeyCode.D)) 
		{
			if (pilha [contador] == "Verde") 
			{
				mostraSituacao.text = "Acertou Miseravi!";
				contador = contador - 1;
				acertos = acertos + 1;
			} 
			else 
			{
				mostraSituacao.text = "Errou!!!";
				erros = erros + 1;
			}
		}

		if (erros > 2) 
		{
			SceneManager.LoadScene ("cena-final");
		}

		if (acertos == 5) 
		{
			SceneManager.LoadScene ("cena-final-vitoria");
		}
	}
}
