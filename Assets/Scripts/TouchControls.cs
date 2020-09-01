using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TouchControls : MonoBehaviour
{
    public bool on;
    public FixedJoystick js;
    public FixedButton fb;
    public FixedTouchField touch;
    public RigidbodyFirstPersonController fpc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            fpc.runAxis = js.Direction;
        }
        else
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            fpc.runAxis = new Vector2(x,y);
        }
        fpc.jumpAxis = fb.Pressed;
        fpc.mouseLook.lookAxis = touch.TouchDist;
    }
}
