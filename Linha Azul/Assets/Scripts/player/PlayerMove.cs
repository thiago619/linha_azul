using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsável por mover o personagem

public class PlayerMove : MonoBehaviour {

    [SerializeField]
    private Vector2 direcao;  //Vetor que indica a direçao do movimento

    public int velocidade;  //Velocidade do personagem

    private Animator anim;

	// Função chamada na inicialização
	void Start () {
        direcao = Vector2.zero;  //Zera o vetor de direcao

        anim = GetComponent<Animator>();
	}
	
	// Função chamada a cada atualização de frame
	void Update () {
        direcaotoMove(); //detecta a tecla acionada

        if(direcao.x!=0||direcao.y!=0)
        {
            setAnimation();
        }
        else
        {
            anim.SetLayerWeight(1, 0);
        }

        

         transform.Translate(direcao * velocidade * Time.deltaTime); // move o personagem de acordo com o vetor vezes a velocidade

	}

    private void direcaotoMove()  //Funcao responsavel por detectar teclas acionadas
    {
        direcao = Vector2.zero; //Zera o vetor de direcao

        if(Input.GetKey(KeyCode.UpArrow)) //se a tecla cima for acionada
        {
            direcao = Vector2.up; // Aponta o vetor paca cima
        }
        if (Input.GetKey(KeyCode.DownArrow)) //se a tecla baixo for acionada
        {
            direcao = Vector2.down; //Aponta o vetor para baixo
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //se a tecla esquerda for acionada
        {
            direcao = Vector2.left; //aponta o vetor para a esquerda
        }
        if (Input.GetKey(KeyCode.RightArrow)) //se a tecla direita for acionada
        {
            direcao = Vector2.right; //apona o vetor para a direita
        }

    }

    private void setAnimation()
    {
        anim.SetLayerWeight(1, 1);
        anim.SetFloat("x", direcao.x);
        anim.SetFloat("y", direcao.y);
    }
}
