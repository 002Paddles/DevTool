using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "VolumeData_", menuName = "VolumeData" )]
public class VolumeData : ScriptableObject
{
    
    [Header("Volume Selection")]
    [SerializeField] [Tooltip("The property you wish to give this object")] private VolumeType _volumeType;
    [SerializeField] public int _range;
}
