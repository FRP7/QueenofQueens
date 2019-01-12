using UnityEngine;
using UnityEngine.SceneManagement;

public class OnEnterWins : MonoBehaviour {

    public void OnTriggerEnter(Collider col1)
    {
        if (col1.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Credits");



            Debug.Log("OnEnterWins");
        }
    }
}
