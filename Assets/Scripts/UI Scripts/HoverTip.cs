using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Button level2Button;
    [SerializeField] Button level3Button;

    public string tipToShow;
    private float timeToWait = 0.3f;
    public int coinMinLimit;

    public void OnPointerEnter(PointerEventData eventData)
    {   
        if(gameManager.totalCoins < coinMinLimit)
        {
        StopAllCoroutines();
        StartCoroutine(StartTimer());        
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        HoverManager.OnMouseLoseFocus();
    }

    private void ShowMessage()
    {
        HoverManager.OnMouseHover(tipToShow, Input.mousePosition);
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(timeToWait);

        ShowMessage();
    }
}
