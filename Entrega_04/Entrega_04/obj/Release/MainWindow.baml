   M S B A M L   `   `   `  ���� E  AEntrega_04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Entrega_04
Entrega_04      Entrega_04.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Entrega_04       � Title$  Sim Mall��$	��768��$
��1280��.��� ���	#FF000429 � ColumnDefinitions �� $
��929* ��� $
��343* �.+��� -   $��Titulo��$��	Sim Mall ��$
��Left=�$��
553,10,0,0q�$	��Top=�$��48(�$��HarvestItal)����	#FFE0DADA$	��243���� -   $��Button_Crear��$��Crear��$
��Left=�$��
38,105,0,0q�$	��Top=�$	��230��$��24(�$��70�����	#FF00FF0C$��Segoe UI Black)� J� RenderTransformOrigin$ 
0.508,0.63&�$��1���� -   $��Button_Editar��$��Editar��$
��Left=�$��
38,190,0,0q�$	��Top=�$	��230��$��24(�$��70�����	#FFC5B6C3$��Segoe UI Black)�$ 
0.508,0.63&�$��1���� -   $��Button_Eliminar��$��Eliminar��$
��Left=�$��
38,280,0,0q�$	��Top=�$	��230��$��24(�$��70��
���  ��$��Segoe UI Black)�$ 
0.508,0.63&�$��1���� -   $��Button_Simualar��$��Simular��$
��Left=�$��
38,365,0,0q�$	��Top=�$	��230��$��24(�$��70�����	#FFFD6800$��Segoe UI Black)�$ 
0.508,1.26&�$��1���� -   $��Button_GuardarMall��$��Guardar Mall��$
��Left=�$��
38,450,0,0q�$	��Top=�$	��230��$��24(�$��70�����	#FFF3FF00$��Segoe UI Black)�$ 
0.508,1.26&�$��1���� -   $��Button_CargarMall��$��Cargar Mall��$
��Left=�$��
38,535,0,0q�$	��Top=�$	��230��$��24(�$��70�����	#FF00F2FD$��Segoe UI Black)�$ 
0.508,1.26&�$��1���� -   $��Button_SimualarGuardado��$��Cargar Simulacion��$
��Left=�$��
38,620,0,0q�$	��Top=�$	��230��$��24(�$��70�����	#FFFD00A1$��Segoe UI Black)�$ 
0.508,1.26&�$��1��&   System.Windows.Controls.DataGrid  -	     Name$ dataGrid��   AutoGenerateColumns .     
IsReadOnly . $��24(����	#FF001AB8
���   �$
��Bold"�$��48,105,34,47q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Pisos��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 	   FontSize$	 24Q�1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Pisos+  $ Nombre Mall��$ 2* $	 24Q�
 �� *Nombre+  $ Horas��$ 1* $	 24Q�
 �� *Horas+  $ Dinero Inicial��$
 1.5* $	 24Q�
 �� *Dinero+�� -
   $��Button_Iniciar��$��Iniciar��$
��Left=�$��120,595,0,0q�$	��Top=�$	��175��$��24(�$��70�����	#FF3AFF00$��Segoe UI Black)�$ 
0.508,0.63&�$��1��$y�Hidden=��� -   $��Button_Detener��$��Detener��$
��Left=�$��810,595,0,0q�$	��Top=�$	��175��$��24(�$��70��
���  ��$��Segoe UI Black)�$ 
0.508,1.26&�$��2��$y�Hidden=��� -   $��Button_Guardar��$��Guardar��$
��Left=�$��291,595,0,0q�$	��Top=�$	��175��$��24(�$��70�����	#FF00DCFF$��Segoe UI Black)�$ 
0.508,0.63&�$y�Hidden=��� -   $��Button_Cargar��$��Cargar��$
��Left=�$��
48,595,0,0q�$	��Top=�$	��175��$��24(�$��70�����	#FFE9FF0D$��Segoe UI Black)�$ 
0.508,1.26&�$y�Hidden=��� -   $��Button_EditarSimulacion��$��Editar��$
��Left=�$��553,595,0,0q�$	��Top=�$	��175��$��24(�$��70�����	#FFFF0DE9$��Segoe UI Black)�$ 
0.508,1.26&�$y�Hidden=�  -   $ 
dataGrid_1�� .   . $��16(����	#FF001AB8
���   �$
��Bold"�$��48,182,48,172q�$��2��$y�Hidden=�   $ Nombre��$
 2.5* $	 16Q�
 �� *Nombre+  $ 	Empleados��$ 2* $	 16Q�
 �� *Nroempleados+  $ 	Categoria��$ 4* $	 16Q�
 �� *	Categoria+  $
 Piso��$ 1* $	 16Q�
 �� *Piso+  $
 Area��$ 1* $	 16Q�
 �� *Area+  $ 
Precio min��$ 2* $	 16Q�
 �� *	Preciomin+  $ 
Precio max��$ 2* $	 16Q�
 �� *	Preciomax+  $ Arriendo��$
 1.8* $	 16Q�
 �� *
Arriendo+  $ Sueldos��$
 1.8* $	 16Q�
 �� *	Sueldos+  $ Ventas��$ 2* $	 16Q�
 �� *Ventas+  $ Clientes��$
 1.8* $	 16Q�
 �� *Clientespasados+  $ 	Ganancias��$ 2* $	 16Q�
 �� *Gananciasdia+  $ 	Acumulado��$ 2* $	 16Q�
 �� *Gananciasacumuladas+�� -   $��	label_dia��$��Dia : ��$
��Left=�$��41��$��900,122,0,0q�$	��Top=�$��88��$��24(�$��Segoe UI Semibold)�$
��Bold"����	#FFFDFDFD$y�Hidden=�$��2���� -   $��label_nrodia��$��0��$
��Left=�$��
64,122,0,0q�$	��Top=����	#FFF9F9F9$��Segoe UI Semibold)�$
��Bold"�$��24(�$y�Hidden=�$��1���� -   $��label_nombreMall��$��Nombre Mall : ��$
��Left=�$��
74,122,0,0q�$	��Top=�$��Segoe UI Semibold)�$
��Bold"�$��24(�
�������$y�Hidden=��� -   $��label_valorNombre��$��
Sin Nombre��$
��Left=�$��277,122,0,0q�$	��Top=����	#FFFDFDFD$��24(�$��Segoe UI Semibold)�$
��Bold"�$ 0.243,0.381&�$y�Hidden=��� -   $��Ayuda��$
��Left=�$��36��$��0,10,0,0q�$	��Top=�$	��124�����	#FF000429���	#FFFDFDFD$��20(�$ 0.024,0.556&����	#FF000429