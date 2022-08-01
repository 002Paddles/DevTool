using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeScript : MonoBehaviour
{

    [Header("Volume Selection")]
    [SerializeField] [Tooltip("The property you wish to give this object")] private VolumeType _volumeType;

    private void Awake()
    {
        if(_volumeType == VolumeType.Win)
        {
            Debug.Log("You Win!");
        }
    }








}
                             
