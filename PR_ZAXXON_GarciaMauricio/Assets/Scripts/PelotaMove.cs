using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaMove : MonoBehaviour
{
    [SerializeField] GameObject initObject;
    Iniciar iniciar;
    float Vel;
    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("Iniciar");
        iniciar = initObject.GetComponent<Iniciar>();
    }

    // Update is called once per frame
    void Update()
    {
        Vel = iniciar.VelNave;
        transform.Translate(Vector3.back * Time.deltaTime * Vel);
        float posZ = transform.position.z;
        if (posZ < -35)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            Destroy(gameObject);
        }
    }
}
