using UnityEngine;


public class Manipulae : Rotacionar
{
    private const int TEMPO = 300;
    private float x, y, z;
    //public Color color = Color.black;
    private int cont = 0;
    bool liberaY = false, liberaZ = false;

    // Start is called before the first frame update
    void Start()
    {   
        transform.Rotate(Vector3.forward, 45);
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {

        if (cont > TEMPO)
        {
             transform.Rotate(ROT, ROT, ROT, Space.Self);
            if (transform.localScale.x < TAM)
            {
                x += 0.05f * Time.deltaTime;
                transform.localScale += new Vector3(x, 0, 0);
                if (transform.localScale.x > TAM)
                    liberaY = true;
            }
        }
        if(cont > TEMPO*3)
            if(liberaY && transform.localScale.y < TAM)
            {
//                color.g += COR;
                y += 0.05f * Time.deltaTime;
                transform.localScale += new Vector3(0, y, 0);
                if (transform.localScale.y > TAM)
                    liberaZ = true;
            }
        if(cont > TEMPO*5)
            if (liberaZ && transform.localScale.z < TAM)
            {
                z += 0.05f * Time.deltaTime;
                transform.localScale += new Vector3(0, 0, z);
            }
        cont++;

    }
}
