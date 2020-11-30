using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCofreGratis : MonoBehaviour
{  // Atributos
    public int Valor = 5;

    // Referencias
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Open");
        GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().Monedas += Valor;
        GetComponent<Collider>().enabled = false;
        audioSource.Play();
        this.transform.GetChild(0).gameObject.SetActive(false);
    }
}
