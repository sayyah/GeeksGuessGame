   M S B A M L   `   `   `  ����D  @GuessGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GuessGame	GuessGame  5   	       GuessGame.Guess   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GuessGame     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��100* �6   6.   �� 5      $
��600* �6   6.   �� 5      $
��100* �6   6.    � RowDefinitions 5   
   �� 5      $
��100* �6   6,   �� 5      $
��300* �6   6,   �� 5      $
��100* �6   6,   .+�5   
   �� $��0��6   $��0��6"   
����  �5      �� 5   
   $��2��6   $��0��6"   
���  ��5      �� 5   
   $��2��6   $��2��6"   
��� � �5      �� 5   
   $��0��6   $��2��6"   ���	#FF0044955!      �� 5"   
   -   5         ��Name$ Board��5"      $	��500��6    $	��800��6-   .+�5#      �� -   5         ��Name$ label��5#      $��Point :��6#    �� Left$	 368��65   
 �� Top$	 442��6G   �� 5$      -   5        $ LblPoint��5$      $��0��6&   $	 404��62   $	 442��6D   5'      �� 5(   
   -   5        $ lblEnd��5(      $��1��6    $��1��6-   $	��End��6=   $��Center=�6K   $	��Top=�6h   $��72(�6�   $y�Visible=�6�   �� 5)   
   -   5         ��Name$ btnPlayAgain��5)      $��Play Again!��6'   $��1��6=   $��1��6J   $	��186��6Z   $��50��6f   $��	0,198,0,0q�6r   $y�Visible=�6�   $��Center=�6�   $	��Top=�6�   $��18(�6�    �� 	IsDefault$
 True��6�   $
��Bold"�6	  $��Normal$�6  �� 5+   
   -   5        $ lblJapanese��5+   -   $��0��6   $��0��6   $��Japanese��6B   $��18(�6U   
�������6d   �� 5,   
   -   5        $ 
lblChinese��5,   -   $��2��6   $��0��6   $��Chinese��6A   $��18(�6U   
�������6d   �� 5-   
   -   5        $ 	lblKorean��5-   -   $��2��6   $��2��6   $��Korean��6@   $��18(�6R   
�������6a   �� 5.   
   -	   5        $ lblThai��5.   -   $��0��6   $��2��6   $
��Thai��6>   $��18(�6N   
�������6\   50      52      