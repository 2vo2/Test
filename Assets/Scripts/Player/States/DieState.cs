using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DieState : State
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _slider;
    [SerializeField] private GameObject _enabledPanel;
    [SerializeField] private Backpack _backpack;
    [SerializeField] private int _sceneNumber;

    private void Update() 
    {
        Animator.SetBool("Dying", true);
        Rigidbody.isKinematic = true;
        _enabledPanel.SetActive(false);
        _slider.SetActive(false); 

        _button.interactable = true;
        _canvasGroup.alpha = 1;   
        
        _backpack.Die();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
