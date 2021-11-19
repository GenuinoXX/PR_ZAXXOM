using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    [SerializeField] Text Punt_Text;
    public static int Punt_Final;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("Puntos");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Puntos()
    {
        while (true)
        {
            Punt_Text.text = " " + GameManager.Punt++;

            if(GameManager.Vidas_Jug == 0)
            {

                Puntuacion.Punt_Final = GameManager.Punt;
            }
           
            yield return new WaitForSeconds(0.5f);
        }
    }
}
