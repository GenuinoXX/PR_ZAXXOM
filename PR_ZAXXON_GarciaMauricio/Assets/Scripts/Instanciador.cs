using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField] Transform initPos;
    [SerializeField] GameObject columna;
    float intervalo;
    float desplX = 25f;
    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.25f;
        StartCoroutine("CrearObstaculos");
        Vector3 destPos = initPos.position;
        Vector3 despl = new Vector3(desplX, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CrearObstaculos()
    {
        while (true)
        {
            float randomX = Random.Range(-15f, 15f);
            Vector3 newPos = new Vector3(randomX, initPos.position.y, initPos.position.z);
            Instantiate(columna, newPos, Quaternion.identity);
            

            yield return new WaitForSeconds(intervalo);
        }
    }
}
