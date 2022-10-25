using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    /*
    // This variable, although private, can be edited from the Game editor thanks to the SerializeField command at the very beginning
    [SerializeField] private int wheels = 4;
    [SerializeField] string name = "Car";
    */
    public bool isOn = true;
    public float gasolina;

    

    // Start is called before the first frame update
    void Start()
    {
        /*
        // Method 1
        Debug.Log($"{name} tiene {wheels} ruedas");

        // Method 2
        Debug.Log(string.Format("El vehículo {0} tiene {1} ruedas", name, wheels));
        */
        if (isOn && gasolina < 10)
        {
            Debug.Log($"A {name} le queda poca gasolina");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
