using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
        get { if (_instance == null) _instance = GameObject.FindObjectOfType<UIManager>(); return _instance; }
    }

    [SerializeField] private Slider StaminaBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStaminaBar(float value)
    {
        StaminaBar.value = value;
    }
}
