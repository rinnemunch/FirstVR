using UnityEngine;
using System.Collections.Generic;

public class StackZoneLogic : MonoBehaviour
{
    [SerializeField] private GameObject _winText;
    private readonly HashSet<GameObject> _stackedBlocks = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            _stackedBlocks.Add(other.gameObject);
            CheckWinCondition();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            _stackedBlocks.Remove(other.gameObject);
        }
    }

    private void CheckWinCondition()
    {
        if (_stackedBlocks.Count >= 3 && _winText != null)
        {
            _winText.SetActive(true);
        }
    }
}
