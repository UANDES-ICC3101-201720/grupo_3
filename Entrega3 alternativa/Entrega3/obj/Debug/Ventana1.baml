   M S B A M L   `   `   `  ����C  ?Entrega3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Entrega3Entrega3  5   	       Entrega3.Ventana1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Entrega3     5   	     � Title$  Definir Tiendas��5   	   $	��800��6!   $
��1280��6.   ���	#FF040849.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��Nueva tienda:��61   $��35(�6F   $
��Bold"�6T   ���	#FFF9F9F96f   �� 5   
   $��2��6   $��1��6$   $��Tiendas:��61   $��35(�6A   $
��Bold"�6O   
�������6a   �� 5   
   $��2��6   $��2��6%   $��7��62   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns .     
IsReadOnly . $��20(�6�      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$
 Piso��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6S   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *	Nropiso+6S     5"      $ Nombre��6)   $ 2* 6T   	 69   �� *Nombre+6T     5#      $
 Area��6)   $
 1.5* 6P   	 67   �� *Area+6P   5&      5'      �� 5(   
   $��1��6   $��2��6    $��Piso: ��6.   $
��Left=�6?   $��10,0,0,0q�6Z   $��Center=�6l   $��24(�6�   ���	#FFF9F9F96�   �� 5)   
   $��1��6   $��3��6    $��Nombre: ��6.   $
��Left=�6A   $��10,0,0,0q�6\   $��Center=�6n   $��24(�6�   ���	#FFF9F9F96�   �� 5*   
   $��1��6   $��4��6    $��Area: ��6.   $
��Left=�6?   $��10,0,0,0q�6Z   $��Center=�6l   $��24(�6�   ���	#FFF9F9F96�   �� 5+   
   -   5        
 ��Name$
 textBox_nropiso��5+   /   $��1��6   $��2��6"   $
��Left=�6H   $��143,25,0,32q�6c    �� TextWrapping$
 Wrap=�6x   $��Center=�6�   $	��270��6�   $��24(�6�   �� 5,   
   -   5        $
 textBox_nombre��5,   /   $��1��6   $��3��6"   $
��Left=�6G   $��143,24,0,33q�6b   $
 Wrap=�6w   $��Center=�6�   $	��270��6�   $��24(�6�   �� 5-   
   -   5        $
 textBox_area��5-   /   $��1��6   $��4��6"   $
��Left=�6E   $��143,25,0,32q�6`   $
 Wrap=�6u   $��Center=�6�   $	��270��6�   $��24(�6�   �� 5.   
   -   5         ��Name$ Boton_Agregar��5.   A   $��1��6   $��5��6!   $��Agregar��6.   $	��210��6X   $��	0,10,0,10q�6d   $��24(�6�   �� 5/   
   -   5        $ Boton_Eliminar��5/   B   $��1��6   $��6��6!   $��Eliminar��6.   $	��210��6Z   $��	0,10,0,10q�6i   $��24(�6�   �� 50   
   -   5        $ Boton_Finalizar��50   L   $��2��6   $��8��6!   $��Iniciar Simulacion��6.   $	��210��6e   $��	0,10,0,10q�6q   $��24(�6�   51      52      