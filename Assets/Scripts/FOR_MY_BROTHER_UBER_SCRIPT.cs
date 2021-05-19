using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOR_MY_BROTHER_UBER_SCRIPT : MonoBehaviour
{
    [SerializeField] private GameObject[] rendersObject;

    private int _iterator = 0;
    private int iterator
    {
        get { return _iterator; }
        set
        {
            _iterator = value;
            if (_iterator >= rendersObject.Length)
            {
                _iterator = 0;
            }
            else if (_iterator < 0)
            {
                _iterator = rendersObject.Length - 1;
            }
        }
    }

    private void Awake()
    {
        Clear();
        rendersObject[0].SetActive(true);
    }
    private void Clear()
    {
        for (int i = 0; i < rendersObject.Length; i++)
        {
            rendersObject[i].SetActive(false);
        }
    }
    public void Next()
    {
        iterator++;
        Clear();
        rendersObject[iterator].SetActive(true);
    }
    public void Previous()
    {
        iterator--;
        Clear();
        rendersObject[iterator].SetActive(true);
    }
}
