using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Input;

namespace Rocket.Movement
{
    public class PlayerController : MonoBehaviour
    {
        CharacterController cmp_controller;

        void Awake()
        {
            cmp_controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            
            
                Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"),0,0);
                print(moveVector);
                cmp_controller.Move(moveVector * Time.deltaTime);
            
 
        
        }
    }
}
