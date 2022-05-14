using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EmpModel : MonoBehaviour
{
    public  Employee employee;
    public Text nameTxt;
    public void SetData(Employee _employee)
    {
        employee = _employee;
        nameTxt.text = employee.name;
    }
    public void OnButtonClick()
    {
     //   employee = GetComponentInParent<Employee>();
        ScreenManager.Instance.personDetailsScreen.SetActive(true);
        PrintDetails.Instance.SetDetails(employee);
        ScreenManager.Instance.homeScreen.SetActive(false);
        ScreenManager.Instance.registerScreen.SetActive(false);      
    }

    public void GoToRegisterScreen()
    {
        ScreenManager.Instance.registerScreen.SetActive(true);
        ScreenManager.Instance.personDetailsScreen.SetActive(false);      
        ScreenManager.Instance.homeScreen.SetActive(false);    
    }

    public void BackToHomePage()
    {
        ScreenManager.Instance.registerScreen.SetActive(false);
        ScreenManager.Instance.personDetailsScreen.SetActive(false);
        ScreenManager.Instance.homeScreen.SetActive(true);
    }
}
