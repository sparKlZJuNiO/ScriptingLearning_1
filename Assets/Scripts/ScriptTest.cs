using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   [SerializeField] private int number; // Whole number
    [SerializeField] private float numberFloat; // Decimal Numbers
    [SerializeField] private GameObject player;

    [SerializeField] private bool trueOrFalse;

    void Start() // Private method
    {
        Debug.Log("Hello World"); // Printing
        Debug.Log(number);
    }
}
