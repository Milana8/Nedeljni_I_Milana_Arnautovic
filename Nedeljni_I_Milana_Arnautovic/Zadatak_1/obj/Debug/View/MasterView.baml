   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Zadatak_1.View.MasterView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MasterView��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      �� 5   
    �� Type" ��6      Key
Gender  .s�5      ��M��6   ��5      F��6   ��5      O��6   ��5      X��6   5      �� 5   
   " ��6   Marrige  .s�5      ��	Unmarried��6$   ��5      Married��6"   ��5      Divorced��6#   5      �� 5   
   " ��6   AdministratorType  .s�5      ��Team��6   ��5      
System��6!   ��5      	Local��6    5      .��5      � .+�5   
   �� -   5        $��lblFirstName��5      $��
FirstName:��5      $
��Left=�5      $	��Top=�5       $��	50,10,0,0q�5!      $��88��5"      �� 5#   
   -   5        $��
lblSurname��5$      $��Surname:��5#      $
��Left=�5%      $	��Top=�5&      $��	50,41,0,0q�5'      $��88��5(      �� 5)   
   -   5        $��lblJMBG��5*      $��JMBG:��5)      $
��Left=�5+      $	��Top=�5,      $��	50,72,0,0q�5-      $��88��5.      �� 5/   
   -   5        $��	lblGender��50      $��Gender:��5/      $
��Left=�51      $	��Top=�52      $��
50,103,0,0q�53      $��88��54      �� 55   
   -   5        $��lblResidence��56      $��
Residence:��55      $
��Left=�57      $	��Top=�58      $��
50,134,0,0q�59      $��88��5:      �� 5;   
   -   5        $��lblMariageStatus��5<      $��MarriageStatus:��5;      $
��Left=�5=      $	��Top=�5>      $��
50,165,0,0q�5?      $	��103��5@      �� 5A   
   -   5        $��lblUsername��5B      $��	Username:��5A      $
��Left=�5C      $	��Top=�5D      $��
50,196,0,0q�5E      $��88��5F       J� RenderTransformOrigin$ 0.518,3.875&�6   �� 5G   
   -   5        $��
lblPasword��5H      $��Pasword:��5G      $
��Left=�5I      $	��Top=�5J      $��
50,227,0,0q�5K      $��88��5L      �� 5N   
   -	   5        $��lblAdministratorType��5O      $��AdministratorType:��5N      $
��Left=�5P      $	��Top=�5Q      $��
50,258,0,0q�5R      $	��126��5S      �� 5T   
   $
��Left=�6   $��23��5U       �� TextWrapping$
 Wrap=�5V      $	��Top=�5W      $	��120��5X      $��
205,13,0,0q�5Y      ��5Z      �� *Administrator.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5[   
   $
��Left=�6   $��23��5\      $
 Wrap=�5]      $	��Top=�5^      $	��120��5_      $��
205,44,0,0q�5`      ��5a      �� *Administrator.Surname+$ PropertyChanged=��� 5b   
   $
��Left=�6   $��23��5c      $
 Wrap=�5d      $	��Top=�5e      $	��120��5f      $��
205,75,0,0q�5g      ��5h      �� *Administrator.JMBG+$ PropertyChanged=��� 5i   
   $
��Left=�6   $��23��5j      $	��Top=�5k      $	��120��5l      $��205,106,0,0q�5m       
 Gender#��[ 5n       �� SelectedItem 5o      �� *Administrator.Gender+$ PropertyChanged=�5p      �� 5q   
   $
��Left=�6   $��23��5r      $
 Wrap=�5s      $	��Top=�5t      $	��120��5u      $��205,137,0,0q�5v      ��5w      �� *Administrator.Residence+$ PropertyChanged=��� 5y   
   $
��Left=�6   $��23��5z      $	��Top=�5{      $	��120��5|      $��205,168,0,0q�5}        Marrige#��[ 5~       5      �� *Administrator.MarriageStatus+$ PropertyChanged=�5�      �� 5�   
   $
��Left=�6   $��23��5�      $
 Wrap=�5�      $	��Top=�5�      $	��120��5�      $��205,199,0,0q�5�      ��5�      �� *Administrator.Username+$ PropertyChanged=��� 5�   
   $
��Left=�6   $��23��5�      $
 Wrap=�5�      $	��Top=�5�      $	��120��5�      $��205,230,0,0q�5�      ��5�      �� *Administrator.Pasword+$ PropertyChanged=��� 5�   
   $
��Left=�6   $��23��5�      $	��Top=�5�      $	��120��5�      $��205,260,0,0q�5�        AdministratorType#��[ 5�       5�      �� *!Administrator.AdministratorType+$ PropertyChanged=�5�      �� 5�   
   $
��Save��6   $
��Left=�5�      $	��Top=�5�      $��89��5�      $��156,360,0,0q�5�      $��34��5�   N   ��6   �� *Save+$ PropertyChanged=�6N   �� 5�   
   $��317,360,380.6,26q�6   ��5�      �� *Cancel+.��6,   Cancel64   5�      5�      