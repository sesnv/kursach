   M S B A M L   `   `   `  ����	  Login    Login.Model.StudentPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  Your Window Title��5      $	��350��6   $	��525��6,   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF222E3F��6   � 5      $ 	#FF1C222C��6    � Offset$ 1Q�6-   � 5	      $ 	#FF1C222C��6   $	 0.5Q�6-   5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��0��6   $
��Left=�6    $��
10,10,0,10q�6;   $	��166��6O   .@�5      �� -   5        $	��FIO��5   h   $��Фамилия Имя:��6   $��22(�6,   
�������$��Cascadia Code)�6M   6h   5        5   
   $��1��6   $
��Left=�6    $	��166��6;   $��10,0,0,0q�6G   .@�5      �� $��Номер группы:��6   $��10,0,0,0q�6-   $��22(�6?   
�������$��Cascadia Code)�6`   �� 5      ��6   �� *GroupNumber+5      �� 5   
   $��2��6    �� Orientation$ Vertical=�6"   $��10q�69   .+�5      �� -   5        $��50��5      $ ��Переход в МУДЛ��6!   $��	10,0,0,10q�6:   $��18(�6M   
���   �$��Cascadia Code)�6n   6�   �� 5       -   5        $��50��5       $,��&Переход в библиотеку��6!   $��	10,0,0,10q�6@   $��18(�6S   
���   �$��Cascadia Code)�6t   6�   �� 5!      -   5        $��50��5!      $A��;Подробная информация о студенте��6!   $��10,0,0,0q�6K   $��18(�6]   
���   �$��Cascadia Code)�6~   6�   5"      �� 5#   
   $��3��6   .+�5$      �� -   5        $��	MinButton��5$      $��30��6%   $��40��61   $��10,10,10,10q�6<    J� RenderTransformOrigin$ 	0.563,0.5&�6R   $
��Left=�6�   $��Bottom=�6�   ��5%      �� 5&       �� 
TargetType" ��6   .�5'      �� 	 �� Property	 � ��
 �� Value$$
 /Source/стрелочка.png��63    �� Triggers 5(      �� 5)       �� Binding 6*   �� *IsMouseOver+ �� ElementName$ 
ExitButton�� �� Value True5*   .   .a�5+   "   �� 	 � ��$/
 )/Source/стрелочка актив.png��6;   5,      5.      z�50      V� 51      .~�52      �� �� 53      �� 54      T� 55       T� X$ 0Q�6-    T� Y$	 -15Q�63   56      58      59      5:      5;      