using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMove : MonoBehaviour
{
    [SerializeField] GameObject initObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posZ = transform.position.z;
        if (posZ > 50)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pelota")
        {
            Destroy(gameObject);
        }
    }
}
