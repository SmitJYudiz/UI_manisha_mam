using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenBehaviour : MonoBehaviour
{
    public  List<Toggle> empTypes;
     List<Employee> selectedEmployees = new List<Employee>() ;
     List<EmpModel> employeesObjs = new List<EmpModel>();

     Employee.empDesignationType selectedEmpType;

    public GetDetailsBehaviour getDetails;
    public EmpModel empPrefab;
    public Transform content;

    private void Start()
    {
        foreach(Toggle toggle in empTypes)
        {
            toggle.onValueChanged.AddListener( OnValueChanged);
        }
        GenerateEmployeeObjs(10);
        empTypes[0].isOn = true;
    }

    void GenerateEmployeeObjs(int count)
    {
        for(int i =0;i< count; i++)
        {
            EmpModel empModel = Instantiate(empPrefab, content);
            employeesObjs.Add(empModel);
        }
    }

    public void OnValueChanged(bool value)
    {
        for (int i = 0; i < empTypes.Count; i++) { 
        if (empTypes[i].isOn)
            {
                selectedEmpType = (Employee.empDesignationType) i;
                FindEmployees(selectedEmpType);
                Debug.Log("OnValueChanged :::   " + selectedEmpType);

            }
        }
    }

    void FindEmployees(Employee.empDesignationType empType)
    {
        selectedEmployees =getDetails .employees.FindAll(x => x.designation == empType);
        //Debug.Log("count : " + selectedEmployees.Count);
        ShowEmployeeList();
    }

     public void ShowEmployeeList()
    {
        if (selectedEmployees.Count > employeesObjs.Count)
        {
            GenerateEmployeeObjs(selectedEmployees.Count - employeesObjs.Count);
        }
        int i = 0;
        foreach (EmpModel emp in employeesObjs)
        {
            if (i > selectedEmployees.Count - 1)
            {
                emp.gameObject.SetActive(false);

            }
            else { 
            emp.gameObject.SetActive(true);
            emp.SetData(selectedEmployees[i]);
         
        }
            i++;
        }
    }

 


    
}
