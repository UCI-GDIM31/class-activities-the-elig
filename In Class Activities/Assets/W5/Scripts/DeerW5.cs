using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5 : MonoBehaviour
{
    //creating a reference of the brown mushroom object for our own use in this class
    [SerializeField] private Transform _target; //defined in inspector


    void Start()
    {
        NavMeshAgent navigator = GetComponent<NavMeshAgent>();

        navigator.SetDestination(_target.position); 
    }

    

   
}