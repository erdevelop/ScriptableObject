using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyType enemyType = null;
    [SerializeField] private TextMeshPro typeText = null;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = enemyType.enemyColor;
        transform.localScale = enemyType.enemyScale;
        typeText.text = enemyType.typeName;
        
    }

    
}
