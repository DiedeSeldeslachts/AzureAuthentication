   M S B A M L   `   `   `  ����H  DOfficeWpfTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:OfficeWpfTest.ModelOfficeWpfTest.Model  5   	   7 clr-namespace:OfficeWpfTest.ViewOfficeWpfTest.View  5   	        OfficeWpfTest.View.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   3model!clr-namespace:OfficeWpfTest.Model     5   	   1view clr-namespace:OfficeWpfTest.View     5   	     � WindowStartupLocation$  CenterScreen=�5   .    � Title$ Example 2 - MVVM��5   	   $	��300��6"   $	��300��6/    � 	Resources 5       �� 
TargetType   MyMenuStyle �� Property �� Value��%�   &	        �� 5   
   " m�6   .�5	      ��  � �� 6'   �� *Header+�� 5
       � �� 6,   �� *
Children+�� 5       �@m�Command 6(   �� *	Command+5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��26* �6   .+�5   
   o� #��[  6/   ��6   �� *	TheMenu+6/   �� 5   
   $��Right=�65   ��6   �� *	SubView+65   �� 5   
   -   5         ��Name$ Stage��5      $��1��6    %   OfficeWpfTest.View.LoginControl  5   
   $��1��6   5      5      