using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip Whistle;
    public AudioClip Point;
    public AudioClip BallGoal;
    public AudioClip SmokebombSoundEffect;
    private AudioSource audioSource;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayWhistleSound()
    {
        audioSource.PlayOneShot(Whistle);
    }

    public void PlayPointsSound()
    {
        audioSource.PlayOneShot(Point);
    }

    public void PlayBallGoalSound()
    {
        audioSource.PlayOneShot(BallGoal);
    }
    
    public void PlaySmokebombSound()
    {
        audioSource.PlayOneShot(SmokebombSoundEffect);
    }
}
