using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using PDC60_MOD02.Model;
using Xamarin.Forms;

namespace PDC60_MOD02.ViewModel
{
    class StudentInformationViewModel:INotifyPropertyChanged
    {
        public StudentInformation StudentInfo { get; set; }

        public Command CommandInformationUpdate { get; set; }


        public int sID { get; set; }
        public string sName { get; set; }
        public string yLevel { get; set; }
        public string sec { get; set; }
        public string cCode { get; set; }
        public string cour { get; set; }

        public StudentInformationViewModel()
        {
            CommandInformationUpdate = new Command(() =>
            {
                StudentInfo = new StudentInformation
                {
                    StudentID = sID,
                    StudentName = sName,
                    YearLevel = yLevel,
                    Section = sec,
                    CourseCode = cCode,
                    Course = cour
                };
                OnPropertyChanged(nameof(StudentInfo));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}