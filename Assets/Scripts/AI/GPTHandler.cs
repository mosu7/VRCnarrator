using UdonSharp;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class GPTHandler : UdonSharpBehaviour
{

    // privat Button submitButton;
    // public GameObject target;

    void Start()
    {
        // Since we can't use AddListener, we will call a method on button click
        // submitButton = transform.GetComponent<Button>();
    }

    public void ObjectToggle()
    {
        // target.SetActive(!target.activeInHierachy);
    }
}
