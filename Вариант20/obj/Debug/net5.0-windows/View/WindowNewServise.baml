   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2.ViewWpfApp2.View  5   	   #    WpfApp2.View.WindowNewServise   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2.View     5   	     � Title$"  Добавление Servise��5   	   $	��450��6$   $	��800��61   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��80* �6   .+�5   
   �� $��0��6   $��0��6!   $	��ID:��5      $��Right=�6   $��Center=�5      $��5q�6(   �� 5   
   $��1��6   $��0��6!   $��Название:��5      $��Right=�6   $��Center=�5      $��5q�6(   �� 5    
   $��2��6   $��0��6!   $��	Цена:��5!      $��Right=�6   $��Center=�5"      $��5q�6(   �� 5'   
   -   5         ��Name$ WNPID��5'      $��0��6!   $��1��6.   $��20��5(   !   $��50��6-   $
��Left=�5)      $��Center=�6(   $��5q�5*      ${�False��6   ��5(      �� *ID+5*      �� 5.   
   -   5        $ WNPName��5.      $��1��6#   $��1��60   $��20��5/   (   $	��130��64   $
��Left=�50      $��Center=�6-   $��5q�51      ��5/      �� *Name+51      �� 52   
   -   5        $ WNPPrice��52      $��2��6$   $��1��61   $��20��53   )   $	��130��65   $
��Left=�54      $��Center=�6-   $��5q�55      ��53      �� *Price+55      �� 5;   
   $��0��6   $��2��6%   $��8��69    �� Orientation$ 
Horizontal=�5<      $��Right=�5=      .+�5>      �� -   5         ��Name$ 
Personsave��5>      $��Сохранить��6)   $��25��6=   $��Right=�5?      $	��Top=�61   $��	5,10,10,5q�5@      5A      �� 5B      -   5        $ PersonCansel��5B      $��Отменить��6+   $��25��6>   $��Right=�5C      $	��Top=�61   $��	5,10,10,5q�5D       �� IsCancel$
 True��6(   5E      5F      5G      