   M S B A M L   `   `   `  ����L  HMyWorkoutRoutines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MyWorkoutRoutinesMyWorkoutRoutines  5      %    MyWorkoutRoutines.PanelRoutines   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MyWorkoutRoutines     5      -   5          >�Name$  CreateRoutinePage��5   #   ���#EBEBEB$��0q�6`   .��5
      � -   5         �Name$ 
ParentGrid��5
      $	��810��6   $	��355��6.    � ColumnDefinitions 5   
   �� 5      $	��120��6   $	��120 �6.   �� 5      $	��544��6   $��* �6.   �� 5      $	��120��6   $	��120 �6.   .+�5   
   �� -   5         ��Name$ routineList��5         ListViewRoutineBorder#��[  6(   $	��Top=�6�   $��1��6�   $��0,10,0,0q�5      $��544.5��6%   
������ ��.  
������ $��Center=�6�   ��5   m   �� ��5      �� 5      .R�5      � $��0 3 0 0q�6    5      �� 5      $	��100 �6/   �� 5      $��344.5 �6/   �� 5      $	��100 �6/   .+�5      ��  �� CornerRadius$ 45��6!   
������ $��1q�5!   !   $
��Left=�5"   !   $��85��6<   $��0,0,0,0q�5#   !   $��3��5$   !   $	��Top=�5%   !   $��544.5��5&   !   ��5'      �� 5(   "   .�5)   &   ��  �� Property � �� �� Value �#3333336J    �� Triggers 5*   &   �� 5+   *    �� Binding 66   �� 	 �� ElementName$	 MyBorder��
 �� Path$
 IsMouseOver� �� Value true6q   .a�5,   .   ��  � �� �#3333336d   5-   +   5/   #   51      �� 52      $ 45��6!   
������ ���#F7F7F7$��1q�6b   $
��Left=�6v   $��85��6�   $��0.5,-1,-1,1q�6�   $	��Top=�6�   $	��545��6�   $��3��6�   6�   �� 53      -   5        $��0q�53   8   $��0 -7 0 0q�6L   $
��Bold"�6^   $��0��6p   $	��▶��6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   $��55��6�   $��55��6�   $��30(�6�   ���#FFFFFF$��Center=�6"    PlayButtonRoutine#���  6D  �� 54      $��DemiBold"�6@   $��1��6V   ���#333333$	��Top=�6{   $
��Left=�6�   $��0 7 0 0q�6�   $��70��6�   $��28(�6�   
������ 
������ $��Center=�6  ��6    �� *RoutineName+60  o� 55      $��DemiBold"�6   $��0q�65   
������ $��2��6b   $	��Top=�6r   $
��Left=�6�   $��Center=�6�   $��12,10q�6�   $��70��6�   $��70��6�   $��38(�6�   $	��Top=�6�     MenuItem#���  6  .@�56      m� $	��...��6'   .@�57   "   m� $��löschen��6T    m� Icon$  ��6+   $��
 löschen ��63   $��20(�6F   ��58   &   �� 59   *   .R�5:   .   �� ���#EBEBEB._�5;   2   ��  ��Name$ 
delRoutine��6N   -   5        ���#EBEBEB$��0q�5;   {   .��6�   
löschen6�   5<   /   5=   +   5?   #   5@      5A      5B      5C       � 	Resources 5E       �� 
TargetType �� 
TargetType J� SnapsToDevicePixels � RowDefinitions ]�Name J� IsMouseOver ]� DecreaseRepeatButton �� PageUpCommand  RepeatButtonTransparent ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb  ScrollBarThumbVertical��%�  '��       7  7  7  �� 5F      " ��6   .�5G      ��  � �� �#DEDEDE63   �� 5H       � �� �#DEDEDE64   �� 5I       � �� 5J      �� 5K      " ��6.   .R�5L   "   � $ Bg��6'    . $��15��6N    5M   &   �� 5N   *   $��0��68   �� 5O   *   $��0.00001* �68   �� 5P   *   $��0��68   .+�5R   &   �� #��z��6-   #��z��6Y   #��z��6�   $��1��6�   $ 10��6�   ]� 5S   &   $ 
PART_Track��6,   ��. #{�z 6[   $��1��6�    5T   *   �� 5U   .   #��Z 6;   8��  $
��Left=�6�   $��17��6�    5W   *   �� 5X   .   #��Z 6;   8�� 6j    5Z   *   n� 5[   .   8�� $��2q�6d   5]   '   5^   #   5_      5a      5b      5c      5d      5e      5f      