   M S B A M L   `   `   `  ����C  ?Entrega3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Entrega3Entrega3  5   	       Entrega3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Entrega3     5   	     � Title$  Mall Simulator��5   	   $	��800��6    $
��1280��6-   ���	#FF000751.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��Datos iniciales:��6   $��1��6,   $��1��6<   $��24(�6I   $
��Bold"�6W   
�������6i   �� 5   
   $��1��6   $��2��6    $��Nombre del Mall: ��6.   $
��Left=�6J   $��
10,21,0,24q�6e   $��Center=�6y   $��24(�6�   
�������$��46��6�   �� 5   
   $��2��6   $��2��6    $��Sueldo promedio: ��6.   $
��Left=�6J   $��
10,25,0,24q�6e   $��Center=�6y   $��24(�6�   ���	#FFFBF7F7$��42��6�   �� 5   
   -   5         ��Name$ textBox_nombre��5   /   $��1��6   $��2��6"   $
��Left=�6G   $��275,25,0,28q�6b    �� TextWrapping$
 Wrap=�6w   $��Center=�6�   $	��204��6�   $��24(�6�   $��38��6�   �� 5    
   -   5        $ textBox_sueldo��5    /   $��2��6   $��2��6"   $
��Left=�6G   $��220,29,0,24q�6b   $
 Wrap=�6w   $��Center=�6�   $	��210��6�   $��24(�6�   $��38��6�   �� 5!   
   $��Numero de Pisos:��6   $��1��6,   $��3��6<   $��24(�6I   $
��Bold"�6W   
�������6i   �� 5"   
   $��4��6   $��
Piso Nro: ��6   $
��Left=�63   $��
10,25,0,24q�6N   $��Center=�6b   $��24(�6}   $��1��6�   
�������6�   �� 5#   
   $��1��6   $��4��6    $
��Left=�6�   $��156,33,0,24q�6�   $��Center=�6�   $��24(�6�   $��34��6�   $��54��6�   
���������6.   ��  �� Path$ _Nropiso� �� NotifyOnSourceUpdated .  �� NotifyOnTargetUpdated . 6�   �� 5$   
   $��1��6   $��4��6    $��Area: ��6.   $
��Left=�6?   $��257,25,0,24q�6Z   $��Center=�6o   $��24(�6�   
�������6�   �� 5%   
   -   5        $ textBox_area��5%   /   $��1��6   $��4��6"   $
��Left=�6E   $��332,33,0,24q�6`   $
 Wrap=�6u   $��Center=�6�   $	��170��6�   $��24(�6�   �� 5&   
   -   5         ��Name$ Boton_Agregar��5&   F   $��1��6   $��6��6!   $��Agregar Piso��6.   $	��210��6]   $��203,36,203,0q�6i   $��Center=�6   $��24(�6�   �� 5'   
   -   5        $ Boton_Finalizar��5'   C   $��1��6   $��7��6!   $��	Finalizar��6.   $	��210��6\   $��203,36,203,10q�6h   $��Center=�6   $��24(�6�   �� 5(   
   $��2��6   $��4��6%   $��7��62   .+�5)      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dataGrid��5)      
   AutoGenerateColumns
 .     
IsReadOnly . $��20(�6W      Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ Nro Piso��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	Nropiso+6W     5,      $
 Area��6)   $ 2* 6P    67   �� *Area+6P   5.      5/      50      51      