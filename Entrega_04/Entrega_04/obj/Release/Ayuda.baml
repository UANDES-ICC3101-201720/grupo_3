   M S B A M L   `   `   `  ���� E  AEntrega_04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Entrega_04
Entrega_04      Entrega_04.Ayuda   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Entrega_04     J FWpfAnimatedGif, Version=1.4.15.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com    � Title$  Ayuda��$	��720��$
��1200��.��� ���	#FF000429.+��� -   $��Titulo��$��Manual Sim Mall ��$
��Left=�$��
407,10,0,0q�$	��Top=�$��48(�$��HarvestItal)����	#FFE0DADA$��98��$	��368�� J� RenderTransformOrigin$ 0.524,-0.084&��� -   $��Button_Simular��$!��Cargar y guardar simulacion��$
��Left=�$��306,127,0,0q�$	��Top=�$	��361��$��24(�$��60�����	#FFB0B0B0$��Segoe UI Black)�$ 
0.82,0.437&��� -   $��Button_mall��$��Cargar y guardar mall��$
��Left=�$��	0,127,0,0q�$	��Top=�$	��306��$��24(�$��60�����	#FFB0B0B0$��Segoe UI Black)�$ 
0.508,1.26&��� -   $��Button_manejoSimul��$��Manejo simulacion��$
��Left=�$��667,127,0,0q�$	��Top=�$	��287��$��24(�$��60�����	#FFB0B0B0$��Segoe UI Black)�$ 
0.508,1.26&��� -   $��Button_manejoMall��$��Manejo mall��$
��Left=�$��954,127,0,0q�$	��Top=�$	��238��$��24(�$��60�����	#FFB0B0B0$��Segoe UI Black)�$ 
0.508,1.26&��� -   $��
CargarMall��$
��Left=�"  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��   AnimatedSource$ Imagenes\CargarMall.gif��$	��227��$��711,432,0,0q�$	��Top=�$	��395��$��Imagenes/CargarMall.gif��$ 1.514,1.313&��� -   $��GuardarrMall��$
��Left=�$ Forever��$ Imagenes\GuardarMall.gif��$	��227��$��
58,192,0,0q�$	��Top=�$	��395��$��Imagenes/GuardarMall.gif���� -   $��
textBlock1��$
��Wrap=����	#FFF7F7F7$��492,227,238,297q�$��20(�$��Segoe UI Semibold)�Guardar Mall:�� 421.- Debe existir un mall creado para poder guardar�� IG2.- Todos los malls que existan se guardaran en el archivo seleccionado�� �� -	   $��
textBlock2��$
��Wrap=����	#FFF7F7F7$��218,468,512,43q�$��20(�$��Segoe UI Semibold)�Cargar Mall:�� B@1.- Solo se pueden abrir archivos que fueron guardados como mall�� /-2.- El archivo puede contener más de un mall�� IG3.- ADVERTENCIA al cargar un nuevo mall se perderán los mall anterior.�� �� -
   $��CargarSimulacion��$
��Left=�$ Forever��$# Imagenes\CargarSimulacion.gif��$	��227��$��
58,192,0,0q�$	��Top=�$	��395��$#��Imagenes/CargarSimulacion.gif��$y�Hidden=��� -   $��CargarSimulacion_VentMall��$
��Left=�$ Forever��$, &Imagenes\CargarSimulacion_VentMall.gif��$	��227��$��748,419,0,0q�$	��Top=�$	��395��$,��&Imagenes/CargarSimulacion_VentMall.gif��$y�Hidden=��� -   $��GuardarSimulacion��$
��Left=�$ Forever��$$ Imagenes\GuardarSimulacion.gif��$	��227��$��
58,222,0,0q�$	��Top=�$	��395��$$��Imagenes/GuardarSimulacion.gif��$y�Hidden=��� -   $��
textBlock3��$
��Wrap=����	#FFF7F7F7$��518,234,54,250q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Cargar Simulación:�� ��1.- Si se encuentra en una simulación puede cargar una nueva seleccionando "Cargar" y eligiendo un archivo con una simulación pasada.�� JH2.- ADVERTENCIA al cargar una nueva simulación se perderá la anterior.�� �� -   $��
textBlock4��$
��Wrap=����	#FFF7F7F7$��123,449,449,57q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�" Cargar Simulación desde inicio:�� ��1.- Para cargar una simulación pasada al iniciar el programa puede seleccionar "Cargar Simulación" en donde deberá elegir un archivo de una simulación pasada.�� KI2.- Solo se pueden abrir archivos que fueron guardados como Simulaciones.�� �� -   $��
textBlock5��$
��Wrap=����	#FFF7F7F7$��473,256,99,250q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Guardar Simulación:�� ��1.- Para guardar una simulación realizada puede seleccionar "Guardar" y elegir un archivo en el cual desea guardar la información de la simulación.�� �� -   $��Anterior_CGSimulacion��$��Anterior��$
��Left=�$��42��$��473,617,0,0q�$	��Top=�$��88��$��16(�$��Segoe UI Semibold)�$
��Bold"�$y�Hidden=��� -   $��Siguiente_CGSimulacion��$��	Siguiente��$
��Left=�$��42��$��592,617,0,0q�$	��Top=�$��88��$ 
1.36,0.738&�$��16(�$��Segoe UI Semibold)�$
��Bold"�$y�Hidden=��� -   $��IniciarSimulacion��$
��Left=�$ Forever��$$ Imagenes\IniciarSimulacion.gif��$	��227��$��748,385,0,0q�$	��Top=�$	��395��$$��Imagenes/IniciarSimulacion.gif��$y�Hidden=��� -   $��SimularMall��$
��Left=�$ Forever��$ Imagenes\SimularMall.gif��$	��227��$��
58,200,0,0q�$	��Top=�$	��395��$��Imagenes/SimularMall.gif��$ 1.833,1.855&�$y�Hidden=��� -   $��Editar��$
��Left=�$ Forever��$ Imagenes\Editar.gif��$	��227��$��824,385,0,0q�$	��Top=�$	��269��$��Imagenes/Editar.gif��$y�Hidden=��� -   $��SeleccionEditar��$
��Left=�$ Forever��$" Imagenes\SeleccionEditar.gif��$	��227��$��
58,200,0,0q�$	��Top=�$	��395��$"��Imagenes/SeleccionEditar.gif��$y�Hidden=��� -   $��
textBlock6��$
��Wrap=����	#FFF7F7F7$��473,222,99,262q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Simular Mall:�� /-1.- Se debe tener un mall creado previamente.�� LJ2.- Para simular un mall se debe elegir uno y luego seleccionar "Simular".�� �� -   $��
textBlock7��$
��Wrap=����	#FFF7F7F7$��160,427,439,43q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�#!Iniciar y Termino de Simulación:�� @>1.- Para iniciar una simulacion se debe seleccionar "Iniciar".�� ><2.- La simulacion solo se detendra al seleccionar "Detener".�� ca3.- Una vez detenida la simulación si seleccionamos "Detener" nuevamente se volvera a el inicio.�� GE4.- ADVERTENCIA al volver al inicio se borarran los datos anteriores.�� �� -   $��
textBlock8��$
��Wrap=����	#FFF7F7F7$��473,222,99,322q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Seleccionar para Editar:�� ��1.- Al estar en una simulación podemos editar los valores de ciertas tiendas para ello se debe elegir una tienda y seleccionar "Editar".�� �� -   $��
textBlock9��$
��Wrap=����	#FFF7F7F7$��226,432,373,74q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�	Editar:�� ��1.- Al seleccionar una tienda a editar saldran los valores que tiene, los que podrán ser modificados al cambiar los valores y haber seleccionando "Guardar".�� _]2.-ADVERTENCIA una vez cambiado los valores no se tendrá registro de los valores anteriores.�� �� -   $��Anterior_ManejoSimulacion��$��Anterior��$
��Left=�$��42��$��473,617,0,0q�$	��Top=�$��88��$��16(�$��Segoe UI Semibold)�$
��Bold"�$y�Hidden=��� -   $ ��Siguiente_ManejoSimulacion��$��	Siguiente��$
��Left=�$��42��$��592,617,0,0q�$	��Top=�$��88��$ 
1.36,0.738&�$��16(�$��Segoe UI Semibold)�$
��Bold"�$y�Hidden=��� -   $��	CrearPiso��$
��Left=�$ Forever��$ Imagenes\CrearPiso.gif��$	��227��$��748,385,0,0q�$	��Top=�$	��395��$$��Imagenes/IniciarSimulacion.gif��$y�Hidden=��� -   $��	CrearMall��$
��Left=�$ Forever��$ Imagenes\CrearMall.gif��$	��227��$��
58,200,0,0q�$	��Top=�$	��395��$��Imagenes/SimularMall.gif��$ 1.833,1.855&�$y�Hidden=��� -   $��
EditarMall��$
��Left=�$ Forever��$ Imagenes\EditarMall.gif��$	��227��$��748,385,0,0q�$	��Top=�$	��395��$$��Imagenes/IniciarSimulacion.gif��$y�Hidden=��� -   $��CrearTienda��$
��Left=�$ Forever��$ Imagenes\CrearTienda.gif��$	��227��$��
58,200,0,0q�$	��Top=�$	��395��$��Imagenes/SimularMall.gif��$ 1.833,1.855&�$y�Hidden=��� -    $��textBlock10��$
��Wrap=����	#FFF7F7F7$��473,222,99,262q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Crear Mall:�� vt1.- Al seleccionar "Crear" se habrira una ventana para crear el mall en donde se debe rellenar los valores pedidos .�� yw2.- Una vez rellenados los valores se debe seleccionar "Crear" para confirmar o "Cancelar" para volver al menu inicial.�� �� -!   $��textBlock11��$
��Wrap=����	#FFF7F7F7$��58,427,439,57q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Crear Pisos:�� \Z1.- Al crear el mall se pediran los valores para crear los pisos correspondientes al mall.�� nl2.- Para confirmar se debe seleccionar "Crear" y para volver a crear el mall se debe seleccionar "Cancelar".�� [Y3.- ADVERTENCIA los pisos superiores no pueden tener una mayor area que el piso inferior.�� �� -"   $��textBlock12��$
��Wrap=����	#FFF7F7F7$��473,222,99,322q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Crear Tiendas:�� ^\1.- Al confirmar el piso creado se pedira todos los valores para crear cada tienda del piso.�� FD2.- Se pedira crear todos las tiendas determinadas al crear el piso.�� TR3.- ADVERTENCIA la suma del area de cada tienda no puede superar el area del piso.�� �� -#   $��textBlock13��$
��Wrap=����	#FFF7F7F7$��87,449,512,57q�$��20(�$��Segoe UI Semibold)�$y�Hidden=�Editar Mall:�� ^\1.- Para editar un mall se debe seleccionar un mall en el menu inicial y seleccionar editar.�� b`2.-ADVERTENCIA solo se pueden editar los valores del mall NO los valores de los pisos o tiendas.�� �� -$   $��Anterior_ManejoMall��$��Anterior��$
��Left=�$��42��$��473,617,0,0q�$	��Top=�$��88��$��16(�$��Segoe UI Semibold)�$
��Bold"�$y�Hidden=��� -%   $��Siguiente_ManejoMall��$��	Siguiente��$
��Left=�$��42��$��592,617,0,0q�$	��Top=�$��88��$ 
1.36,0.738&�$��16(�$��Segoe UI Semibold)�$
��Bold"�$y�Hidden=