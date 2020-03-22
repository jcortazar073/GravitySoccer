using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsManager : MonoBehaviour
{
    [Header("Physics")]
    public float gravitationalConstant;

    [HideInInspector]
    public List<Matter> allMatter;

    private void Awake()
    {
        allMatter.AddRange(FindObjectsOfType<Matter>());
    }
}
