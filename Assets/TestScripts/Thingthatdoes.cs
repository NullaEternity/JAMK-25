using UnityEngine;

namespace AE3311
{
    public abstract class Thingthatdoes : MonoBehaviour
    {
        [SerializeField] public string thingname;
        [SerializeField] public int publicInt = 1;
        [SerializeField] private int privateInt = 10;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.K))
            {
                otherThing();
                doThing();
            }
        }
        public abstract void doThing();

        public virtual void otherThing()
        {
            Debug.Log($"I am a thing and my name is {thingname}.");
        }
    }
}