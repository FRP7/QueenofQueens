using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Collider : MonoBehaviour {

	public GameObject[] SphereColliders1;
	
	public List<GameObject> SphereColliders;
	
	/*
	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.tag == "SphereCollider")
		{
			Debug.Log("Colidiu!");
		}
	}
	*/
	
	public void OnTriggerEnter (Collider col)
	{
		for (int i = 0; i < SphereColliders1.Length; ++i)
			{
            if(col.SphereColliders1[i].tag == "SphereCollider")
				{			
				  Debug.Log("Funcionou!");
				}
			}	
	}
}

