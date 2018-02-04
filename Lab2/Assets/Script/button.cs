using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
    public Sprite myCharactor;
    public Rigidbody2D character;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        SpriteRenderer sRend = character.GetComponent<SpriteRenderer>();
        sRend.sprite = myCharactor;
    }
}
