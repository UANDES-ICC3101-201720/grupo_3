   M S B A M L   `   `   `  ����E  AEntrega_04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Entrega_04
Entrega_04  5   	       Entrega_04.Ayuda   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Entrega_04     5   	   J FWpfAnimatedGif, Version=1.4.15.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	     � Title$  Ayuda��5	   	   $	��720��6   $
��1200��6$   .��5
      � ���	#FF000429.+�5   
   �� -   5        $��Titulo��5      $��Manual Sim Mall ��6   $
��Left=�69   $��
407,10,0,0q�6T   $	��Top=�6h   $��48(�6�   $��HarvestItal)�6�   ���	#FFE0DADA$��98��6�   $	��368��6�    J� RenderTransformOrigin$ 0.524,-0.084&�6�   �� 5   
   -   5        $��Button_Simular��5      $!��Cargar y guardar simulacion��6'   $
��Left=�6M   $��306,127,0,0q�6h   $	��Top=�6}   $	��361��6�   $��24(�6�   $��60��6�   ���	#FFB0B0B0$��Segoe UI Black)�6�   $ 
0.82,0.437&�6	  �� 5   
   -   5        $��Button_mall��5      $��Cargar y guardar mall��6$   $
��Left=�6D   $��	0,127,0,0q�6_   $	��Top=�6r   $	��306��6�   $��24(�6�   $��60��6�   ���	#FFB0B0B0$��Segoe UI Black)�6�   $ 
0.508,1.26&�6�   �� 5   
   -   5        $��Button_manejoSimul��5      $��Manejo simulacion��6+   $
��Left=�6G   $��667,127,0,0q�6b   $	��Top=�6w   $	��287��6�   $��24(�6�   $��60��6�   ���	#FFB0B0B0$��Segoe UI Black)�6�   $ 
0.508,1.26&�6  �� 5   
   -   5        $��Button_manejoMall��5      $��Manejo mall��6*   $
��Left=�6@   $��954,127,0,0q�6[   $	��Top=�6p   $	��238��6�   $��24(�6�   $��60��6�   ���	#FFB0B0B0$��Segoe UI Black)�6�   $ 
0.508,1.26&�6�   �� 5   
   -   5        $��
CargarMall��5      $
��Left=�6"   "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��6=      AnimatedSource$ Imagenes\CargarMall.gif��6h   $	��227��6�   $��711,432,0,0q�6�   $	��Top=�6�   $	��395��6�   $��Imagenes/CargarMall.gif��6�   $ 1.514,1.313&�6
  �� 5   
   -   5        $��GuardarrMall��5      $
��Left=�6$   $ Forever��6?   $ Imagenes\GuardarMall.gif��6j   $	��227��6�   $��
58,192,0,0q�6�   $	��Top=�6�   $	��395��6�   $��Imagenes/GuardarMall.gif��6�   �� 5   
   -   5        $��
textBlock1��5      $
��Wrap=�6&   ���	#FFF7F7F7$��492,227,238,297q�6Q   $��20(�6k   $��Segoe UI Semibold)�6y   Guardar Mall:�� 5      421.- Debe existir un mall creado para poder guardar�� 5   @   IG2.- Todos los malls que existan se guardaran en el archivo seleccionado�� 5   V   5      �� 5   
   -	   5        $��
textBlock2��5      $
��Wrap=�6&   ���	#FFF7F7F7$��218,468,512,43q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   Cargar Mall:�� 5      B@1.- Solo se pueden abrir archivos que fueron guardados como mall�� 5   N   /-2.- El archivo puede contener más de un mall�� 5    ;   IG3.- ADVERTENCIA al cargar un nuevo mall se perderán los mall anterior.�� 5!   T   5"      �� 5&   
   -
   5        $��CargarSimulacion��5&      $
��Left=�6(   $ Forever��6C   $# Imagenes\CargarSimulacion.gif��6n   $	��227��6�   $��
58,192,0,0q�6�   $	��Top=�6�   $	��395��6�   $#��Imagenes/CargarSimulacion.gif��6�   $y�Hidden=�6  �� 5'   
   -   5        $��CargarSimulacion_VentMall��5'      $
��Left=�61   $ Forever��6L   $, &Imagenes\CargarSimulacion_VentMall.gif��6w   $	��227��6�   $��748,419,0,0q�6�   $	��Top=�6�   $	��395��6�   $,��&Imagenes/CargarSimulacion_VentMall.gif��6  $y�Hidden=�67  �� 5(   
   -   5        $��GuardarSimulacion��5(      $
��Left=�6)   $ Forever��6D   $$ Imagenes\GuardarSimulacion.gif��6o   $	��227��6�   $��
58,222,0,0q�6�   $	��Top=�6�   $	��395��6�   $$��Imagenes/GuardarSimulacion.gif��6�   $y�Hidden=�6  �� 5*   
   -   5        $��
textBlock3��5*      $
��Wrap=�6&   ���	#FFF7F7F7$��518,234,54,250q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   Cargar Simulación:�� 5+      ��1.- Si se encuentra en una simulación puede cargar una nueva seleccionando "Cargar" y eligiendo un archivo con una simulación pasada.�� 5.      JH2.- ADVERTENCIA al cargar una nueva simulación se perderá la anterior.�� 5/   T   50      �� 52   
   -   5        $��
textBlock4��52      $
��Wrap=�6&   ���	#FFF7F7F7$��123,449,449,57q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   " Cargar Simulación desde inicio:�� 53   ,   ��1.- Para cargar una simulación pasada al iniciar el programa puede seleccionar "Cargar Simulación" en donde deberá elegir un archivo de una simulación pasada.�� 56   (   KI2.- Solo se pueden abrir archivos que fueron guardados como Simulaciones.�� 57   W   58      �� 5:   
   -   5        $��
textBlock5��5:      $
��Wrap=�6&   ���	#FFF7F7F7$��473,256,99,250q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   Guardar Simulación:�� 5;       ��1.- Para guardar una simulación realizada puede seleccionar "Guardar" y elegir un archivo en el cual desea guardar la información de la simulación.�� 5>   ,   5?      �� 5A   
   -   5        $��Anterior_CGSimulacion��5A      $��Anterior��6.   $
��Left=�6\   $��42��6w   $��473,617,0,0q�6�   $	��Top=�6�   $��88��6�   $��16(�6�   $��Segoe UI Semibold)�6�   $
��Bold"�6�   $y�Hidden=�6�   �� 5B   
   -   5        $��Siguiente_CGSimulacion��5B      $��	Siguiente��60   $
��Left=�6a   $��42��6|   $��592,617,0,0q�6�   $	��Top=�6�   $��88��6�   $ 
1.36,0.738&�6�   $��16(�6�   $��Segoe UI Semibold)�6�   $
��Bold"�6  $y�Hidden=�6"  �� 5F   
   -   5        $��IniciarSimulacion��5F      $
��Left=�6)   $ Forever��6D   $$ Imagenes\IniciarSimulacion.gif��6o   $	��227��6�   $��748,385,0,0q�6�   $	��Top=�6�   $	��395��6�   $$��Imagenes/IniciarSimulacion.gif��6�   $y�Hidden=�6   �� 5G   
   -   5        $��SimularMall��5G      $
��Left=�6#   $ Forever��6>   $ Imagenes\SimularMall.gif��6i   $	��227��6�   $��
58,200,0,0q�6�   $	��Top=�6�   $	��395��6�   $��Imagenes/SimularMall.gif��6�   $ 1.833,1.855&�6  $y�Hidden=�61  �� 5H   
   -   5        $��Editar��5H      $
��Left=�6   $ Forever��69   $ Imagenes\Editar.gif��6d   $	��227��6�   $��824,385,0,0q�6�   $	��Top=�6�   $	��269��6�   $��Imagenes/Editar.gif��6�   $y�Hidden=�6�   �� 5I   
   -   5        $��SeleccionEditar��5I      $
��Left=�6'   $ Forever��6B   $" Imagenes\SeleccionEditar.gif��6m   $	��227��6�   $��
58,200,0,0q�6�   $	��Top=�6�   $	��395��6�   $"��Imagenes/SeleccionEditar.gif��6�   $y�Hidden=�6  �� 5K   
   -   5        $��
textBlock6��5K      $
��Wrap=�6&   ���	#FFF7F7F7$��473,222,99,262q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   Simular Mall:�� 5L      /-1.- Se debe tener un mall creado previamente.�� 5M   ;   LJ2.- Para simular un mall se debe elegir uno y luego seleccionar "Simular".�� 5N   X   5O      �� 5Q   
   -   5        $��
textBlock7��5Q      $
��Wrap=�6&   ���	#FFF7F7F7$��160,427,439,43q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   #!Iniciar y Termino de Simulación:�� 5R   /   @>1.- Para iniciar una simulacion se debe seleccionar "Iniciar".�� 5S   L   ><2.- La simulacion solo se detendra al seleccionar "Detener".�� 5T   J   ca3.- Una vez detenida la simulación si seleccionamos "Detener" nuevamente se volvera a el inicio.�� 5V   %   GE4.- ADVERTENCIA al volver al inicio se borarran los datos anteriores.�� 5W   S   5X      �� 5Z   
   -   5        $��
textBlock8��5Z      $
��Wrap=�6&   ���	#FFF7F7F7$��473,222,99,322q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   Seleccionar para Editar:�� 5[   '   ��1.- Al estar en una simulación podemos editar los valores de ciertas tiendas para ello se debe elegir una tienda y seleccionar "Editar".�� 5]   Q   5^      �� 5`   
   -   5        $��
