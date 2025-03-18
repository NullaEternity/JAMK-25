using UnityEngine;

namespace AE3311
{
    public abstract class Object : MonoBehaviour
    {
        [SerializeField] private float Numberings = 10f;
        [SerializeField] private GameObject objecting;

        public abstract void Thingy();

    }
}