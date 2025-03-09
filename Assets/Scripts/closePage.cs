using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class closePage : MonoBehaviour
{
    [SerializeField] GameObject m_Canvas;
    public void _closePage()
    {
        if (m_Canvas != null)
        {
            m_Canvas.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
