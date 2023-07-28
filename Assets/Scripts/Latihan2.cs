using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour
{
    public int nilaiA;
    public int nilaiB;
    [Range(1, 200)]
    public int nilaiC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int totall = nilaiA + nilaiB + nilaiC;
        Debug.Log("Total " + totall);
    }
}
