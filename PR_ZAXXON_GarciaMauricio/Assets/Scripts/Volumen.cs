using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    float Vol;
    [SerializeField] Slider mySlider;
    [SerializeField] Text VolText;
    // Start is called before the first frame update
    void Start()
    {
        VolText.text = "Volumen:" + mySlider.value;
    }
    public void SubirVol()
    {
        Vol = ((int)mySlider.value);
        VolText.text = "Volumen:" + Vol;
    }
}
