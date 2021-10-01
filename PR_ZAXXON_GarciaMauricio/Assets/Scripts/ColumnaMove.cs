using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnaMove : MonoBehaviour
{
    float rapidez;
    // Start is called before the first frame update
    void Start()
    {
        rapidez = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * rapidez);
    }
    IEnumerator CrearCloumna()
    {
        while (true)
        {
            yield return new WaitForSeconds("intervalo");
            print("khe pazaa");

        }
    }
}
