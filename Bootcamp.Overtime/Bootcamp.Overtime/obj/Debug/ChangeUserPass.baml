   M S B A M L   `   `   `  ����G  CWPF.Overtime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF.OvertimeWPF.Overtime  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   
   !    WPF.Overtime.ChangeUserPass   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF.Overtime     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   
   -   5          � Title$  Change Password��5	   	   $��526.531��6!   $��453.978��62    � WindowStartupLocation$ CenterScreen=�5
        � 
ResizeMode$ NoResize=�6E   .��5      � .+�5   
   �� ���#FFFFFF$
��Left=�6#   $	��271��6>   $��
10,217,0,0q�6K   
���   �$	��Top=�6n   $	��428��6�   �� 5   
   ���#FFFFFF$
��Left=�6#   $	��146��6>   $��	10,36,0,0q�6K   
���   �$	��Top=�6m   $	��428��6�   �� 5   
   -   5         ��Name$ 
SaveButton��5      $
��Save��6%   $
��Left=�64   $��141,130,0,0q�6O   $	��Top=�6d   $	��288��6|   $��36��6�   6�   G� 5   
   -   5         G�Name$ PassTextBox��5      $
��Left=�6[   $��
141,53,0,0q�6v   $	��Top=�6�   $	��288��6�   G� 5   
   -   5        $ PassConfirm��5      $
��Left=�6[   $��
141,84,0,0q�6v   $	��Top=�6�   $	��288��6�   �� 5   
   -   5         ��Name$ NewCombobox��5      $
��Left=�6(   $��
20,359,0,0q�6C   $	��Top=�6W   $	��409��6o   .@�5      �� $)��#What is the name of your first pet?��6   $
��Left=�6I   $	��409��6d   $��0,0,-2,0q�6p   �� 5      $-��'What is the name of your favorite book?��6   $
��Left=�6M   $	��409��6h   $��0,0,-2,0q�6t   �� 5      $6��0What is the last name of your favorite musician?��6   $
��Left=�6V   $	��405��6q   �� 5      $4��.Who is your all-time favorite movie character?��6   $
��Left=�6T   $	��408��6o   $��0,0,-1,0q�6{   �� 5      $4��.What is the name of your favorite sports team?��6   $
��Left=�6T   $	��406��6o   �� 5      $6��0What was the last name of your favorite teacher?��6   $
��Left=�6V   $	��407��6q   �� 5      $;��5What was the last name of your best childhood friend?��6   $
��Left=�6[   $	��406��6v   �� 5      $-��'What was your favorite food as a child?��6   $
��Left=�6M   $	��405��6h   �� 5      $"��Who was your childhood hero?��6   $
��Left=�6B   $	��406��6]   �� 5      $3��-Where was your best family vacation as a kid?��6   $
��Left=�6S   $	��406��6n   �� 5      $C��=When you were young,what did you want to be when you grew up?��6   $
��Left=�6c   $	��407��6~   5      �� 5    
   -   5        $ OldCombobox��5       $
��Left=�6(   $��
20,262,0,0q�6C   $	��Top=�6W   $	��409��6o   .@�5!      �� $)��#What is the name of your first pet?��6   $
��Left=�6I   $	��409��6d   $��0,0,-2,0q�6p   �� 5"      $-��'What is the name of your favorite book?��6   $
��Left=�6M   $	��409��6h   $��0,0,-2,0q�6t   �� 5#      $6��0What is the last name of your favorite musician?��6   $
��Left=�6V   $	��407��6q   �� 5$      $4��.Who is your all-time favorite movie character?��6   $
��Left=�6T   $	��408��6o   $��0,0,-1,0q�6{   �� 5%      $4��.What is the name of your favorite sports team?��6   $
��Left=�6T   $	��407��6o   �� 5&      $6��0What was the last name of your favorite teacher?��6   $
��Left=�6V   $	��406��6q   �� 5'      $;��5What was the last name of your best childhood friend?��6   $
��Left=�6[   $	��408��6v   $��0,0,-1,0q�6�   �� 5(      $-��'What was your favorite food as a child?��6   $
��Left=�6M   $	��406��6h   �� 5)      $"��Who was your childhood hero?��6   $
��Left=�6B   $	��406��6]   �� 5*      $3��-Where was your best family vacation as a kid?��6   $
��Left=�6S   $	��408��6n   $��0,0,-1,0q�6z   �� 5+      $C��=When you were young,what did you want to be when you grew up?��6   $
��Left=�6c   $	��375��6~   $��	0,0,-24,0q�6�   5,      �� 5-   
   -   5         ��Name$ 
OldTextbox��5-      $
��Left=�6&   $��23��6A   $��
20,293,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��409��6�   �� 5.   
   -   5        $ 
NewTextbox��5.      $
��Left=�6&   $��23��6A   $��
20,390,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��409��6�   �� 5/   
   -	   5        $ SaveQuestion��5/      $
��Save��6'   $
��Left=�66   $��
20,438,0,0q�6Q   $	��Top=�6e   $	��409��6}   $��36��6�   6�   �� 50   
   -
   5         ��Name$ label��50      $��Change Password��6   $
��Left=�69   $��	172,5,0,0q�6T   $	��Top=�6g   �� 51   
   -   5        $ 
label_Copy��51      $��Change Secret Question��6$   $
��Left=�6E   $��160,187,0,0q�6`   $	��Top=�6u   �� 52   
   -   5        $ label_Copy1��52      $��Old Secret Question��6%   $
��Left=�6C   $��172,231,0,0q�6^   $	��Top=�6s   	 J� RenderTransformOrigin$	 1.052,0.346&�6�   �� 53   
   -   5        $ label_Copy2��53      $��New Secret Question��6%   $
��Left=�6C   $��167,328,0,0q�6^   $	��Top=�6s   $	 1.052,0.346&�6�   �� 54   
   -   5        $ label_Copy3��54      $��Old Password��6%   $
��Left=�6<   $��	20,53,0,0q�6W   $	��Top=�6j   �� 55   
   -   5        $ label_Copy4��55      $��New Password��6%   $
��Left=�6<   $��	20,84,0,0q�6W   $	��Top=�6j   59      5:      