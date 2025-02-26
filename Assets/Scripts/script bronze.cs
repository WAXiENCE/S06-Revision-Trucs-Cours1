using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptbronze : MonoBehaviour


    
{
    [SerializeField] GameObject _prefabOriginal;
    [SerializeField] Vector3 _positionCreation;




    // Start is called before the first frame update
    void Start()
    {
        _positionCreation = transform.position;



        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_prefabOriginal, _positionCreation, _rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
