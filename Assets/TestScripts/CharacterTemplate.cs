using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

namespace AE3311
{
    public abstract class Student : MonoBehaviour, IProficiency
    {
        [SerializeField] public string Name;
        [SerializeField] public int Age;
        [SerializeField] public string IDNumber;
        [SerializeField] public float Energy;
        [SerializeField] public bool Motivated;

        //Try to figure out how to get the
        //IProficiency values to a range of
        //(1,10) in the student subclasses
        //and with Homework(); roll a random
        //subject and compare the student's
        //proficiency with the subject to
        //determine if they can do their
        //fucking homework or not
        public int Coding { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Design3D { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Design2D { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int DesignSound { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Business { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        private List<string> Subjects = new List<string>
        {
            "Coding",
            "Design3D",
            "Design2D",
            "DesignSound",
            "Business"
        };

        public abstract void Homework();
        public abstract void MigrateClassrooms();
    }
}