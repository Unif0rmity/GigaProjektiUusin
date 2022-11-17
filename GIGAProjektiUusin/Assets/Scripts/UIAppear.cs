using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField]
    private Image bookImage;
    public GameObject book;

    void OnMouseDown()
    {
        book.SetActive(false);
        bookImage.enabled = true;

    }

    void OnMouseUp()
    {
        book.SetActive(true);
        bookImage.enabled = false;
    }

}
