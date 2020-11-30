using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    // Patron Singleton
    public static Jugador Instance = null;

    // Parámetros Iniciales
    public const int VidaInicial = 10;

    // Atributos
    public int Vida;
    public bool finJuego;
    public int Monedas = 0;

    public bool llaveRoja = false;
    public bool llaveVerde = false;
    public bool llaveAzul = false;
    public bool llaveAmarilla = false;

    public Transform PuntoDeControl;

    private void Awake()
    {
        // Patron Singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ReiniciarJugador();
        Monedas = 0;
        llaveRoja = false;
        llaveVerde = false;
        llaveAzul = false;
        llaveAmarilla = false;
    }

    public void ReiniciarJugador()
    {
        Vida = VidaInicial;
        Monedas = 0;
    }


    public void RecibirDano(int DanoRecibido)
    {
        if ((Vida - DanoRecibido) > 0)
        {
            Vida -= DanoRecibido;
        }
        else
        {
            ReiniciarJugador();
            SceneManager.LoadScene("Fin", LoadSceneMode.Single);
        }
    }
    public void updateBools(string color) {

        switch(color){
            case "GREEN":
                llaveVerde = true;
                break;
            case "YELLOW":
                llaveAmarilla = true;
                break; 
            case "RED":
                llaveRoja = true;
                break; 
            case "BLUE":
                llaveAzul = true;
                break;
            default:
                break;
        }

    }
}
