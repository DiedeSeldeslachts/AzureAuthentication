   M S B A M L   `   `   `  ����H  DOfficeWpfTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:OfficeWpfTestOfficeWpfTest  5   	       OfficeWpfTest.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:OfficeWpfTest     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $	��26* �6   .+�5   
   o� .@�5      m� -   5        $��Log out��5      6(   m� 5      $��Option 2��6   .@�5      m� -   5        $��Load new control��5      65   m� 5      -   5        $��Open new window��5      64   5      5      �� 5   
   -   5         ��Name$ Stage��5      $��1��6    � 5   
   -   5         �Name$ 
LoginLayer��5      ���	#FFFFFFFF$��2��6:   .+�5      � $��Center=�6   $��Center=�60   
����ح� � ColumnDefinitions 5      �� 5      �� 5       5      �� 5      �� 5      �� 5      �� 5       .+�5"      �� $��Log in��6   $��2��6*   $
��Bold"�6>   $��Center=�6P   $��5q�6m   $��20(�6x   �� 5#      $
��Name��6   $��1��6(   $��3q�65   �� 5$      -   5         ��Name$ txtName��5$      $��1��6+   $��1��68   $��3q�6H   $	��100��6S   $
��Left=�6b   �� 5%      $��Password��6   $��2��6,   $��3q�69   G� 5&      -   5         G�Name$ txtPassword��5&      $��1��64   $��2��6D   $��3q�6Q   $	��100��6\   $
��Left=�6k   �� 5'      -   5        $��Log in��5'   -   $��3��6>   $��1��6K   $��3q�6[   5(      5)      5*      5+      