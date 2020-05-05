using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TouchControls : MonoBehaviour
{
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
        fpc.runAxis = js.Direction;
        fpc.jumpAxis = fb.Pressed;
        fpc.mouseLook.lookAxis = touch.TouchDist;
    }
}
