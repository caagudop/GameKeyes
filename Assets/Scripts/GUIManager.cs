using System;
using UnityEngine;

public class GUIManager : MonoBehaviour
{

	public static GUIManager Instance;

	//public PowerUpTimer PowerUpTimer;

	void Awake()
	{
		// Si ya existe un GUIManager nos destruimos
		if (Instance != null && Instance != this)
			Destroy(this);
		else
		{
			Instance = this;
            
		}
	}

    internal void StartPowerUpTimer(float m_duration)
    {
        throw new NotImplementedException();
    }
}
