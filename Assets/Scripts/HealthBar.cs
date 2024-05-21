using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Transform targetUnit; // R�f�rence � l'unit� associ�e au Slider


    // Update is called once per frame
    void Update()
    {
        if(targetUnit != null) 
        {
            // Mettre � jour position du Slider pour qu'il suive l'unit�
            Vector3 targetPosition = targetUnit.position + (Vector3.up * 6.0f) + (Vector3.right * 0.5f);
            transform.position = Camera.main.WorldToScreenPoint(targetPosition);
        }
    }

}
