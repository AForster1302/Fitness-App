   M S B A M L   `   `   `  ����L  HMyWorkoutRoutines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MyWorkoutRoutinesMyWorkoutRoutines  5      '    !MyWorkoutRoutines.PanelHomeScreen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MyWorkoutRoutines     5      -   5          >�Name$  HomeScreenPage��5   #   ���#EBEBEB$��0q�6Z   .��5
      � -   5         �Name$ 
ParentGrid��5
      $	��810��6   $	��355��6.    � ColumnDefinitions 5   
   �� 5      $	��240��6   $	��200 �6.   �� 5      $	��424��6   $��* �6.   .+�5   
   � $��10 0 0 0q�6    � RowDefinitions 5      �� 5      $	��210��6    $��* �60   �� 5      $��90��6    $��* �6/   �� 5      $��55��6    .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ Calendar��5      $��	0 20 0 20q�6)   $��0��6<   $
��Left=�6I   6�   �� 5      -   5         ��Name$ btnSafeDays��5   �   $��1��6   $��Tage speichern��6"   $��Center=�6;   $	��Top=�6X   $��
Nirmala UI)�6p   $��28��6�   $	��120��6�   ���#EBEBEB$
��Bold"�6�   
������ ���#8B0000 � 	Resources 5       �� 
TargetType �� Property	 �� Value��%d   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 10��69   6F   5      5      5      �� 5      -   5        
 ��Name$
 UserName��5   R   $��2��6   $��0 20 0 5q�6%   $��Bottom=�67   $��16(�6d   ���#8B0000$��Light"�6�   5"      5#      5$      