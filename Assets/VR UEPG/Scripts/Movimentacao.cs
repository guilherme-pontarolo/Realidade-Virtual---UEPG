using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour {

    public float VelMov;
    public int TEMPO = 9000;
    private int cont = 0;
    private int n = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cont < TEMPO)
        {
            n = 1;
            transform.Rotate(n * VelMov * Time.deltaTime, 0, 0);
            cont++;
            if(cont == TEMPO)
            {
                TEMPO = 0;
            }
        }
        if(TEMPO < cont)
        {
            n = -1;
            transform.Rotate(n * VelMov * Time.deltaTime, 0, 0);
            TEMPO++;
            if (TEMPO == cont)
            {
                cont = 0;
            }
        }
        
    }
}
