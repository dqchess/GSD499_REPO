﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public GameObject score;
    public GameObject level;
    public GameObject cash;
    GameManager GM;
	// Use this for initialization
	void Start () {

        GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
        cash.GetComponent<Text>().text = "$"+GM.GetCash();

	}
}
