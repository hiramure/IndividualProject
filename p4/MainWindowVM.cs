using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace p4
{
    public partial class MainWindowVM:ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Students> student;
        [ObservableProperty]
        public Students selectedStudent =null;

      /*  public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }*/


        [RelayCommand]
        public void message()
        {
            MessageBox.Show($"{selectedStudent.FirstName} GPA value should be between 0 and 4.", "Error");

        }
        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddStudentWindowVM();
            vm.title = "ADD USER";
            AddStudentWindow window = new AddStudentWindow(vm);
            window.ShowDialog();

            if (vm.User.FirstName != null)
            {
                student.Add(vm.User);
            }
        }


        [RelayCommand]

        public void Delete()
        {
            if (selectedStudent != null)
            {
                string name = selectedStudent.FirstName;
                student.Remove(selectedStudent);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETEED \a");

            }
            else
            {
                MessageBox.Show("Please select a student before delete.", "Error");
            }
        }

        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if(selectedStudent!= null)
            {
                var vm = new AddStudentWindowVM(selectedStudent);
                vm.title = "EDIT USEER";
                var window = new AddStudentWindow(vm);  

                window.ShowDialog();

                int index = student.IndexOf(selectedStudent);
                student.RemoveAt(index);
                student.Insert(index, vm.User);
            }
            else
            {
                MessageBox.Show("Please select a student before add.", "ERROR");
            }
        }



       



        public MainWindowVM()
        {
            student = new ObservableCollection<Students>();
            BitmapImage image1 = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
            student.Add(new Students("Nan", "Ann", image1,"02/11/1999",3));

            BitmapImage image2 = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative));
            student.Add(new Students( "Nan", "Ann", image2, "02/11/1999", 3));

            BitmapImage image3 = new BitmapImage(new Uri("/Images/3.png", UriKind.Relative));
            student.Add(new Students( "Nan", "Ann", image3, "02/11/1999", 3));
        }


        



    }
}
