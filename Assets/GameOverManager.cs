using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public void CheckGameOver(int health)
    {
        if (health <= 0)
        {
            Debug.Log("🔥 GAME OVER (UnityEvent) 🔥");
        }
    }
}
