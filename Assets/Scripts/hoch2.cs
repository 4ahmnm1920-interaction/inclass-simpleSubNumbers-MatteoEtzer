using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoch2 : MonoBehaviour
{

    
    // Start is called before the first frame update
    public int value;
    public float a;
    public float b;

    int Square ( int a)
    {
        //Debug.Log(a * a);
        return (a * a);
    }
    
    void Start()
    {
        int result = Square(value) + Square(value);
        //Debug.Log("result Addition: " + result);        
        Pythagoras(a,b);

    }

    void OnValidate ()
    {
        //Square(value);  

    }
    // Update is called once per frame
    void Pythagoras(float a, float b)
    {
            float c = Mathf.Sqrt(Mathf.Pow(a, 2) + Mathf.Pow(b, 2));
            Debug.Log("c: " + c);
    }
        
}
