   M S B A M L   `   `   `  ����G  CWPF.Overtime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF.OvertimeWPF.Overtime  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       WPF.Overtime.EmployeePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF.Overtime     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -   5          � Title$  EmployeePage��5	   	   $��624.342��6   $��893.997��6/   $��Center=�5
       $��Center=�6=    � 
ResizeMode$ NoResize=�6X    � WindowStartupLocation$ CenterScreen=�6n   .��5      � $��0,0,0,1q�6    � ColumnDefinitions 5   
   �� 5      $
��419* �6   �� 5      $	��43* �6   �� 5      $
��179* �6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��452��6@   $��
10,132,0,0q�6M   
���   �$	��Top=�6p   $	��868��6�   $��3��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ OvertimeEmployeeGrid��5         
IsReadOnly .    GridLinesVisibility$	 All=�6C   $��1q�6]      AutoGenerateColumns .  $
��Left=�6�   $��
20,185,0,0q�6�   $	��Top=�6�   $	��389��6�   $	��848��6�   $��3��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Check In��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6]      HeaderStringFormat$  ��6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Overtime.check_in+6g     5      $	 	Check Out��6%   $
 * 6_   $  ��6i    68   �� *Overtime.check_out+6i     5      $	 Hours��6%   $
 * 6\    64   �� *Overtime.difference+6\     5      $	 Overtime Salary��6%   $
 * 6k    6>   �� *Overtime.overtime_salary+6k     5      $	 Status��6%   $
 * 6Y    65   �� *approval_status+6Y   5      �� 5   
   -   5         ��Name$ LogoutButton��5      $��Log Out��6'   $
��Left=�69   $��
159,10,0,0q�6T   $	��Top=�6h   $��75��6�   $��2��6�   �� 5    
   -   5        $ ChangeButton��5       $��Change Password��6'   $
��Left=�6A   $��0,10,0,0q�6\   $	��Top=�6n   $	��143��6�   $��2��6�   �� 5!   
   -   5         ��Name$ 	SearchBox��5!      $��2��6S   $
��Left=�6�   $��23��6�   $��
39,145,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��98��6�   �� 5"   
   -   5         ��Name$ 
SeachCombo��5"      $
��Left=�6'   $��
29,145,0,0q�6B   $	��Top=�6V   $��65��6n   $��2��6y   $��26��6�   $��1��6�   .@�5#      �� $��01��6   $
��Left=�6(   $��50��6C   �� 5$      $��02��6   $
��Left=�6(   $��50��6C   �� 5%      $��03��6   $
��Left=�6(   $��50��6C   �� 5&      $��04��6   $
��Left=�6(   $��50��6C   �� 5'      $��05��6   $
��Left=�6(   $��50��6C   �� 5(      $��06��6   $
��Left=�6(   $��50��6C   �� 5)      $��07��6   $
��Left=�6(   $��50��6C   �� 5*      $��08��6   $
��Left=�6(   $��50��6C   �� 5+      $��09��6   $
��Left=�6(   $��50��6C   �� 5,      $��10��6   $
��Left=�6(   $��50��6C   �� 5-      $��11��6   $
��Left=�6(   $��50��6C   �� 5.      $��12��6   $
��Left=�6(   $��50��6C   5/      �� 50   
   -   5        $ SearchButton��50      $��Search��6'   $��2��68   $
��Left=�6H   $��153,145,0,0q�6c   $	��Top=�6x   $��75��6�   $��26��6�   6�   �� 51   
   -   5        $ ReasonTextBox��51      " �� VerticalScrollBarVisibility$ Visible=�6)   $
 Wrap=�6O    �� AcceptsReturn . $
��Left=�6x   $��61��6�   $��	12,55,0,0q�6�   $�� ��6�   $	��Top=�6�   $	��771��6�   $��3��6�   �� 52   
   -	   5        $ CheckOut��52      $��	Check OUT��6#   $��2��67   $
��Left=�6G   $��
159,55,0,0q�6b   $	��Top=�6v   $��75��6�   $��61��6�   54      55      