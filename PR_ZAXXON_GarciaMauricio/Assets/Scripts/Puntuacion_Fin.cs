using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion_Fin : MonoBehaviour
{
    [SerializeField] Text PuntText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PuntText.text = " " + Puntuacion.Punt_Final;
    }
}
