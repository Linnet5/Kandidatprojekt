using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject otherCanvas;
    public void ChangeCanvas(GameObject otherCanvas)
    {
        otherCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
}
