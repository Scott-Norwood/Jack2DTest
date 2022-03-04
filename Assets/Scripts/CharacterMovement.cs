using UnityEngine;

namespace Scott.Norwood
{
    public class CharacterMovement : MonoBehaviour
    {
        public Controller controller;
        public float movementSpeed = 40f;
        float horizontalMovement = 0f;
        bool jump = false;

        // Update is called once per frame
        void Update()
        {
            horizontalMovement = Input.GetAxisRaw("Horizontal") * movementSpeed;
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }

        private void FixedUpdate()
        {
            controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
    }
}