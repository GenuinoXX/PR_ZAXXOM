using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanBala : MonoBehaviour
{
    public Rigidbody balaPrefab;
    public Transform lanzador;
    public float velDisp;
    private float inicioDisp;
    public float tiempoDisp;
    AudioSource audioSource;
    [SerializeField] AudioClip motor;
    [SerializeField] AudioClip Disp;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.05f;
        audioSource.PlayOneShot(motor, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > inicioDisp)
        {
            inicioDisp = Time.time + tiempoDisp;

            Rigidbody balaPrefabInstanc;

            balaPrefabInstanc = Instantiate(balaPrefab, lanzador.position, Quaternion.identity);
            balaPrefabInstanc.AddForce(lanzador.forward * 100 * velDisp);

            audioSource.PlayOneShot(Disp, 1f);
        }
    }
}
