using UnityEngine;

public class Smokebomb : TimedObject
{
    //public GameObject SmokeBubbleParticlePrefab;
    
    public void Start()
    {
        secondsOnScreen = GameParameters.SmokebombSecondsOnScreen;
        base.Start();
    }
    /*
    protected override void Activate(GameObject ball)
    {
        Instantiate(SmokeBubbleParticlePrefab, transform.position, Quaternion.identity);
    }
    */
}