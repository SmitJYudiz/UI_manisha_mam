using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Text.RegularExpressions;

public class EmployeeManager : MonoBehaviour
{

    public InputField nameInput;
    public InputField idInput;
    public InputField contactInput;
    public InputField emailInput;
    public InputField addressInput;

    public Dropdown genderDropdown;
    public Dropdown designationDropdown;


    public GetDetailsBehaviour getDetails;

    // Start is called before the first frame update
    private void Start()
    {
        /*   GetDetailsBehaviour.employees.Add(new Employee() { address = "Ahmedabad", id = 1900, contact = 1111111111, email = "one@one.com", name = "one", gender = "Male", designation = "Trainee" });
           employees.Add(new Employee() { address = "Goa", id = 1901, contact = 1111112222, email = "two@two.com", name = "two", gender = "Female", designation = "Junior" });*/

    }

    public void Submit()
    {

        //  Debug.Log("the designation is: " + designationDropdown.options[designationDropdown.value].text+" and the gender is: "+ genderDropdown.options[genderDropdown.value].text);

        if (CheckIfDataNotEmpty())
        {
            Employee currentEmployee = new Employee();
            currentEmployee.name = nameInput.text;
            currentEmployee.gender = (Employee.empGenderType)genderDropdown.value;
            currentEmployee.designation = (Employee.empDesignationType)designationDropdown.value;
            currentEmployee.contact = long.Parse(contactInput.text);
            currentEmployee.email = emailInput.text;
            currentEmployee.id = int.Parse(idInput.text);
            currentEmployee.address = addressInput.text;

            getDetails.employees.Add(currentEmployee);
            //employees.Add(currentEmployee);

            EmptyAllInputFields();
        }


        //Debug.Log(Dropdown.options[Dropdown.value].text);
    }

    /*public List<Employee> GetEmployeesList()
    {
        return employees;
    }*/


    public bool CheckIfDataNotEmpty()
    {
        if (nameInput.text == "")
        {
            Debug.Log("please enter your name.");
            return false;
        }

        if (addressInput.text == "")
        {
            Debug.Log("please enter your address.");
            return false;
        }

        if (contactInput.text == "")
        {
            Debug.Log("please enter a 10 digit contact.");
            return false;
        }

        if (idInput.text == "")
        {
            Debug.Log("please enter an ID.");
            return false;
        }

        if (emailInput.text == "")
        {
            Debug.Log("please enter a valid email.");
            return false;
        }

        bool isEmail = Regex.IsMatch(emailInput.text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        if (isEmail == false)
        {
            Debug.Log("please enter valid Email address");
            return false;
        }
        return true;
    }

    public void EmptyAllInputFields()
    {
        nameInput.text = "";

        idInput.text = "";
        addressInput.text = "";

        contactInput.text = "";
        emailInput.text = "";
    }
}











