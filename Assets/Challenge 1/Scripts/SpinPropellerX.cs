using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its Z axis
        transform.Rotate(Vector3.forward * 360 * Time.deltaTime);
    }
}
