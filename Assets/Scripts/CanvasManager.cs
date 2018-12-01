using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    private static CanvasManager _instance;

    public GameObject   interactionPanel;
    public Text         interactionText;

    public static CanvasManager instance
    {
        get { return _instance; }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (_instance == null)
            _instance = this;
    }

    void Start()
    {
        HideInteractionPanel();
	}

    public void HideInteractionPanel()
    {
        interactionPanel.SetActive(false);
    }

    public void ShowInteractionPanel(string text)
    {
        interactionText.text = text;
        interactionPanel.SetActive(true);
    }
}
