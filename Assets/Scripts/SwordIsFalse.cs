using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordIsFalse : MonoBehaviour {

	//public Renderer RendEspada;

	void Start () {
		gameObject.SetActive(false);
		//SwordSetActive();
		//SwordRenderer();
		//SwordSetActive();
	}
	
	public void SwordSetActive()
	{
		gameObject.SetActive(false);
	}
	
	/*public void SwordRenderer()
	{
		RendEspada = GetComponent<Renderer>();
        RendEspada.enabled = false;
	}*/
	
}
