using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class FixedButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;
    public UnityEvent onPressed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
        onPressed.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
