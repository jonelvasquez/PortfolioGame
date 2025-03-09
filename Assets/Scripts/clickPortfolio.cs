using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class clickPortfolio : MonoBehaviour
{
    [SerializeField] GameObject m_Canvas;
    [SerializeField] GameObject canvasRender;
    [SerializeField] Sprite replacement;
    Image m_Image;
    Sprite sprite;

    private void Start()
    {
        m_Image = canvasRender.GetComponent<Image>();
    }

    private void OnMouseDown()
    {
        if (m_Canvas != null)
        {
            Time.timeScale = 0f;
            m_Canvas.SetActive(true);
            m_Image.sprite = replacement;
            print("print portfolio image");
        }
    }
}
