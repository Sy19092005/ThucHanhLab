using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    public void UpdateHealthText(int health)
    {
        text.text = "HP: " + health;
    }
}
