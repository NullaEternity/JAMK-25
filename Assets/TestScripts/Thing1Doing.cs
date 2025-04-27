using AE3311;
using UnityEngine;

public class Thing1Doing : Thingthatdoes
{
    public override void doThing()
    {
        Debug.Log("I am doing my thing.");
        Debug.Log($"My thing is the public integer {publicInt}");
    }
}
