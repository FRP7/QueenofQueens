using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Collider : MonoBehaviour {

	//public GameObject[] SphereColliders1;
	
	///public List<GameObject> SphereColliders;
	
	/*
	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.tag == "SphereCollider")
		{
			Debug.Log("Colidiu!");
		}
	}
	*/
	
	/*
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
	*/
	
	/*void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.name == "SphereCollider1(1)" + 
			col.gameObject.name == "SphereCollider1" + 
				col.gameObject.name == "SphereCollider2" + 
					col.gameObject.name == "SphereCollider2(1)" + 
						col.gameObject.name == "SphereCollider3" + 
							col.gameObject.name == "SphereCollider3(1)" + 
								col.gameObject.name == "SphereCollider4(1)" +
							col.gameObject.name == "SphereCollider4" +
						col.gameObject.name == "SphereCollider5" + 
					col.gameObject.name == "SphereCollider5(1)" +
				col.gameObject.name == "SphereCollider6(1)"	+
			col.gameObject.name == "SphereCollider6" +
		col.gameObject.name == "SphereCollider7(1)" + 
	col.gameObject.name == "SphereCollider7" + 
		col.gameObject.name == "SphereCollider8" + 
			col.gameObject.name == "SphereCollider8(1)" + 
				col.gameObject.name == "SphereCollider9(1)" + 
					col.gameObject.name == "SphereCollider9")
		{
			Debug.Log("Funcionou!");
		}
	}*/
	
	bool Colliding11 = false;
	bool Colliding1 = false;
	bool Colliding2 = false;
	bool Colliding21 = false;
	bool Colliding3 = false;
	bool Colliding31 = false;
	bool Colliding41 = false;
	bool Colliding4 = false;
	bool Colliding5 = false;
	bool Colliding51 = false;
	bool Colliding61 = false;
	bool Colliding6 = false;
	bool Colliding71 = false;
	bool Colliding7 = false;
	bool Colliding8 = false;
	bool Colliding81 = false;
	bool Colliding91 = false;
	bool Colliding9 = false;
	bool AllColliding = false;

    private void Update()
    {
        CheckForAllCollisions();
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "SphereCollider11")
        {
            Colliding11 = true;
            Debug.Log("SphereCollider11");
        }
		if (col.gameObject.name == "SphereCollider1")
        {
            Colliding1 = true;
            Debug.Log("SphereCollider1");
        }
		if (col.gameObject.name == "SphereCollider2")
        {
            Colliding2 = true;
            Debug.Log("SphereCollider2");
        }
		if (col.gameObject.name == "SphereCollider21")
        {
            Colliding21 = true;
            Debug.Log("SphereCollider21");
        }
		if (col.gameObject.name == "SphereCollider3")
        {
            Colliding3 = true;
            Debug.Log("SphereCollider3");
        }
		if (col.gameObject.name == "SphereCollider31")
        {
            Colliding31 = true;
            Debug.Log("SphereCollider31");
        }
		if (col.gameObject.name == "SphereCollider41")
        {
            Colliding41 = true;
            Debug.Log("SphereCollider41");
        }
		if (col.gameObject.name == "SphereCollider4")
        {
            Colliding4 = true;
            Debug.Log("SphereCollider4");
        }
		if (col.gameObject.name == "SphereCollider5")
        {
            Colliding5 = true;
            Debug.Log("SphereCollider5");
        }
		if (col.gameObject.name == "SphereCollider51")
        {
            Colliding51 = true;
            Debug.Log("SphereCollider51");
        }
		if (col.gameObject.name == "SphereCollider61")
        {
            Colliding61 = true;
            Debug.Log("SphereCollider61");
        }
		if (col.gameObject.name == "SphereCollider6")
        {
            Colliding6 = true;
            Debug.Log("SphereCollider6");
        }
		if (col.gameObject.name == "SphereCollider71")
        {
            Colliding71 = true;
            Debug.Log("SphereCollider71");
        }
		if (col.gameObject.name == "SphereCollider7")
        {
            Colliding7 = true;
            Debug.Log("SphereCollider7");
        }
		if (col.gameObject.name == "SphereCollider8")
        {
            Colliding8 = true;
            Debug.Log("SphereCollider8");
        }
		if (col.gameObject.name == "SphereCollider81")
        {
            Colliding81 = true;
            Debug.Log("SphereCollider81");
        }
		if (col.gameObject.name == "SphereCollider91")
        {
            Colliding91 = true;
            Debug.Log("SphereCollider91");
        }
		if (col.gameObject.name == "SphereCollider9")
        {
            Colliding9 = true;
            Debug.Log("SphereCollider9");
        }
    }

    public void CheckForAllCollisions()
    {
		
		if (Colliding11 == true && Colliding1 == true && Colliding2 == true &&
				Colliding21 == true && Colliding3 == true && Colliding31 == true &&
					Colliding41 == true && Colliding4 == true && Colliding5 == true &&
						Colliding51 == true && Colliding61 == true && Colliding6 == true &&
							Colliding71 == true && Colliding7 == true && Colliding8 == true &&
								Colliding81 == true && Colliding91 == true && Colliding9 == true)
        {
            AllColliding = true;
            Debug.Log("Funciona for fuck sake");
        }
		
    }
	
}

