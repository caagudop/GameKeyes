using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalDeLosFinales : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other.gameObject.GetComponent<Jugador>().finJuego) {
            SceneManager.LoadScene("Creditos", LoadSceneMode.Single);   
        }
    }

}
