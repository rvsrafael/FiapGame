﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

	public float velocity;
	public float initialPosition, finalPosition;

	public GameObject cactusPrefab;
	public Transform cactusGenerator;

	void Start() {
	}

	// Update is called once per frame
	void Update()
	{
		// Verifica se atingiu o limite de camera e reposiciona para um novo ciclo.
		if (transform.position.x <= finalPosition)
		{
			transform.position = new Vector2(initialPosition, transform.position.y);

			Instantiate (cactusPrefab, cactusGenerator.position, cactusGenerator.rotation);
		}

		// Move o fundo para o lado esquerdo da tela.
		transform.Translate(Vector2.left * velocity * Time.deltaTime);
	}
}
