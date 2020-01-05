using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour {

    public GameObject FigObj;
    private int ativa = 0;
    private float VelRot = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ativa == 1)
        {
            transform.Rotate(0, 10 * Time.deltaTime, 20 * Time.deltaTime);
        }
    }

    public void rota()
    {
        ativa = 1;
        
    }
    public void nrota()
    {
        transform.rotation = new Quaternion(0, -80, -80, 0);
        ativa = 0 ;
        
    }
}
