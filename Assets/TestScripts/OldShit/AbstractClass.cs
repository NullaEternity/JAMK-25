using UnityEngine;

namespace AE3311
{
    public abstract class Enemy : MonoBehaviour
    {
        public float health = 100f;

        // Abstract method - must be implemented by derived classes
        public abstract void Attack();

        // Common method - shared by all subclasses
        public void TakeDamage(float damage)
        {
            health -= damage;
            Debug.Log(gameObject.name + " took " + damage + " damage. Remaining health: " + health);

            if (health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log(gameObject.name + " has been defeated!");
            Destroy(gameObject);
        }
    }
}