textBlock9��5`      $
��Wrap=�6&   ���	#FFF7F7F7$��226,432,373,74q�6Q   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   	Editar:�� 5a      ��1.- Al seleccionar una tienda a editar saldran los valores que tiene, los que podrán ser modificados al cambiar los valores y haber seleccionando "Guardar".�� 5d   &   _]2.-ADVERTENCIA una vez cambiado los valores no se tendrá registro de los valores anteriores.�� 5f   1   5g      �� 5i   
   -   5        $��Anterior_ManejoSimulacion��5i      $��Anterior��62   $
��Left=�6d   $��42��6   $��473,617,0,0q�6�   $	��Top=�6�   $��88��6�   $��16(�6�   $��Segoe UI Semibold)�6�   $
��Bold"�6�   $y�Hidden=�6  �� 5j   
   -   5        $ ��Siguiente_ManejoSimulacion��5j      $��	Siguiente��64   $
��Left=�6i   $��42��6�   $��592,617,0,0q�6�   $	��Top=�6�   $��88��6�   $ 
1.36,0.738&�6�   $��16(�6�   $��Segoe UI Semibold)�6�   $
��Bold"�6  $y�Hidden=�6*  �� 5n   
   -   5        $��	CrearPiso��5n      $
��Left=�6!   $ Forever��6<   $ Imagenes\CrearPiso.gif��6g   $	��227��6�   $��748,385,0,0q�6�   $	��Top=�6�   $	��395��6�   $$��Imagenes/IniciarSimulacion.gif��6�   $y�Hidden=�6  �� 5o   
   -   5        $��	CrearMall��5o      $
��Left=�6!   $ Forever��6<   $ Imagenes\CrearMall.gif��6g   $	��227��6�   $��
58,200,0,0q�6�   $	��Top=�6�   $	��395��6�   $��Imagenes/SimularMall.gif��6�   $ 1.833,1.855&�6  $y�Hidden=�6-  �� 5p   
   -   5        $��
EditarMall��5p      $
��Left=�6"   $ Forever��6=   $ Imagenes\EditarMall.gif��6h   $	��227��6�   $��748,385,0,0q�6�   $	��Top=�6�   $	��395��6�   $$��Imagenes/IniciarSimulacion.gif��6�   $y�Hidden=�6  �� 5q   
   -   5        $��CrearTienda��5q      $
��Left=�6#   $ Forever��6>   $ Imagenes\CrearTienda.gif��6i   $	��227��6�   $��
58,200,0,0q�6�   $	��Top=�6�   $	��395��6�   $��Imagenes/SimularMall.gif��6�   $ 1.833,1.855&�6  $y�Hidden=�61  �� 5s   
   -    5        $��textBlock10��5s      $
��Wrap=�6'   ���	#FFF7F7F7$��473,222,99,262q�6R   $��20(�6k   $��Segoe UI Semibold)�6y   $y�Hidden=�6�   Crear Mall:�� 5t      vt1.- Al seleccionar "Crear" se habrira una ventana para crear el mall en donde se debe rellenar los valores pedidos .�� 5v   ,   yw2.- Una vez rellenados los valores se debe seleccionar "Crear" para confirmar o "Cancelar" para volver al menu inicial.�� 5x   5   5y      �� 5{   
   -!   5        $��textBlock11��5{      $
��Wrap=�6'   ���	#FFF7F7F7$��58,427,439,57q�6R   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   Crear Pisos:�� 5|      \Z1.- Al crear el mall se pediran los valores para crear los pisos correspondientes al mall.�� 5~   '   nl2.- Para confirmar se debe seleccionar "Crear" y para volver a crear el mall se debe seleccionar "Cancelar".�� 5�   -   [Y3.- ADVERTENCIA los pisos superiores no pueden tener una mayor area que el piso inferior.�� 5�      5�      �� 5�   
   -"   5        $��textBlock12��5�      $
��Wrap=�6'   ���	#FFF7F7F7$��473,222,99,322q�6R   $��20(�6k   $��Segoe UI Semibold)�6y   $y�Hidden=�6�   Crear Tiendas:�� 5�      ^\1.- Al confirmar el piso creado se pedira todos los valores para crear cada tienda del piso.�� 5�   #   FD2.- Se pedira crear todos las tiendas determinadas al crear el piso.�� 5�   R   TR3.- ADVERTENCIA la suma del area de cada tienda no puede superar el area del piso.�� 5�      5�      �� 5�   
   -#   5        $��textBlock13��5�      $
��Wrap=�6'   ���	#FFF7F7F7$��87,449,512,57q�6R   $��20(�6j   $��Segoe UI Semibold)�6x   $y�Hidden=�6�   Editar Mall:�� 5�      ^\1.- Para editar un mall se debe seleccionar un mall en el menu inicial y seleccionar editar.�� 5�   !   b`2.-ADVERTENCIA solo se pueden editar los valores del mall NO los valores de los pisos o tiendas.�� 5�   %   5�      �� 5�   
   -$   5        $��Anterior_ManejoMall��5�      $��Anterior��6,   $
��Left=�6X   $��42��6s   $��473,617,0,0q�6   $	��Top=�6�   $��88��6�   $��16(�6�   $��Segoe UI Semibold)�6�   $
��Bold"�6�   $y�Hidden=�6�   �� 5�   
   -%   5        $��Siguiente_ManejoMall��5�      $��	Siguiente��6.   $
��Left=�6]   $��42��6x   $��592,617,0,0q�6�   $	��Top=�6�   $��88��6�   $ 
1.36,0.738&�6�   $��16(�6�   $��Segoe UI Semibold)�6�   $
��Bold"�6  $y�Hidden=�6  5�      5�      