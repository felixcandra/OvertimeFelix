   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CWPF.Overtime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Bootcamp.OvertimeBootcamp.Overtime 5   	   +   %Bootcamp.Overtime.PopUpInsertEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   1localclr-namespace:Bootcamp.Overtime     5   	   -   5          � Title$  Insert Employee��5	   	   $��425.241��6!   $��521.113��62    � 
ResizeMode$ NoResize=�5
   "    � WindowStartupLocation$ CenterScreen=�68   .��5      � $��0,0,0,2q�6   .+�5   
   �� -   5         ��Name$ Username��5      $��Username��6"   $
��Left=�65   $	��Top=�6P   $��	26,24,0,0q�6h   �� 5   
   -   5         ��Name$ UsernameTextbox��5       �� 	MaxLength$ 15��6+   $
��Left=�6:   $��23��6U   $��
102,24,0,0q�6a    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��145��6�   �� 5   
   -   5        $ Password��5      $��Password��6"   $
��Left=�65   $	��Top=�6P   $��
267,24,0,0q�6h   �� 5   
   -   5        $ PasswordTextbox��5      $ 16��6+   $
��Left=�6:   $��23��6U   $��
338,24,0,0q�6a   $
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��145��6�   �� 5   
   -   5        $ 	FirstName��5      $��
First Name��6#   $
��Left=�68   $	��Top=�6S   $��	26,55,0,0q�6k   �� 5   
   -   5        $ FirstNameTextbox��5      $
��Left=�6a   $��23��6|   $��
102,55,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��145��6�   �� 5   
   -   5        $ LastName��5      $��	Last Name��6"   $
��Left=�66   $	��Top=�6Q   $��
267,55,0,0q�6i   �� 5   
   -	   5        $ LastNameTextbox��5      $
��Left=�6_   $��23��6z   $��
338,55,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��145��6�   �� 5   
   -
   5        $ Address��5      $��Address��6!   $
��Left=�63   $	��Top=�6N   $��	26,86,0,0q�6f   �� 5   
   -   5        $ AddressTextbox��5      $
��Left=�6*   $��23��6E   $��
102,86,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��381��6�   �� 5   
   -   5        $ SubDistrict��5      $��Sub District��6%   $
��Left=�6<   $	��Top=�6W   $��
26,148,0,0q�6o   �� 5   
   -   5        $ SubDistrictTextbox��5      $
��Left=�6e   $��23��6�   $��102,148,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��381��6�   �� 5   
   -   5        $ District��5      $��District��6"   $
��Left=�65   $	��Top=�6P   $��
26,117,0,0q�6h   �� 5   
   -   5        $ DistrictTextbox��5      $
��Left=�6_   $��23��6z   $��102,117,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��381��6�   �� 5   
   -   5        $ Province��5      $��Province��6"   $
��Left=�65   $	��Top=�6P   $��
26,179,0,0q�6h   �� 5   
   -   5        $ ProvinceTextbox��5      $
��Left=�6_   $��23��6z   $��102,179,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��381��6�   �� 5   
   -   5        $ 
PostalCode��5      $��Postal Code��6$   $
��Left=�6:   $	��Top=�6U   $��
24,241,0,0q�6m   �� 5   
   -   5        $ PostalTextbox��5      $ 5��6)   $
��Left=�6i   $��23��6�   $��102,241,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��381��6�   �� 5   
   -   5        $ Salary��5      $��Salary��6    $
��Left=�61   $	��Top=�6L   $��
26,272,0,0q�6d   �� 5    
   -   5        $ SalaryTextbox��5       $
��Left=�6[   $��23��6v   $��102,272,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��381��6�   �� 5!   
   -   5        $ Phone��5!      $��Phone��6   $
��Left=�6/   $	��Top=�6J   $��
26,210,0,0q�6b   �� 5"   
   -   5        $ PhoneTextbox��5"      $ 13��6(   $
��Left=�6h   $��23��6�   $��102,210,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��381��6�   �� 5#   
   -   5        $ SubDistrict_Copy2��5#      $��Position��6+   $
��Left=�6>   $	��Top=�6Y   $��
26,303,0,0q�6q   �� 5$   
   -   5         ��Name$ PositionCombo��5$      $
��Left=�6*   $	��Top=�6E   $	��381��6]   $��102,303,0,0q�6i    �� DisplayMemberPath$
 name��6~   	 �� SelectedValuePath$	 Id��6�   �� 5%   
   -   5        
 ��Name$
 
SaveButton��5%      $
��Save��6%   $
��Left=�64   $	��Top=�6O   $	��111��6g   $��372,342,0,0q�6s   $��40��6�   6�   �� 5&   
   -   5        $
 CancelButton��5&      $��Cancel��6'   $
��Left=�68   $��241,342,0,0q�6S   $	��Top=�6h   $	��101��6�   $��40��6�   6�   5(      5)      