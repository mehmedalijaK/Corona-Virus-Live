   M S B A M L   `   `   `  ����E  ACoronaLive, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CoronaLive
CoronaLive  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   7 clr-namespace:CoronaLive.ClassesCoronaLive.Classes  5   	       CoronaLive.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CoronaLive     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Bscm8clr-namespace:System.ComponentModel;assembly=WindowsBase  5   	   -local1 clr-namespace:CoronaLive.Classes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   $y�Visible=�5   	    � 
ResizeMode$ NoResize=�5        � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � 	Resources 5         CoronaLive.Classes.Brush 	 Brush   CoronaLive.Classes.Brush1 
 Brush1"   CoronaLive.Classes.BrushText  	BrushText#   CoronaLive.Classes.BrushGreen  
BrushGreen'   !CoronaLive.Classes.BrushGreenText  BrushGreenText  MyItemsViewSource �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName��%  &	       &	      &	 &     &	 9     &	 L     &	 _       5   
   6     5   
   6     5   
   6     5   
   6     5   
   6    �� 5   
    69   �� *	MyItems+ 5        5      $ MyPropertyName��6&   5      5       .��5"      � .+�5#   
   � -   5        	 �Name$	 LoadingDataGrid��5#       %	 !MaterialDesignCircularProgressBar#��[	 6/   
 � Value$
 35Q�6j    � IsIndeterminate . 6u   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ ListaDrzava��5$      $��0 8 0 0q�6(      CanUserSortColumns .    CanUserAddRows .  $
��Bold"�6j   ��6�   ��  �� Source# [    Columns 5&      4	  .System.Windows.Controls.DataGridTemplateColumn	  5'       	  CellTemplate 5(      �� 5)      .R�5*      �� $	��100��6O   $��30��6[   ��6$   �� *DodatneInformacije.flag+6[   5+      5-      0
  *System.Windows.Controls.DataGridTextColumn
  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Country��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *	ImeDrzave+   ElementStyle 5/      �� 50       �� 
TargetType" ��6    .�51      ��  �� Property � �� �� Value$ Center=�6L   52      54      
  55      $ Total Cases��6%   $ * 6:    6D   �� *UkupnoZarazenih+ �� StringFormat$ {0:N0}�� 56      �� 57      " ��6    .�58      ��  � ��$ Center=�6L   59      5;      
  5<      $ 	New Cases��6%   $ * 68    6B   �� *SlucajeviDanas+$ {0:   +}{0:N0}�� 5>      �� 5?      " ��6    .�5@      ��  � �� 6<   �� *SlucajeviDanas+ �� 	Converter# [ �� 5A       � ��$ Center=�6L   5B      5D      
  5E      $ Total Deaths��6%   $ * 6;    6E   �� *UkupnoMrtvih+$ {0:N0}�� 5F      �� 5G      " ��6    .�5H      ��  � ��$ Center=�6L   5I      5K      
  5L      $ 
New Deaths��6%   $ * 69    6C   �� *
MrtviDanas+$ {0:   +}{0:N0}�� 5M      �� 5N      " ��6    .�5O      ��  � �� 6;   �� *
MrtviDanas+# [ �� 5P       � �� 6;   �� *
MrtviDanas+# [ �� 5Q       � ��$ Center=�6L   5R      5T      
  5U      $ Total Recovered��6%   $ * 6>    6H   �� *UkupnoPreboleloKoronu+$ {0:  }{0:N0}�� 5V      �� 5W      " ��6    .�5X      ��  � �� 6;   �� *UkupnoPreboleloKoronu+# [ �� 5Y       � �� 6;   �� *UkupnoPreboleloKoronu+# [ �� 5Z       � ��$ Center=�6L   5[      5]      
  5^      $ Active Cases��6%   $ * 6;    6E   �� *AktivniSlucajeviKorone+$ {0:N0}�� 5_      �� 5`      " ��6    .�5a      ��  � ��$ Center=�6L   5b      5d      
  5e      $ Serious, Critical��6%   $ * 6@    6J   �� *UkupnoZivotnoUgrozenih+$ {0:N0}�� 5f      �� 5g      " ��6    .�5h      ��  � ��$ Center=�6L   5i      5k      
  5l      $ Total Tests��6%   $ * 6:    6D   �� *UkupnoTestiranihStanovnika+$ {0:N0}�� 5m      �� 5n      " ��6    .�5o      ��  � ��$ Center=�6L   5p      5r      5v      5w      5x      