using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class CameraManager : MonoBehaviour
    {
        public LayerMask clickIgnoreMask;
        public Vector3 GetClickedWorldPos()
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100, ~clickIgnoreMask))
            {
                if (hit.collider != null)
                {
                    return hit.point;
                }
            }
            return Vector3.zero;
        }
    }
}