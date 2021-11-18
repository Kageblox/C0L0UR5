using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Player
{
    public class MovementManager : MonoBehaviour
    {
        public InputManager inputManager;
        public CameraManager cameraManager;
        public NavMeshAgent agent;
        public float movementSpeed;
        
        void Update()
        {
            agent.speed = movementSpeed;
            if (inputManager.leftClickDown)
            {
                Vector3 newClickPos = cameraManager.GetClickedWorldPos();
                if (newClickPos != Vector3.zero)
                {
                    agent.SetDestination(newClickPos);
                }
            }
            Debug.DrawLine(agent.transform.position, agent.destination, Color.red);
        }
        
    }
}