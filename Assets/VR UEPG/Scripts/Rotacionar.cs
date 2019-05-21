using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionar : MonoBehaviour
{
    // Start is called before the first frame update
    protected const double TAM = 2.5;
    protected const float ROT = 0.8F, COR = 0.03F;
    public double getTAM(){
        return TAM;
    }
    public float getROT(){
        return ROT;
    }

    protected float x, y, z;
    public Color color = Color.red; 
    void Start()
    {
        transform.Rotate(Vector3.forward, 45);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(ROT, ROT, ROT, Space.Self);
        transform.GetComponent<Renderer>().material.color = color;
    }
}
