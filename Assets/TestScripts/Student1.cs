using UnityEngine;

namespace AE3311
{
    public class Student1 : Student
    {

        public override void Homework()
        {
            if (Motivated == true)
            {
                Debug.Log("I think I will do my homework today.");
            }
        }

        public override void MigrateClassrooms()
        {
            throw new System.NotImplementedException();
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}