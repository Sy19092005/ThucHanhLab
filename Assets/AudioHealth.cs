using UnityEngine;

public class AudioHealth : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayHealthSound(int health)
    {
        if (health > 0)
            audioSource.Play();
    }
}
