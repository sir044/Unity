using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform LFG;
        public float speed = 4;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            LFG.Translate(-LFG.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            LFG.Translate(LFG.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            LFG.Translate(LFG.forward * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            LFG.Translate(-LFG.forward * speed * Time.deltaTime);
        }
    }

}
