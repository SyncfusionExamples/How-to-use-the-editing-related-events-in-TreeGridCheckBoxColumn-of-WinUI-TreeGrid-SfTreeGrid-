using System;
using System.Collections.ObjectModel;

namespace SfTreeGridDemo
{
    public class ViewModel
    {
        public ViewModel()
        {
            _employees = new ObservableCollection<EmployeeInfo>();
            this.Employees = this.GetEmployees();           
        }

        private ObservableCollection<EmployeeInfo> _employees;       

        public ObservableCollection<EmployeeInfo> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }
       
        private ObservableCollection<EmployeeInfo> GetEmployees()
        {            
            _employees.Add(new EmployeeInfo() { FirstName = "Ferando", LastName = "Joseph", Title = "Management", Salary = 2000000, ReportsTo = -1, ID = 2, Availability=true, City="India", Date= new DateTimeOffset(new DateTime(2021,6,17,10,2,1)), Time= new DateTimeOffset(new DateTime(2022, 6, 17, 12, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "John", LastName = "Adams", Title = "Accounts", Salary = 2000000, ReportsTo = -1, ID = 3, Availability = false, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 7, 15, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 22, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Thomas", LastName = "Jefferson", Title = "Sales", Salary = 300000, ReportsTo = -1, ID = 4, Availability = false, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 1, 04, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 3, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Andrew", LastName = "Madison", Title = "Marketing", Salary = 4000000, ReportsTo = -1, ID = 5, Availability = true, City = "US", Date = new DateTimeOffset(new DateTime(2021, 9, 01, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 4, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Ulysses", LastName = "Pierce", Title = "HumanResource", Salary = 1500000, ReportsTo = -1, ID = 6, Availability = true, City = "Singapore", Date = new DateTimeOffset(new DateTime(2021, 11,21, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 5, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Jimmy", LastName = "Harrison", Title = "Purchasing", Salary = 200000, ReportsTo = -1, ID = 7, Availability = false, City = "China", Date = new DateTimeOffset(new DateTime(2021, 12, 21, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 6, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Ronald", LastName = "Fillmore", Title = "Production", Salary = 2800000, ReportsTo = -1, ID = 8, Availability = true, City = "India", Date = new DateTimeOffset(new DateTime(2021, 3, 16, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 7, 2, 1)) });
            //Management

            _employees.Add(new EmployeeInfo() { FirstName = "Andrew", LastName = "Fuller", ID = 9, Salary = 1200000, ReportsTo = 2, Title = "Vice President", Availability = true, City = "India", Date = new DateTimeOffset(new DateTime(2021, 9, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 8, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Janet", LastName = "Leverling", ID = 10, Salary = 1000000, ReportsTo = 2, Title = "GM", Availability = true, City = "India", Date = new DateTimeOffset(new DateTime(2021, 7, 6, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 9, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Steven", LastName = "Buchanan", ID = 11, Salary = 900000, ReportsTo = 2, Title = "Manager", Availability = true, City = "India", Date = new DateTimeOffset(new DateTime(2021, 8, 13, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 10, 2, 1)) });

            //Accounts
            _employees.Add(new EmployeeInfo() { FirstName = "Nancy", LastName = "Davolio", ID = 12, Salary = 850000, ReportsTo = 3, Title = "Accounts Manager", Availability = false, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 4, 22, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 11, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Margaret", LastName = "Peacock", ID = 13, Salary = 700000, ReportsTo = 3, Title = "Accountant", Availability = false, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 6, 12, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 12, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Michael", LastName = "Suyama", ID = 14, Salary = 700000, ReportsTo = 3, Title = "Accountant", Availability = false, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 9, 24, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 13, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Robert", LastName = "King", ID = 15, Salary = 650000, ReportsTo = 3, Title = "Accountant", Availability = false, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 8, 14, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 14, 2, 1)) });

            //Sales
            _employees.Add(new EmployeeInfo() { FirstName = "Laura", LastName = "Callahan", ID = 16, Salary = 900000, ReportsTo = 4, Title = "Sales Manager", Availability = false, City = "US", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 15, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Anne", LastName = "Dodsworth", ID = 17, Salary = 800000, ReportsTo = 4, Title = "Sales Representative", Availability = false, City = "US", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 16, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Albert", LastName = "Hellstern", ID = 18, Salary = 750000, ReportsTo = 4, Title = "Sales Representative", Availability = false, City = "US", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 17, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Tim", LastName = "Smith", ID = 19, Salary = 700000, ReportsTo = 4, Title = "Sales Representative", Availability = false, City = "US", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 18, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Justin", LastName = "Brid", ID = 20, Salary = 700000, ReportsTo = 4, Title = "Sales Representative", Availability = false, City = "US", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 19, 2, 1)) });

            //Back Office
            _employees.Add(new EmployeeInfo() { FirstName = "Caroline", LastName = "Patterson", ID = 21, Salary = 800000, ReportsTo = 5, Title = "Receptionist", Availability = true, City = "Singapore", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 20, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Xavier", LastName = "Martin", ID = 22, Salary = 700000, ReportsTo = 5, Title = "Mail Clerk", Availability = true, City = "India", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 21, 2, 1)) });

            //HR
            _employees.Add(new EmployeeInfo() { FirstName = "Laurent", LastName = "Pereira", ID = 23, Salary = 900000, ReportsTo = 6, Title = "HR Manager", Availability = true, City = "India", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 22, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Syed", LastName = "Abbas", ID = 24, Salary = 650000, ReportsTo = 6, Title = "HR Assistant", Availability = false, City = "China", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 23, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Amy", LastName = "Alberts", ID = 25, Salary = 650000, ReportsTo = 6, Title = "HR Assistant", Availability = false, City = "India", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 1, 2, 1)) });

            //Purchasing

            _employees.Add(new EmployeeInfo() { FirstName = "Pamela", LastName = "Ansman-Wolfe", ID = 26, Salary = 600000, ReportsTo = 7, Title = "Purchase Manager", Availability = true, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 1, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Michael", LastName = "Blythe", ID = 27, Salary = 550000, ReportsTo = 7, Title = "Store Keeper", Availability = true, City = "US", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 1, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "David", LastName = "Campbell", ID = 28, Salary = 450000, ReportsTo = 7, Title = "Store Keeper", Availability = false, City = "Singapore", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 1, 2, 1)) });

            //Production
            _employees.Add(new EmployeeInfo() { FirstName = "Jillian", LastName = "Carson", ID = 29, Salary = 600000, ReportsTo = 8, Title = "Production Manager", Availability = true, City = "UK", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 1, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Shu", LastName = "Ito", ID = 30, Salary = 550000, ReportsTo = 8, Title = "Production Engineer", Availability = false, City = "US", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 1, 2, 1)) });
            _employees.Add(new EmployeeInfo() { FirstName = "Stephen", LastName = "Jiang", ID = 31, Salary = 450000, ReportsTo = 8, Title = "Production Engineer", Availability = true, City = "India", Date = new DateTimeOffset(new DateTime(2021, 4, 11, 10, 2, 1)), Time = new DateTimeOffset(new DateTime(2022, 6, 17, 1, 2, 1)) });

            return _employees;
        }
    }
}