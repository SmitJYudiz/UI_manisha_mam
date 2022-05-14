using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintDetails : MonoBehaviour
{
    public static PrintDetails Instance;
    //public Text nameOutput;

    public Text nameOut;
    public Text emailOut;
    public Text contactOut;
    public Text idOut;
    public Text genderOut;
    public Text designationOut;
    public Text addressOut;

    public GetDetailsBehaviour getDetailsBehaviour;

    private void Awake()
    {
        Instance = this;
    }
    
    public void SetDetails(Employee  employee)
    {
        nameOut.text = employee.name;
        //Debug.Log(nameOut.text);
        nameOut.text = employee.name;
        addressOut.text = employee.address;
        genderOut.text = employee.gender.ToString();
        emailOut.text = employee.email;
        contactOut.text = employee.contact.ToString();
        idOut.text = employee.id.ToString();
        designationOut.text = employee.designation.ToString();
    }

}
