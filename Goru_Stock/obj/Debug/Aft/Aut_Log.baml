   M S B A M L   `   `   `  ����E  AGoru_Stock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Goru_Stock.AftGoru_Stock.Aft  5   	       Goru_Stock.Aft.Aut_Log   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Goru_Stock.Aft     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  64     � Title$
  Main��5   	   $	��280��6   $	��560��6#    � WindowStartupLocation$ CenterScreen=�6/    � WindowStyle$
 None=�6T    � AllowsTransparency . 
������ .��5	      ��  �� CornerRadius$ 14��6   ._�5
   
   �� $ 10��6   $��1q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$ 1,0.7&�67   .��5      �    secondaryBackColor1 � Color# [  6#   	 � Offset$	 0Q�6P   5      ��5      �� 5      $	 0,0&�6&   $	 1,1&�67   .��5      �   winBorderColor1# [ 6#   $	 0Q�6L   5      ._�5      � 
 � ColumnDefinitions
 5      �� 5      $
��auto �6'   $��67��64   �� 5      $
��174* �6'   �� 5      $
��211* �6'   �� 5      $	��96* �6'    � RowDefinitions 5      �� 5      $
��auto �6$   �� 5       $
��245* �6$   �� 5!      $	��93* �6$   .+�5)      � -   5        $��4��5)      $��0��5*      $��40,10,20,10q�5+      .+�5-      ��  �� Orientation$ 
Horizontal=�6!   $��RightToLeft=�5.      
������ $��0,0,0,-9q�5/   2   .+�51      �� -   5         ��Name$ btnClose��51   !     controlButton#��[ 52   !   $��0,0,0,20q�53   8   .��54      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6+     controlButtonIcon#��[ 68   55      56      57      �� 59      
������ $��0��5:      $��1��5;      $��1q�5<      
������ $��15,15,15,15q�5>      $ 15��5?      $��2��6#   ._�5A      �� $ 
Horizontal=�6!   $��Center=�6:   .+�5B      �� $��/images/logo2.png��6    $��30��6;   $��77��6G   5C      5D      �� 5E      $ Vertical=�6   $��Center=�64   $��1��6Q   $��1��6^   $��
45,0,180,0q�6n   $	��160��6�   $��2��6�   .+�5F      �� $��
Логин��6      text_ButtonText#��[ 6-   $	��100��6V   �� 5G      $��Пароль��6    #��[ 6.   $	��100��6W   5H      �� 5I      $ Vertical=�6   $��Center=�64   $��1��6Q   $��2��6^   $	��162��6n   $��	-30,0,0,0q�6z   .+�5J      �� -   5         ��Name$ Login��5J      $	��103��5K      $��
0,15,15,15q�5L      $��
Montserrat)�5M      $��Medium"�66   $��16(�6J   
���   � �� SelectionBrush
 �  �� �� 
CaretBrush
 �   �
���   �5O   1   G� 5P      -   5         G�Name$ Password��5P   "   $	��103��5Q      $��
0,15,15,15q�5R      $��
Montserrat)�5S      $��Medium"�66   $��16(�6J   
���   � G� SelectionBrush
 �  �� G� 
CaretBrush
 �   �
���   �5U   1   5V      �� 5W      -   5        $	 Avt��5W      $��Вход��6&   $��Center=�65   $��3��6R   $��2��6b   $
��Auto��6o   $��16,17,16,16q�6}   $��64��6�   6�   5X      5Z      5[      5\      