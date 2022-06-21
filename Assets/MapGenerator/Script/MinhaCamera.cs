using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinhaCamera : MonoBehaviour
{
    public Transform alvo;
    RaycastHit hit = new RaycastHit();
    public float disCam;
    public float ajusteCamera;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotacao = transform.eulerAngles;
        rotacao.z = 0;
        transform.eulerAngles = rotacao;

        transform.position = alvo.position - transform.forward * disCam;

        if (Physics.Linecast(alvo.position, transform.position, out hit))
        {
            transform.position = hit.point + transform.forward * ajusteCamera;
        }
    }
}
