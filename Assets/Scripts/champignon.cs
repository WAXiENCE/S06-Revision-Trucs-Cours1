using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class champignon : MonoBehaviour
{


    [SerializeField] GameObject _champignon;
    [SerializeField] GameObject _drapeauPosition;
    [SerializeField] GameObject _boitePosition;
    [SerializeField] Vector3 _drapeau;
    [SerializeField] Vector3 _boite;

    // Start is called before the first frame update
    void Start()
    {
        _drapeau = _drapeauPosition.transform.position;
        _boite = _boitePosition.transform.position;





        float positionAleatoire = Random.value;
        Quaternion _rotation = Quaternion.Euler(0f, 0f, 0f);

        if (positionAleatoire < 0.5f)
        {
            Instantiate(_champignon, _drapeau, _rotation);
        }
        else {
            Instantiate(_champignon, _boite, _rotation);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
