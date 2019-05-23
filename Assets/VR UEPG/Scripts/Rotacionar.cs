using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionar : MonoBehaviour
{
    // Start is called before the first frame update
    protected const double TAM = 2.5;
    protected const float ROT = 0.8F, COR = 0.03F;
    public GameObject cubo;
    GameObject obj;
    protected float x, y, z;
    public Color color = Color.red; 
    void Start()
    {

        transform.GetComponent<Renderer>().material.color = color;
        cubo.transform.Rotate(45f, 0f, 45f, Space.Self);
       /* if(Equals(cubo)){
            transform.Rotate(Vector3.forward, 45);
            cubo.transform.Rotate(Vector3.forward, 45);
        }
         */
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, ROT, 0, Space.World);
    }
}
