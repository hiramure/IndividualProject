   M S B A M L   `   `   `  ����=  9p4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:p4p4  5   	       p4.AddStudentWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:p4     5   	   $	��550��5   	   $	��800��6   
������   � AllowsTransparency$
  True��5
   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title 5   	   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=� � DataContext 5         p4.AddStudentWindowVM  5   
   .��5      ��  �� CornerRadius$ 30��6   ��5   
   �� 5       �� ImageSource$� �E:\ACADEMIC\3SEMESTER\MODULES\GUI\MyWork\p4\p4\Images\pngtree-graduation-season-student-back-black-and-white-background-picture-image_2150094.jpg��6    j� Stretch$ UniformToFill=�6�   ._�5   
   �� $ 30��6   $��5q�6#   	 J� Opacity$
	 0.95Q�67   ��5      �� 5      
 �� 
StartPoint$	
 1,1&�6&    �� EndPoint$	 0,0&�67   .��5      �  � Color$ #5E5A80��6#    � Offset$	 0.1Q�63   � 5      $ #4E5180��6#   $	 0.5Q�63   � 5      $ #5E5A80��6#   $	 0.9Q�63   5      ��5!      �� 5"      $	
 0 0&�6&   $
 1 1 &�67   .��5#      � $ #462AD8��6#   $ 0Q�63   � 5$      $ #6A1B9A��6#   $
 0.75Q�63   � 5%      $ #8A16C1��6#   $ 1Q�63   5&      ._�5(      �  � RowDefinitions 5)      �� 5*      $��50 �6$   �� 5+      .+�5-      �  � ColumnDefinitions 5.      �� 5/      �� 50      $��25 �6+   �� 51      $��25 �6+   �� 52      $��40 �6+   .+�54      �� -   5        $��-��54       	  btn02#��[  6)   $��1��6H   6X   �� 55      -   5        $��X��55      #��[  6)   $��2��6H   6X   56      � 58      $��1��6   .+�59      �� .+�5:      �� $��
First Name��6$    	 txt01#��[ 66   �� 5;        txtbox01#��[ 6"   ��6D   �� *	Firstname+$ PropertyChanged=��� 5<      $��	Last Name��6$   #��[ 65   �� 5=      #��[ 6"   ��6D   �� *
Lastname+$ PropertyChanged=��� 5>      $��Date of Birth��6$   #��[ 69   �� 5?      #��[ 6"   ��6D   �� *Dateofbirth+$ PropertyChanged=��� 5@      $	��GPA��6$   #��[ 6/   �� 5A      #��[ 6"   ��6D   �� *Gpa+$ PropertyChanged=��� 5B      $��Image��6$   #��[ 61   �� 5D      $��Insert Image��6!    	 btn04#��[ 69   ��6X   �� *UploadPhotoCommand+�� 5E      $��40��6    $
��Left=�6,   $	��100��6G   $	��Top=�6S   $��
120 12 0 0q�6k   ��6   �� *SelectedImage+$ PropertyChanged=��� 5H      $
��Save��6!    	 btn03#��[ 60   ��6O   �� *SaveCommand+5I      5K      5M      5N      5P      5Q      