using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    private Transform _transform;
    private TMPro.TextMeshProUGUI _chiplevel;
    
    void Start()
    {
        _transform = GetComponent<Transform>();
        _chiplevel = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        
    }
}
