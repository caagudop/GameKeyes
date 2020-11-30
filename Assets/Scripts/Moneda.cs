using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
  public int Valor = 1;
  [SerializeField]
  private AudioSource audioSource;
  [SerializeField]
  private GameObject modelo;

  private void OnTriggerEnter(Collider other)
  {
    GameObject ObjetoColisionado = other.gameObject;
    if (ObjetoColisionado.tag == "Player")
    {
      ObjetoColisionado.GetComponent<Jugador>().Monedas += Valor;
      Destroy(modelo);
      Destroy(GetComponent<Collider>());
      audioSource.Play();
      Invoke("Autodestruir", 3.0f);
    }
  }

  private void Autodestruir()
  {
    Destroy(gameObject);
  }
}
