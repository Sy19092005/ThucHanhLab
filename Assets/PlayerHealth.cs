using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    [System.Serializable]
    public class IntEvent : UnityEvent<int> { }

    public IntEvent OnHealthChanged;

    void Awake()
    {
        currentHealth = maxHealth;

        if (OnHealthChanged == null)
            OnHealthChanged = new IntEvent();

        OnHealthChanged.Invoke(currentHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(0, currentHealth);

        Debug.Log("Player Health: " + currentHealth);
        OnHealthChanged.Invoke(currentHealth);
    }
}
