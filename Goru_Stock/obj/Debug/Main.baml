   M S B A M L   `   `   `  ����E  AGoru_Stock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Goru_Stock
Goru_Stock  5   	       Goru_Stock.Main   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Goru_Stock     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	Dashboard��5	   	   $	��700��6   $
��1340��6(      MaterialDesignBody#���   5   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5   	   Z� .��5      #  MaterialDesignThemes.Wpf.Card    MaterialDesignPaper#���  6      UniformCornerRadius$ 15Q�6M   $��3q�6f   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6q   .��5   
   �  � RowDefinitions 5      �� 5      $	��59* �6    �� 5      $
��591* �6     � ColumnDefinitions 5      �� 5      $	��190 �6#   �� 5      .+�5      �� $��0��6   $��2��6%   
������� �� CornerRadius$ 	15,0,0,15��6I   ._�5      �� $��15q�6   .+�5      � $��10,10,10,30q�6    $��Center=�65   $	��140��6R   .+�5       �� $��images/logo2.png��6    $��30��6:   $	��120��6F   5!      �� 5#      -   5        	 ��Name$	 Stock��5#        MaterialDesignFlatButton#��[ 6@    " PrimaryHueLightForegroundBrush#���  6r   +  %MaterialDesignThemes.Wpf.ButtonAssist
   CornerRadius$
 6��6�   $
��auto��6�   $��45��6�   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback
 �����$��0 0 0 15q�6#  .��5$      � $	��120��6$   $��45��60   .+�5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�66   $��Center=�6B   $��	0,0,10,10q�6]   �� 5&      
Склад6/   5'      5(      �� 5*      -   5        $	 Provider��5*      #��[ 6F   #���  6x   $
 6��6�   $
��auto��6�   $��45��6�   
 �����$��0 0 0 15q�6)  .��5+      � $	��120��6$   $��45��60   .+�5,        $
 User=�66   $��Center=�6B   $��	0,0,10,10q�6]   �� 5-      Поставщик63   5.      5/      �� 51      -   5        $	 	Admission��51      #��[ 6H   #���  6z   $
 6��6�   $
��auto��6�   $��45��6�   
 �����$��0 0 0 15q�6+  .��52      � $	��120��6$   $��45��60   .+�53        $ Lecture=�66   $��Center=�6E   $��	0,0,10,10q�6`   �� 54      $-��'Ожидание поступления��6(   $
��Wrap=�6D   6[   55      56      57      58      � 5:      -   5         �Name$ LV_Stock��5:      $��10,10,10,10q�6%   $��1��6:   $��0��6J   $��2��6W   � 5;      -   5        $ LV_Provider��5;      $��10,10,10,10q�6)   $��1��6>   $��0��6N   $��2��6[   � 5<      -   5        $ LV_Admission��5<      $��10,10,10,10q�6)   $��1��6>   $��0��6N   $��2��6[   � 5=      -   5        $ LV_Shipment��5=      $��10,10,10,10q�6(   $��1��6=   $��0��6M   $��2��6Z   �� 5>      $��0��6   $��Right=�6&   $	��Top=�6B   $��30��6Z    �� Orientation$ 
Horizontal=�6f   $��RightToLeft=�6   $��1��6�   $��10,20,30,10q�6�   .+�5?      �� -   5        $	 btnClose��5?        IconButtonsStyle#��[ 6+    	 close#���  6U   
 � Tag$ IsCloseButton��6�   �� 5@      -	   5        $	 
btnRestore��5@      $	��5,0q�6-   ��5A      �� 5B       �� 
TargetType" ��6     �� BasedOn# [ 6=   .�5C      ��  �� Property � ��  maximize �� Value# �  68    �� Triggers 5D      �� 5E   "    �� Binding 6.   ��  �� ElementName$
 home�� �� Path$ WindowState� �� Value 	Maximized6e   .a�5F   &   ��  � ��  restore# �  6@   5G   #   5I      5K      �� 5L      -
   5        $	 btnMinimize��5L      #���  6.     minimize#���  6Y   6~   5M      5N      5P      5R      