using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private bool isJumping;
    Rigidbody2D characterRb;
    public float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        isJumping=false;
        characterRb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-0.02f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(0.02f, 0f, 0f);
        }

        if (Input.GetButtonDown("Jump")) {
            isJumping = true;
        }

    }

    void FixedUpdate() {
        if (isJumping) {
            characterRb.velocity = new Vector2(characterRb.velocity.x, jumpSpeed);
            isJumping = false;
        }
    }
}
