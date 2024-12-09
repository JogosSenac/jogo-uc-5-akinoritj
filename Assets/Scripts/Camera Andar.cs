using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAndar : MonoBehaviour
{
    public float velocidade;
    void Start()
    {
        
    }

    void Update()
    {
            transform.position += new Vector3(1 * velocidade * Time.deltaTime, 0, 0);
    }
}
