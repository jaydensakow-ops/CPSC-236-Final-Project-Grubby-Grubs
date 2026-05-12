using UnityEngine;

public class SmokebombPlacer : TimedObjectPlacer
{
    public void Start()
    {
        minimumSecondsToWait = GameParameters.SmokebombMinimumSecondsToWait;
        maximumSecondsToWait = GameParameters.SmokebombSecondsToWait;
    }
}
