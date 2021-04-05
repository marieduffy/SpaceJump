using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public float speed = 1.0f;
    public Animator animator;
    public CharacterController charController;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Astronaut").AddComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("IsJumping", true);
            speed = 4.0f;
            transform.position += Vector3.up * speed * Time.deltaTime;
            
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }
}
