using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryResultUI : MonoBehaviour
{
    private const string POPUP = "Popup";

    [SerializeField] private Image backgroundImage;
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private Image iconImage;
    [SerializeField] private Color successColor;
    [SerializeField] private Color failedColor;
    [SerializeField] private Sprite successSprite;
    [SerializeField] private Sprite failedSprite;

    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }

    private void Start()
    {
        DeliveryManager.Instance.OnRecipeSuccess += DeliveryManager_OnRecipeSuccess;
        DeliveryManager.Instance.OnRecipeFailed += DeliveryManager_OnRecipeFailed;

        Hide();
    }

    private void DeliveryManager_OnRecipeFailed(object sender, System.EventArgs e)
    {
        Show();
        animator.SetTrigger(POPUP);
        backgroundImage.color = failedColor;
        messageText.text = "DELIVERY\nFAILED";
        iconImage.sprite = failedSprite;
    }

    private void DeliveryManager_OnRecipeSuccess(object sender, System.EventArgs e)
    {
        Show();
        animator.SetTrigger(POPUP);
        backgroundImage.color = successColor;
        messageText.text = "DELIVERY\nSUCCESS";
        iconImage.sprite = successSprite;
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
