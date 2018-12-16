using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour {

    public AudioSource m_stone_door;

    public void PlayDoorSound () {
        m_stone_door.Play();
	}
	
}
