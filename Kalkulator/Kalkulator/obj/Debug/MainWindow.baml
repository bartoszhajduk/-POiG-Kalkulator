   M S B A M L   `   `   `  ����E  AKalkulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Kalkulator
Kalkulator  5   	       Kalkulator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Kalkulator     5   	   -   5          � Title$  
Kalkulator��5   	   $	��450��6   $	��300��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$	 txt��5       �� AcceptsReturn .   �� TextAlignment$ Right=�65   $��Bottom=�6K   $��0��6f   $��4��6s   $��30(�6�   .��6�   06�   �� 5   
   -   5         ��Name$ button_clear_entry��5      $��2��6-   $��0��6:   .��6k   CE6o   �� 5   
   -   5        $ button_clear��5      $��2��6'   $��1��64   .��6_   C6b   �� 5   
   -   5        $ button_back��5      $��2��6&   $��2��63   .��6Z   cofnij6b   �� 5    
   -   5        $ button_divide��5       $��2��6(   $��3��65   .��6\   /6_   �� 5"   
   -   5        $ button_7��5"      $��3��6#   $��0��60   .��6N   76Q   �� 5#   
   -   5        $ button_8��5#      $��3��6#   $��1��60   .��6N   86Q   �� 5$   
   -	   5        $ button_9��5$      $��3��6#   $��2��60   .��6N   96Q   �� 5%   
   -
   5        $ button_multiply��5%      $��3��6*   $��3��67   .��6^   *6a   �� 5'   
   -   5        $ button_4��5'      $��4��6#   $��0��60   .��6N   46Q   �� 5(   
   -   5        $ button_5��5(      $��4��6#   $��1��60   .��6N   56Q   �� 5)   
   -   5        $ button_6��5)      $��4��6#   $��2��60   .��6N   66Q   �� 5*   
   -   5        $ button_minus��5*      $��4��6'   $��3��64   .��6[   -6^   �� 5,   
   -   5        $ button_1��5,      $��5��6#   $��0��60   .��6O   16R   �� 5-   
   -   5        $ button_2��5-      $��5��6#   $��1��60   .��6N   26Q   �� 5.   
   -   5        $ button_3��5.      $��5��6#   $��2��60   .��6N   36Q   �� 5/   
   -   5        $ 
button_add��5/      $��5��6%   $��3��62   .��6Y   +6\   �� 51   
   -   5        $ button_addminus��51      $��6��6*   $��0��67   .��6^   +/-6c   �� 52   
   -   5        $ button_0��52      $��6��6#   $��1��60   .��6N   06Q   �� 53   
   -   5        $ button_comma��53      $��6��6'   $��2��64   .��6R   ,6U   �� 54   
   -   5        $ button_result��54      $��6��6(   $��3��65   .��6a   =6d   55      56      