   M S B A M L   `   `   `  ����L  HMyWorkoutRoutines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MyWorkoutRoutinesMyWorkoutRoutines  5   	   "    MyWorkoutRoutines.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   LmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     5   	   1localclr-namespace:MyWorkoutRoutines     5   	   -   5          �Name$  
MainScreen��5	   J    J� 	AllowDrop .  � 
ResizeMode$ NoResize=�6    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6^    � Title$ MyWorkoutRoutines��5
   	   $	��450��6#   $	��810��60   
������  � WindowStyle$
 None=�6U   .��5      �� -   5         ��Name$ ParentBorder��5      ���#8B0000 �� CornerRadius$ 15,15,15,15��68   	 �� Padding$	 8q�6S   $	��.65q�6_   ._�5   
   � -   5        
 �Name$
 
ParentGrid��5      $��	-8,0,-8,8q�6#    � RowDefinitions 5      �� 5      $��25 �6    6.   �� 5      $��40 �6    6.   �� 5      $	��355��6    $��* �60   6=   �� 5      $
��Auto �6    .+�5      � $��1��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5      .+�5      	� -   5        $��1��5      $��0��6+   $��Hauptbildschirm��6;   $
��Bold"�6U   $��0q�5      $��16(�62      
MenuButton#��[  6V   	� 5      -   5        $��1��5      $��1��6+   $��Routinen erstellen��6;   $
��Bold"�6X   $��0q�5       $��16(�62   #��[  6Y   	� 5!      -   5        $��1��5!      $��2��6+   $��Meine Routinen��6;   $
��Bold"�6T   $��0q�5"      $��16(�62   #��[  6T   	� 5#      -   5        $��1��5#      $��3��6+   $��Trainingsverlauf��6;   $
��Bold"�6V   $��0q�5$      $��16(�62   #��[  6S   5%      �� 5'      -   5        $��0��5'      
������ $��0,-8,0,0q�6<   6N   �� 5)      ���#EBEBEB$��15(�6-   $��Light"�6;   $��7 0 0 0q�6N   $��MyWorkoutRoutines��5*      $��1��61    J� IsHitTestVisible .  6A   � 5+      $��0��6   $	��210��6    $��30��6,   $	��Top=�68   $��Right=�6P   $��0,-8,0,0q�6l   .+�5,      �� -	   5        $��25��5,      $��0 -2 0 0q�6$   $��	178,0,6,0q�5-      $��25��6,   $
��🗙��68     WindowButton#���  5.   1   ��6   Z� 61   �� 5/      -
   5         ��Name$ MaximizeProgram��5/      $��0 -2 0 0q�62   $��25��50      $��25��6$   $��
156,2,29,2q�60   $
��🗖��6D   #���  6Q   ��51      Z� 60   �� 52      -   5        $��25��52      $��0 -2 0 0q�6$   $��
133,2,52,2q�53      $��25��6-   $
��🗕��69   #���  6_   ��54      Z� 55      >� 57      -   5         >�Name$
 Main��57   '   $��2��6   6'   58      5:      5;      