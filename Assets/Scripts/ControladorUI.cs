using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorUI : MonoBehaviour
{
  [SerializeField]
  private TextMeshProUGUI txtVida;

  [SerializeField]
  private TextMeshProUGUI txtMonedas;

  private void Update()
  {
    ActualizarUI();
  }

  public void ActualizarUI()
  {
    txtVida.text = GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().Vida.ToString();
    txtMonedas.text = GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().Monedas.ToString();
    }
}
