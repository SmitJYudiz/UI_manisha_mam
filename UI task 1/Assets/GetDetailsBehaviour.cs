using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Employee
{
    public string name;
    public empGenderType gender;
    public string address;
    public int id;
    public long contact;
    public string email;
    public empDesignationType designation;

    public enum empGenderType
    {
        Male,
        Female,
        Transgender        
    }

    public enum empDesignationType { 
        Trainee,
        Junior,
        Senior,
        TeamLeader
    }
}   

//[CreateAssetMenu(fileName = "employees", menuName = "GetDetailsBehaviour")]
public class GetDetailsBehaviour : ScriptableObject
{
    public List<Employee> employees = new List<Employee>();
}
 
