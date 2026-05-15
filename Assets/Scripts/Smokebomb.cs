using UnityEngine;

public class Smokebomb : TimedObject
{
    public void Start()
    {
        secondsOnScreen = GameParameters.SmokebombSecondsOnScreen;
        base.Start();
    }
}