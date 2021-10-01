using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarita : MonoBehaviour
{
    [SerializeField] Transform Jgdr;
    [SerializeField] float Smooth = 1F;
    [SerializeField] Vector3 VelCamara = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(Jgdr.position.x, Jgdr.position.y + 3, Jgdr.position.z - 8);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref VelCamara, Smooth);

    }
}
