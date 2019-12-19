using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float m_speed = 1.0f;
    [SerializeField] float m_jumpPower = 2.0f;
    public bool isGrounded = false;
	Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    	rb=GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && isGrounded == true)
        {
//            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 2f), ForceMode2D.Impulse);
            rb.velocity = new Vector2(rb.velocity.x, m_jumpPower);
        }
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * m_speed;
    }

   

    // void Jump(){
    // 	if(Input.GetButtonDown("Jump")){
    // 		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f),ForceMode2D.Impulse);
    // 	}
    // }
}	

