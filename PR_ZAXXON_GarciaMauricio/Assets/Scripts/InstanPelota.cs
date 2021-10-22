using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanPelota : MonoBehaviour
{
    [SerializeField] Transform initPos;
    [SerializeField] GameObject pelota;
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
            float randomY = Random.Range(1f, 13f);
            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(pelota, newPos, Quaternion.identity);


            yield return new WaitForSeconds(intervalo);
        }
    }
}
