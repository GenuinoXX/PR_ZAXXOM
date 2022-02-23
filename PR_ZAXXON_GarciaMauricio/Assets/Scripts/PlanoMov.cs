using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanoMov : MonoBehaviour
{
    Renderer rend;
    [SerializeField] Vector2 dspl;
    Iniciar initGame;
    [SerializeField] float velScroll;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        GameObject InitEmpty = GameObject.Find("Iniciar");
        initGame = InitEmpty.GetComponent<Iniciar>();
    }

    // Update is called once per frame
    void Update()
    {
        velScroll = initGame.VelNave / 1000;
        float offset = Time.time * velScroll;
        dspl = new Vector2(0, -offset);

        rend.material.SetTextureOffset("_MainTex", dspl);
        rend.material.SetTextureOffset("_BumpMap", dspl);
    }
}
