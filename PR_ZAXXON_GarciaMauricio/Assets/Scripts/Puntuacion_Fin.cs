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
        PuntText.text = " " + Puntuacion.Punt_Final;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
