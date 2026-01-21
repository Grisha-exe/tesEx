using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    private Transform _transform;
    private TMPro.TextMeshProUGUI _text;
    
    void Start()
    {
        _transform = GetComponent<Transform>();
        _text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        
    }
}
