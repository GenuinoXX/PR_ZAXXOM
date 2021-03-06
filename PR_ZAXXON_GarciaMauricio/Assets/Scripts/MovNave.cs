using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovNave : MonoBehaviour

{
    [SerializeField] public float Palante;
    [SerializeField] public float Loslaos;
    [SerializeField] public float Altura;
    [SerializeField] MeshRenderer myMesh;
    [SerializeField] Image Vidas_Img;
    [SerializeField] Sprite[] Vidas_Spr;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        Loslaos = 25f;
        Palante = 50f;
        Altura = 25f;
        int Vidas = GameManager.Vidas_Jug;
        Vidas_Img.sprite = Vidas_Spr[Vidas];
    }

    // Update is called once per frame
    void Update()
    {
        float desp1X = Input.GetAxis("Horizontal");
        float desp1Y = Input.GetAxis("Vertical");
        float desp1P = Input.GetAxis("Palante");

        float posX = transform.position.x;
        float posY = transform.position.y;
        float posP = transform.position.z;

        if ((posX <= 15f || desp1X < 0f) && (posX > -15f || desp1X > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Loslaos * desp1X, Space.World);
        }

        if ((posY <= 13f || desp1Y < 0f) && (posY > 1f || desp1Y > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * Altura * desp1Y, Space.World);
        }

        if ((posP <= 15f || desp1P < 0f) && (posP > 0f || desp1P > 0f))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Palante * desp1P, Space.World);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            GameManager.Vidas_Jug--;
            SceneManager.LoadScene(1);

            if (GameManager.Vidas_Jug == 0) 
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
