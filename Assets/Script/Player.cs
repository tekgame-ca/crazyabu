using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float speed;
	Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    	rb=GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
    	Jump();
    	float move = Input.GetAxis("Horizontal");
    	rb.velocity = new Vector2 (speed * move , rb.velocity.y);
    }

    void Jump(){
    	if(Input.GetButtonDown("Jump")){
    		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f),ForceMode2D.Impulse);
    	}
    }
}	

