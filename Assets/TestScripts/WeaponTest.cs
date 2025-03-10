using UnityEngine;

namespace AE3311
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private float damage = 1.0f;
        [SerializeField] private float modifier = 0.0f;
        //[SerializeField] private bool isNotUsable = false;

        public abstract void Equip();

        public abstract void Unequip();

        public abstract float Attack();
    } 
}