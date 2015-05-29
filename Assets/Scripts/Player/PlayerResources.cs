using UnityEngine;
using System.Collections;

public class PlayerResources : MonoBehaviour 
{

    private int _leaves;

    // GETTERS & SETTERS

    public int leaves 
    {
        get 
        {
            return _leaves;
        }
        set 
        {
            _leaves = value;
            Debug.Log(_leaves);
        }
    }
}
