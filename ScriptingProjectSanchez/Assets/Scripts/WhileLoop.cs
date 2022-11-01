using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int CupsInTheSink = 4;

    // Start is called before the first frame update
    void Start()
    {
        while (CupsInTheSink > 0)
            {
            Debug.Log("I've washed a cup!");
            CupsInTheSink--;
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
