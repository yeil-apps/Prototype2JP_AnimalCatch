using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;

    [SerializeField] private int _amountToBeFed = 2;
    private int _currentFedAmount = 0;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = _amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);


        _gameManager = FindObjectOfType<GameManager>();

    }
    public void FeedAnimal(int amount)
    {
        _currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = _currentFedAmount;

        if (_currentFedAmount >= _amountToBeFed)
        {
            _gameManager.AddScore(_amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
