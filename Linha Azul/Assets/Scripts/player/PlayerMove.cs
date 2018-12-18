using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsável por mover o personagem

public class PlayerMove : MonoBehaviour {


    private Vector2 direcao;
    public int velocidade;

	// Use this for initialization
	void Start () {
        direcao = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () {
        direcaotoMove();

         transform.Translate(direcao * velocidade * Time.deltaTime);
	}

    private void direcaotoMove()
    {
        direcao = Vector2.zero;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            direcao = Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direcao = Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao = Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao = Vector2.right;
        }

    }
}
