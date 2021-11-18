using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Player
{
    public class AnimationManager : MonoBehaviour
    {
        public Animator animator;
        public NavMeshAgent agent;
        public float animatorMulti = 1f;
        public float idleBreakDelay;
        IEnumerator idleBreakCoroutine;
        bool wasMoving = true;
        void Update()
        {
            animator.SetFloat("Velocity", agent.velocity.magnitude * animatorMulti);

            if (agent.velocity.magnitude > 0.1f)
            {
                if (!wasMoving)
                {
                    wasMoving = true;
                    StopCoroutine(idleBreakCoroutine);
                    Debug.Log("Broken");
                }
            }
            else
            {
                if (wasMoving)
                {
                    wasMoving = false;
                    idleBreakCoroutine = idleBreakEnu();
                    StartCoroutine(idleBreakCoroutine);
                    Debug.Log("Started");
                }
            }
            
        }

        IEnumerator idleBreakEnu()
        {
            while (true)
            {
                Debug.Log("Waiting");
                yield return new WaitForSeconds(idleBreakDelay);
                Debug.Log("IdleBreak");
                animator.SetTrigger("IdleBreak");
            }
        }
    }
}