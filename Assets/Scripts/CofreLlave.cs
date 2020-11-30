using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreLlave : MonoBehaviour
{
  // Atributos
  public int Valor = 5;

  // Referencias
  [SerializeField]
  private AudioSource audioSource;

  [SerializeField]
  private Animator animator;

  private void Awake()
  {
    audioSource = GetComponent<AudioSource>();
    animator = GetComponent<Animator>();
  }

  private void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit impacto;
      Physics.Raycast(rayo, out impacto, Mathf.Infinity);

      if (impacto.collider.gameObject == gameObject)
      {
        
      }
    }
  }
}
