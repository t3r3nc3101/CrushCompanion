   M S B A M L   `   `   `  ����I  ECrushCompanion, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CrushCompanionCrushCompanion  5   	       CrushCompanion.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CrushCompanion     5   	   \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar  5	      -   5        $	��250��5
      $	��250��6'     � 
ResizeMode$  NoResize=�63    � Topmost$
 True��6I    � AllowsTransparency$
 True��6�    � WindowStyle$
 None=�6�    � WindowStartupLocation$ Manual=�6�   $��False��6   � ShowInTaskbar$ False��6+   J� Opacity$
 0.85Q�6�   � Icon$ /ICON_invader_zero.ico��6�   � ContextMenu 5      �� 5   
   .@�5      m� -   5        	 m�Name$	 CurrencyHeader��5      $��_Currency [USD]��6/   .@�5      m� -   5        $	 
USD_Button��5      $	��USD��6/   m� 5      -   5        $	 
AUD_Button��5      $	��AUD��6/   5      m� 5      -   5        $	 PriceColor_Header��5      $��_Price color {W]��62   .@�5      m� -   5        $	 White_Button��5      $��White��61   m� 5      -   5        $	 Black_Button��5      $��Black��61   5      �� 5      m� 5      $��_Text Display��6   .@�5      m� -   5        $	 ShowPrice_checkbox��5      $��_Show Current Price��63   
 m� IsCheckable$

 True��6R    m� 	IsChecked$
 True��6g   m� 5      -	   5        $	 ShowHoldings_checkbox��5      $��_Show Holdings Worth��66   $

 True��6V   $ False��6k   m� 5      -
   5        $	 holdingAmount��5      $��_Holding Amount (CRUSH)��6.   .@�5      �� -   5         ��Name$ definedHoldings��5      $	��100��63    �� 	UndoLimit$ 10��6?   $��1��6N   6Y   5      5      m� 5      -   5        $��_Follow Mouse (soon)��5      $

 True��67   $  false��6L   ${�false��6_   5   2   m� 5      -   5        $��_Gravity��5      $

 True��6+   $  true��6@   5    .   m� 5!      -   5        $��_Stay Still!��5!      $

 True��6/   $  false��6D   $
��Bold"�5"   Q   �� 5#      �� 5$      m� 5%      -   5        $��_REMOVE��5%      ���	#FFDE1818$
��Bold"�6P   5&      ��5+      �� 5,   
    �� Color$ White��6    �� Opacity$ 0Q�6(   .��50      �� $
��Auto��6   $��75,75,75,75q�6   $
��Auto��60   .+�52   
   �� -   5         ��Name$ image��52      $	��100��6   $	��100��6,   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$  /floating_invader_zero.gif��68   $ ��/floating_invader_zero.gif��6v   �� 53   
   -   5         ��Name$ 
priceLabel��53      $��$99.99999999��6$   $��
50,160,0,0q�6;   $��37��6O   $	��170��6[    �� Left$	 -85��6g   
 �� Top$	 -65��6y   $��18(�6�   
�������$��Center=�6�   $��Center=�6�   $��Center=�6�   $��Center=�6  $��Bahnschrift SemiBold)�6)  $	 0.5Q�6K   J� IsHitTestVisible$ False��6Y  �� 55   
   -   5         ��Name$ 
CLICK_AREA��55      $	��147��6(   $	��130��65   
���   �$ 0Q�6N   $	 -15��6Z   $	 -15��6l   5;      5@      