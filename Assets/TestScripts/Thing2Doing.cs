using AE3311;
using UnityEngine;

public class Thing2Doing : Thingthatdoes
{
    public override void doThing()
    {
        Debug.Log("I am doing my thing.");
        Debug.Log("I cant call the private int so i guess i do nothing lol");
    }

}
