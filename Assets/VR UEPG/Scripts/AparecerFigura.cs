using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerFigura : MonoBehaviour{

    public GameObject FiguraObjeto;
    public float x = -0.35f, y = 1;
    public int VelRot = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Mostra ou esconde o objeto
    public void ApareceFigura()
    {
        FiguraObjeto.transform.position = new Vector3(x, y, 5);
    }

    public void DesapareceFigura()
    {
        FiguraObjeto.transform.position = new Vector3(0, 0, -2000);
    }
}
