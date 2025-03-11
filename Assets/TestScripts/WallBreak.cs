using UnityEngine;

namespace AE3311
{
    public class DisableKinematicForTaggedObjects : MonoBehaviour
    {
        [SerializeField] public string message;
        [SerializeField] public GameObject objecting;
        public GameObject[] breakableObject;

        public void Start()
        {
            {
                breakableObject = GameObject.FindGameObjectsWithTag("BWallA");
                foreach (GameObject obj in breakableObject)
                {
                    Rigidbody rb = obj.GetComponentInChildren<Rigidbody>();
                    if (rb != null)
                    {
                        rb.isKinematic = false;
                        Debug.Log(message);
                    }
                }
            }

        }
    }
}


/*
{
    breakableObject = GameObject.FindGameObjectsWithTag("BWallA");
    foreach (GameObject obj in breakableObject)
    {
        Rigidbody rb = obj.GetComponentInChildren<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = false;
            Debug.Log(message);
        }
    }
}

        }
    }
}
*/