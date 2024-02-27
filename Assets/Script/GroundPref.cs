using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPref : MonoBehaviour
{
    public int _index;
    public GameObject _cool;
    public List<GameObject> _cenList;
    public void CenarioSelect(int value)
    {
       // Shuffle(_cenList);

        _cenList[value].SetActive(true);
    }

    void Shuffle(List<GameObject> lists)
    {
        for (int j = lists.Count - 1; j > 0; j--)
        {
            int rnd = UnityEngine.Random.Range(0, j + 1);
            GameObject temp = lists[j];
            lists[j] = lists[rnd];
            lists[rnd] = temp;
        }
    }
}
