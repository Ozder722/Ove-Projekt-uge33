using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GameManager.instance.StartGame();
    }
}
