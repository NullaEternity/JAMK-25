using UnityEngine;

namespace AE3311
{
    public class DisableKinematicForTaggedObjects : MonoBehaviour
    {
        private bool isPulled;
        public GameObject[] breakableObject;
        async void Start()
        {
            breakableObject = GameObject.FindGameObjectsWithTag("BWallA");
            {
                foreach (GameObject obj in breakableObject)
                {
                    Rigidbody rb = obj.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.isKinematic = false;
                        Debug.Log("boom falling block");
                    }
                }
            }

        }
    }
}