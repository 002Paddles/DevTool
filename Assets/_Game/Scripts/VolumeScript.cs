using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeScript : MonoBehaviour
{

    [Header("Volume Selection")]
    [SerializeField] [Tooltip("The property you wish to give this object")] private VolumeType _volumeType;
    [Range(1, 10)]

    [SerializeField] private int dmgValue = 5;

    private void Start()
    {
        if(_volumeType == VolumeType.Win)
        {
            Debug.Log("You Win!");
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.color = Color.green;


        }

        if (_volumeType == VolumeType.Lose)
        {
            Debug.Log("You Lose!");
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.color = Color.red;

        }


        if (_volumeType == VolumeType.Hazard)
        {
            Debug.Log("Ouch!");
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.color = Color.yellow;


        }






    }




}
                             
