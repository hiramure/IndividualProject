using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;

namespace p4
{
    public partial class AddStudentWindowVM:ObservableObject

    {
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public BitmapImage selectedImage;

       
        public Students User { get; private set; }

        

        public AddStudentWindowVM(Students s)
        {
            User=s;
            firstname=User.FirstName;
            lastname=User.LastName;
            dateofbirth = User.DateOfBirth;
            gpa = User.GPA;
            selectedImage = User.Image;
        }

        public AddStudentWindowVM()
        {

        }
        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog=new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage=new BitmapImage(new Uri(dialog.FileName));
                MessageBox.Show("Image successfully uploaded!", "Successfull");
            }
        }



        
        public Action CloseAction { get; internal set;}

        [RelayCommand]
        public void Save()
        {
            if(gpa<0|| gpa > 4)
            {
                MessageBox.Show("GPA should be between 0 and 4","Error");
                return;
            }
            if (User == null)
            {
                User = new Students()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    DateOfBirth = dateofbirth,
                    Image = selectedImage,
                    GPA = gpa
                };


            }
            else
            {
                User.FirstName = firstname;
                User.LastName = lastname;
                User.DateOfBirth = dateofbirth;
                User.GPA = gpa;
                User.Image= selectedImage;
            }

            if (User.FirstName != null)
            {
                CloseAction();
            }
            Application.Current.MainWindow.Show();
        }
    }

}
