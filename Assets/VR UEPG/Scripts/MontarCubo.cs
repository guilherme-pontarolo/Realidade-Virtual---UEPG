using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontarCubo : MonoBehaviour {

    public GameObject Figura;

	private bool rotating;
    private float VelRot = 1;
    public int angulo = 0;
    public float x = 0; // atribuir 1 ou -1 e 0 se não usar
    public float y = 0; //atribuir 1 ou -1 e 0 se não usar
	public float z = 0; //atribuir 1 ou -1 e 0 se não usar
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
    }

	private IEnumerator Rotate( Vector3 angles, float duration )
	{
		rotating = true ;
		Quaternion startRotation = Figura.transform.rotation ;
		Quaternion endRotation = Quaternion.Euler( angles ) * startRotation ;
		for( float t = 0 ; t < duration ; t+= Time.deltaTime )
		{
			Figura.transform.rotation = Quaternion.Lerp( startRotation, endRotation, t / duration ) ;
			yield return null;
		}
		Figura.transform.rotation = endRotation  ;
		rotating = false;
	}

    public void MontarFigura()
    {
		StartCoroutine(Rotate(new Vector3(x * angulo, y * angulo, z * angulo),1));
    }

    public void DesmontarFigura()
    {
		StartCoroutine(Rotate(new Vector3(x * -1 * angulo, y * -1 * angulo, z * -1 *angulo),1));
    }

    /*public void MontarFigura()
    {
        if(VelRot < angulo){
            VelRot++;
            transform.Rotate(EsqDir * 1, 0, BaixoCima * 1);
        }
        
    }
    public void DesmontarFigura()
    {
        if (VelRot > angulo)
        {
            VelRot--;
            transform.Rotate(EsqDir * VelRot / (angulo / 2), 0, BaixoCima * VelRot / (angulo / 2));
        }
    }
    */
    
}
