   M S B A M L   `   `   `  ����@  <TD N2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TD_N2TD_N2  5   	       TD_N2.MainWindow   5   	   localclr-namespace:TD_N2  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	   $��475.632��6   $��381.579��6-    � 	Resources 5        TD_N2.Conversion 
  myConv  ErrorTemplate �� Orientation  
MyTemplate A� Columns A� Rows��%�  &	        &	      &	 �       5	   
   6   �� 5   
   .R�5      �� 
��� � �$��2q�6)   ._�5      �� $ 
Horizontal=�6   .+�5      �� $	��100��60   �� 5      $��Erreur��6    5      5      5      �� 5   
   .R�5      �� 
���  ��$��2q�6'   $��Center=�6;   ._�5      A� $ 4��6   $ 1��6*   .+�5      � $��Center=�6   .+�5      A� $��20��6"   $��20��6-   
��� ���$��Center=�6H   �� 5      $��Center=�6D   ��6(   �� *
Classement+6D   5      �� 5      $��Center=�65   ��6    �� *Cin+65   �� 5      $��Center=�65   ��6    �� *Nom+65   �� 5      $��Center=�6?   ��6    �� *Etablissement+6?   5      5      5      5       .��5!      �  � RowDefinitions 5"   
   �� 5#      �� 5$      $��4* �6   �� 5%      �� 5&      $��3* �6   .+�5(   
   �� $ ��Classement en compétition��6   $
��Bold"�64   $��Center=�6F   $��Center=�6a   �� 5)   
   $��1��6   $��Informations��6    
���   �.��5*      �� -   5         ��Name$ stInfo��5*      .+�5+      �� $
��Cin:��6   �� 5,      -   5         ��Name$ txtCin��5,      ��6*   �� *Cin+�� 5-      $
��Nom:��6   �� 5.      -   5        $ txtNom��5.      ��6*   �� *Nom+�� 5/      $��
Classement��6   �� 50      -   5        $ txtClass��50       =� ErrorTemplate# [ 6-   .��6g   ��51      �� 52      	 �� Path$	 
Classement�6"   
 �� UpdateSourceTrigger$
 PropertyChanged=�64    �� ValidationRules 53         TD_N2.ValidationClassement  54   "   56      .��57   $   58      �� 59      $��Etablissement��6   .��5:      �� $ 
Horizontal=�6!   .+�5;      	� -   5         	�Name$ rdIset��5;   &   $��Iset charguia��66    d� 	IsChecked 6N   �� *Etablissement+ �� 	Converter# [  	� 5<      -   5        $ rdAutre��5<   &   $��Autre��67   5=      5>      5?      5@      �� 5A   
   -   5        $��Ajouter��5A      $��2��6#   $��Center=�60   6K   �� 5B   
   -	   5         ��Name$ lstComp��5B      $��3��6#   #��[ 6H   ��60   �� 6H   5C      5D      