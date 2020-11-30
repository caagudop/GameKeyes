using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoChomper : MonoBehaviour
{
  // Atributos
  public int Dano = 1;

  // Referencias
  [SerializeField]
  private NavMeshAgent navMeshAgent;

  [SerializeField]
  private int proximoDestino = 0;

  [SerializeField]
  private float minDist2Dest = 0.2f;

  [SerializeField]
  private List<Transform> listaDestinos;

  private void Awake()
  {
    navMeshAgent = GetComponent<NavMeshAgent>();
  }

  private void Start()
  {
    proximoDestino = 0;
  }

  private void Update()
  {
    if (navMeshAgent != null)
    {
      navMeshAgent.SetDestination(listaDestinos[proximoDestino].position);
    }
    float dist = Vector3.Distance(transform.position, listaDestinos[proximoDestino].position);
    if (dist < minDist2Dest)
    {
      if(proximoDestino + 1 < listaDestinos.Count)
      {
        proximoDestino++;
      }
      else
      {
        proximoDestino = 0;
      }
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    
    if (other.gameObject.tag == "Player")
    {
       GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().RecibirDano(Dano);
    }
  }
}
