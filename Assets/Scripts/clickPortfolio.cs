using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class clickPortfolio : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    SpriteMask mask;
    [SerializeField] Sprite sprite;

    private void Start()
    {
        mask = GetComponent<SpriteMask>();
    }
    private void OnMouseDown()
    {
        if (canvas != null)
        {
            canvas.SetActive(true);
            print("print portfolio image");
        }

    }
}
