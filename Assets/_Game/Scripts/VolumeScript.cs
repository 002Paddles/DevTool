using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeScript : MonoBehaviour
{

    [Header("Volume Selection")]
    [SerializeField] [Tooltip("The property you wish to give this object")] private VolumeType _volumeType;
    
    private void Start()
    {
        if(_volumeType == VolumeType.Win)
        {
            Debug.Log("You Win!");
        }

        if (_volumeType == VolumeType.Lose)
        {
            Debug.Log("You Lose!");
        }


        if (_volumeType == VolumeType.Hazard)
        {
            Debug.Log("Ouch!");
        }






    }




}
                             
