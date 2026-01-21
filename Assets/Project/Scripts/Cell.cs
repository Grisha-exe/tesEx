using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private Transform _transform;
    private Chip _chip;
    
    public bool IsEmpty => _chip == null;


    public void Start()
    {
        _transform = GetComponent<Transform>();
    }
}