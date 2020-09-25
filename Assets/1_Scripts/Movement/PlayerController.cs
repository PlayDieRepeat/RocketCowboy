using System.Collections;
using System.Collections.Generic;
using ECM.Components;
using ECM.Controllers;
using UnityEngine;
//using UnityEngine.Input;

namespace Rocket.Movement
{
    public class PlayerController : BaseCharacterController
    {
        protected override void HandleInput()
        {
            // Toggle pause / resume.
            // By default, will restore character's velocity on resume (eg: restoreVelocityOnResume = true)
            if (Input.GetKeyDown(KeyCode.P))
                pause = !pause;

            // Handle user input
            moveDirection = new Vector3
            {
                x = Input.GetAxisRaw("Horizontal"),
                y = 0.0f,
                z = 0.0f
            };

            jump = Input.GetButton("Jump");
        }

        protected override void Animate()
        {
            Animator cmp_animator = GetComponent<Animator>();
            cmp_animator.SetFloat("forwardSpeed", GetComponent<CharacterMovement>().forwardSpeed);
        }
    }
}
