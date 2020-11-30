using UnityEngine;
using System.Collections;

public class StickyFloor : MonoBehaviour {

    private Transform m_originalParent = null;
    public Transform m_transformToAttach;

    void Start()
    {
        if (m_transformToAttach == null)
            m_transformToAttach = transform;
    }

    void OnTriggerEnter(Collider other)
    {
        Attachable atachable = other.GetComponent<Attachable>();
        if (atachable && atachable.IsAttachable)
        {
            m_originalParent = other.transform.parent;
            other.transform.parent = m_transformToAttach;
            atachable.IsAttached = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //TODO 2: Cuando el objeto que caiga sea attachable, como estamos saliendo, desatachamos el objeto. Ojo, la scala puede cambiar!!!
        Attachable atachable = other.GetComponent<Attachable>();
        if (atachable && atachable.IsAttached)
        {
            other.transform.parent = m_originalParent;
            atachable.IsAttached = false;
        }

    }
}
