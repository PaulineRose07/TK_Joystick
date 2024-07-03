using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDDTestDriveDevJoystick : MonoBehaviour
{
    public Transform m_toTestAxis;

    public float m_joystickLeftX;
    public float m_joystickLeftY;
    public float m_joystickRightX;
    public float m_joystickRightY;


    public void SetJoystickLeftX(float _joystickLeftX) => m_joystickLeftX = _joystickLeftX;
    public void SetJoystickLeftY(float _joystickLeftY) => m_joystickLeftY = _joystickLeftY;
    public void SetJoystickRightX(float _joystickRightX) => m_joystickRightX = _joystickRightX;
    public void SetJoystickRightY(float _joystickRightY) => m_joystickRightY = _joystickRightY;

    private void Update()
    {
        m_toTestAxis.transform.localScale = new Vector3(0.5f + m_joystickLeftX, 0.5f + m_joystickLeftY, 0.5f + m_joystickRightX);
        m_toTestAxis.transform.localPosition = new Vector3(0,0.5f + m_joystickRightY,0);
    }


}
