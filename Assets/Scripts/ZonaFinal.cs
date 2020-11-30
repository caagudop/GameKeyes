using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZonaFinal : MonoBehaviour
{
    //Atributos
    public int ObjetivoMonedas;

    //Referencias
    [SerializeField]
    private TextMeshProUGUI txtFinal;

    [SerializeField]
    private GameObject ObjetoAActivar1;
    [SerializeField]
    private GameObject ObjetoAActivar;


    enum EstadoJuego
    {
        MonedasPendientes,
        MonedasConseguidas,
        PuertaAtravesada
    }

    private EstadoJuego estadoJuego = EstadoJuego.MonedasPendientes;

    private void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.LogError("Monedas Objetivo: "+ ObjetivoMonedas);  
        //Debug.LogError("Monedas Obtenidas: "+ GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().Monedas);
        if (ObjetivoMonedas - GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().Monedas <= 0)
        {
            txtFinal.text = "Has conseguido todas las monedas. Coge la llave.";
            ObjetoAActivar1.transform.GetChild(0).gameObject.SetActive(true);
            ObjetoAActivar.transform.GetChild(0).gameObject.SetActive(true);
        }
        else {
            txtFinal.text = "Te quedan " + (ObjetivoMonedas - GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().Monedas) + " monedas. Vuelve cuando las tengas.";
        }

    }
}
