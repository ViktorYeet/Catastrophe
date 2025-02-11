using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
    public class PlayerMovement : MonoBehaviour
    {

        public CharacterController controller;

        public float speed = 5f;
        public float gravity = -1000;
        public float jumpHeight = 2f;

        Vector3 velocity;

        bool isGrounded;

        // Update is called once per frame
        void Update()
        {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

           

            if (Input.GetButtonDown("Jump"))
            {
                // Calculate the upward velocity required to reach the jump height
                velocity.y = Mathf.Sqrt(jumpHeight * -5f * gravity);
            }
            velocity.y += gravity * 5f * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

        }
    }
}