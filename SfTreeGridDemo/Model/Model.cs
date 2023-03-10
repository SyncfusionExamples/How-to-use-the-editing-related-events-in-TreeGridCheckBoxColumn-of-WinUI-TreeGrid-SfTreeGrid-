using System;
using System.ComponentModel;

namespace SfTreeGridDemo
{
    public class EmployeeInfo : INotifyPropertyChanged
    {
        int _id;
        string _firstName;
        string _lastName;
        string _title;
        double? _salary;
        int _reportsTo;
        DateTimeOffset _date;
        DateTimeOffset _time;
        bool _availability;
        string _city;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged("FirstName"); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged("LastName"); }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; RaisePropertyChanged("ID"); }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged("Title"); }
        }

        public DateTimeOffset Date
        {
            get { return _date; }
            set { _date = value; RaisePropertyChanged("Date"); }
        }

        public DateTimeOffset Time
        {
            get { return _time; }
            set { _time = value; RaisePropertyChanged("Time"); }
        }

        public bool Availability
        {
            get { return _availability; }
            set { _availability = value; RaisePropertyChanged("Availability"); }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; RaisePropertyChanged("City"); }
        }

        public double? Salary
        {
            get { return _salary; }
            set { _salary = value; RaisePropertyChanged("Salary"); }
        }

        public int ReportsTo
        {
            get { return _reportsTo; }
            set { _reportsTo = value; RaisePropertyChanged("ReportsTo"); }
        }

        public EmployeeInfo()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}