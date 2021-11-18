using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class InputManager : MonoBehaviour
    {
        public bool leftClickDown;

        void Update()
        {
            leftClickDown = Input.GetMouseButton(0);
        }
    }
}