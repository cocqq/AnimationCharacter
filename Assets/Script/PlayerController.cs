using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator player;
    public float moveSpeed = 5f;
    private float minSpeed = 5f;
    private float maxSpeed = 15f;
    void Start()
    {
        player = gameObject.GetComponent<Animator>();
        moveSpeed = minSpeed;
    }
    void CanculateMoveSpeed()
    {
        moveSpeed = Mathf.Lerp(moveSpeed, maxSpeed, 0.003f);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            CanculateMoveSpeed();
            transform.Translate( Vector3.forward * moveSpeed * Time.deltaTime);
            player.SetBool("Walk", true);
            player.SetFloat("Run", moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            CanculateMoveSpeed();
            transform.Translate( -Vector3.forward * moveSpeed * Time.deltaTime);
            player.SetBool("Walk", true);
            player.SetFloat("Run", moveSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            CanculateMoveSpeed();
            transform.Translate( Vector3.left * moveSpeed * Time.deltaTime);
            player.SetBool("Walk", true);
            player.SetFloat("Run", moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            CanculateMoveSpeed();
            transform.Translate( Vector3.right * moveSpeed * Time.deltaTime);
            player.SetBool("Walk", true);
            player.SetFloat("Run", moveSpeed);
        }
        else  
        {
            moveSpeed = minSpeed;
            player.SetBool("Walk", false);
            player.SetFloat("Run", moveSpeed);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate( Vector3.up * moveSpeed * 2f  * Time.deltaTime);
            player.SetBool("Jump", true);
        }
        else player.SetBool("Jump", false);
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Small"))
        {
            player.SetBool("Fallingforward",true);
        }
        else player.SetBool("Fallingforward",false);

        if(other.gameObject.CompareTag("Large"))
        {
            player.SetBool("Fallingbackdown",true);
        }
        else player.SetBool("Fallingbackdown",false);
    }
}

        
    
