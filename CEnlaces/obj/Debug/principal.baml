   M S B A M L   `   `   `  ����  CEnlaces    CEnlaces.principal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CALCULO ENLACES��5   	   $	��450��6!   $	��600��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_    � Icon$ imagenes/ACERCA (2).png��6u    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $+ %/ReuxablesLegacy;component/candy.xaml?�6%   %    5
      .��5      � $	��419��6   $��Bottom=�6   .+�5   
   � $
��Left=�6   $	��372��6*   $	��Top=�67   $	��582��6O   #��� ��6[   .+�5      �� $
��Left=�6   $	��362��64   $��
0,57,0,-47q�6A   $	��Top=�6U   $	��582��6m   #��� ��6y   .@�5      �� $
��PIRE��6   .��5      � ���	#FFF0F7F7$��0,0,0,-2q�62   .+�5      �� -   5         ��Name$ txtPotenciaTx��5   �    � ToolTip$! Potencia Antena Transmisora��6"   $
��Left=�6H   $��23��6c   $��165,101,0,0q�6o   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��305��6�   �� 5      $��Calcular PIRE��6    $
��Left=�68   $��	20,70,0,0q�6S   $	��Top=�6f   �� 5      -   5        $ txtPerdidaCables��5   �   $ -perdida en cables��6"   $
��Left=�6?   $��23��6Z   $��165,129,0,0q�6f   $
	 Wrap=�6{   $	��Top=�6�   $	��305��6�   �� 5      -   5        $ txtPerdidaConectoresTx��5   �   $ -perdida en conectores��6"   $
��Left=�6C   $��23��6^   $��165,157,0,0q�6j   $
	 Wrap=�6   $	��Top=�6�   $	��305��6�   �� 5      -   5        $ txtGananciaTx��5   �   $' !Ganancia de la antena transmisora��6"   $
��Left=�6N   $��23��6i   $��165,185,0,0q�6u   $
	 Wrap=�6�   $	��Top=�6�   $	��305��6�   �� 5      $��Potencia Ptx��6    $
��Left=�67   $��	20,98,0,0q�6R   $	��Top=�6e   $	��130��6}   �� 5      $��Perdida Cables Tx��6    $
��Left=�6<   $��
20,129,0,0q�6W   $	��Top=�6k   $	��130��6�   �� 5      $��Perdida Conectores Tx��6    $
��Left=�6@   $��
20,154,0,0q�6[   $	��Top=�6o   $	��130��6�   �� 5      $��Ganacia Anetna��6    $
��Left=�69   $��
20,180,0,0q�6T   $	��Top=�6h   $	��130��6�   �� 5      -   5        
 ��Name$
 btnCalcularPIRE��5   O   $��Calcular��6!   $
��Left=�64   $��318,213,0,0q�6h   $	��Top=�6}   $��75��6�   6�   �� 5      -   5        $��Cancelar��5   !   $
��Left=�6I   $��398,213,0,0q�6d   $	��Top=�6y   $��75��6�   5      5      �� 5      $	��FSL��6   $
��Left=�6'   $��20��6B   $	��Top=�6N   $��55��6f   .��5      � ���	#FFF0F7F7 � ColumnDefinitions 5       �� 5!      $��5* �6/   �� 5"      $
��283* �6/   .+�5$      �� -   5        $ txtDistancia��5$   �   $  ��6"   $
��Left=�6-   $��23��6H   $��155.333,101,0,0q�6T   $
	 Wrap=�6m   $	��Top=�6�   $	��367��6�   $��1��6�   �� 5%      $��Calcular FSL��6    $
��Left=�67   $��10.333,70,0,0q�6R   $	��Top=�6i   $��1��6�   �� 5&      -   5        $ txtFrecuencia��5&   �   $ -perdida en cables��6"   $
��Left=�6?   $��23��6Z   $��155.333,129,0,0q�6f   $
	 Wrap=�6   $	��Top=�6�   $	��367��6�   $��1��6�   �� 5'      $��Distancia KM o M��6    $
��Left=�6;   $��10.333,98,0,0q�6V   $	��Top=�6m   $	��130��6�   $��1��6�   �� 5(      $��Frecuencia Mhz��6    $
��Left=�69   $��10.333,129,0,0q�6T   $	��Top=�6l   $	��130��6�   $��1��6�   �� 5)      -	   5        $
 btnCalcularFSL��5)   O   $��Calcular��6!   $
��Left=�64   $��361.333,157,0,0q�6g   $	��Top=�6�   $��75��6�   $��1��6�   �� 5*      -
   5        $��Cancelar��5*   !   $
��Left=�6K   $��447.333,157,0,0q�6f   $	��Top=�6   $��75��6�   $��1��6�   5+      5,      �� 5-      $	��RSL��6   $
��Left=�6'   $��20��6B   $��Bottom=�6N   $��55��6i   $��	-2,-2,0,2q�6t   ��5.      �� 5/       �� EndPoint$	 0,1&�6.    �� 
StartPoint$	 0,0&�6=   .��50      �  � Color$ 	#FFF0F0F0��6+    � Offset$ 0Q�6=   � 51      $ 	#FFF0F7F7��6+   $ 1Q�6=   52      .��54      � ���	#FFF0F7F7.+�55      �� $��Calcular RSL��6    $
��Left=�67   $��12,6,0,0q�6R   $	��Top=�6d   $��29��6|   $��78��6�   �� 56      $
��PIRE��6    $
��Left=�6/   $��	11,41,0,0q�6J   $	��Top=�6]    J� RenderTransformOrigin$ 0.184,-0.346&�6u   $��29��6�   $��35��6�   �� 57      $	��FSL��6    $
��Left=�6.   $��	11,75,0,0q�6I   $	��Top=�6\   $��29��6t   $��30��6�   �� 58      $��Perdida Cables��6    $
��Left=�69   $��
11,117,0,0q�6T   $	��Top=�6h   $��27��6�   $��93��6�   �� 59      $��Perdida Conectores��6    $
��Left=�6=   $��
11,156,0,0q�6X   $	��Top=�6l   $��27��6�   $	��119��6�   �� 5:      $	��GRX��6    $
��Left=�6.   $��
11,191,0,0q�6I   $	��Top=�6]   $��30��6u   $��34��6�   �� 5;      -   5        $ txtPIRE��5;   r   $
��Left=�6"   $��25��6=   $��
154,41,0,0q�6I   $
	 Wrap=�6]   $	��Top=�6�   $	��342��6�   �� 5<      -   5        $ txtFSL��5<   r   $
��Left=�6"   $��25��6=   $��
154,79,0,0q�6I   $
	 Wrap=�6]   $	��Top=�6�   $	��342��6�   �� 5=      -   5        $ txtPerdidadCablesRSL��5=   s   $
��Left=�6"   $��26��6=   $��154,120,0,0q�6I   $
	 Wrap=�6^   $	��Top=�6�   $	��342��6�   �� 5>      -   5        $ txtPerdidaconectoresRSL��5>   s   $
��Left=�6"   $��26��6=   $��154,156,0,0q�6I   $
	 Wrap=�6^   $	��Top=�6�   $	��342��6�   �� 5?      -   5        $	 GRX��5?   s   $
��Left=�6"   $��26��6=   $��154,192,0,0q�6I   $
	 Wrap=�6^   $	��Top=�6�   $	��342��6�   �� 5@      -   5        $��Calcular��5@   !   $
��Left=�64   $��324,223,0,0q�6O   $	��Top=�6d   $��79��6|   $��23��6�   �� 5A      -   5        $��Cancelar��5A   !   $
��Left=�64   $��421,223,0,0q�6O   $	��Top=�6d   $��75��6|   $��23��6�   6�   5B      5C      �� 5D      $��MD��6   $
��Left=�6&   $��20��6A   $	��Top=�6M   $��55��6e   .��5E      � ���	#FFF0F7F7.+�5F      �� $	��RSL��6    $
��Left=�6.   $��	15,22,0,0q�6I   $	��Top=�6\   �� 5G      $&�� Sensibilidad del receptor en dBi��6    $
��Left=�6K   $��	15,60,0,0q�6f   $	��Top=�6y   $ -0.123,-0.577&�6�   �� 5H      -   5        $��txtMDRSL��5H   q   $
��Left=�6"   $��23��6=   $��
202,22,0,0q�6I   $
	 Wrap=�6]   $	��Top=�6�   $	��319��6�   �� 5I      -   5        $��txtSensibilidadReceptor��5I   q   $
��Left=�6"   $��23��6=   $��
202,60,0,0q�6I   $
	 Wrap=�6]   $	��Top=�6�   $	��319��6�   �� 5J      -   5        $��btnCalcularMD��5J   Q   $��Calcular��6!   $
��Left=�6f   $��
366,88,0,0q�6�   $	��Top=�6�   $��75��6�   �� 5K      -   5        $��btnCancelarMD��5K   P   $��Cancelar��6!   $
��Left=�6e   $��
446,88,0,0q�6�   $	��Top=�6�   $��75��6�   5L      5M      �� 5N      $��Zona Fresnel��6   $
��Left=�60   $��20��6K   $	��Top=�6W   $��86��6o   $��-2,-2,-29,0q�6z   ��5O      �� 5P      $	 0,1&�6.   $	 0,0&�6=   .��5Q      � $ 	#FFF0F0F0��6+   $ 0Q�6=   � 5R      $ 	#FFF0F7F7��6+   $ 1Q�6=   5S      .��5U      � ���	#FFF0F7F7.+�5V      �� $��Distancia D1��6    $
��Left=�67   $��	17,12,0,0q�6R   $	��Top=�6e   $	��131��6}   �� 5W      $��Distancia D2��6    $
��Left=�67   $��	17,43,0,0q�6R   $	��Top=�6e   $��75��6}   �� 5X      $��Frecuencia Mhz��6    $
��Left=�69   $��
17,110,0,0q�6T   $	��Top=�6h   $��95��6�   �� 5Y      $��Distancia D��6    $
��Left=�66   $��	17,79,0,0q�6Q   $	��Top=�6d   �� 5Z      -   5        $��txtDistancia1Fresnel��5Z   =   $
��Left=�6"   $��23��6Y   $��
148,12,0,0q�6e   $
	 Wrap=�6y   $	��Top=�6�   $	��358��6�   �� 5[      -   5        $��txtDistancia2Fresnel��5[   =   $
��Left=�6"   $��23��6Y   $��
148,44,0,0q�6e   $
	 Wrap=�6y   $	��Top=�6�   $	��358��6�   �� 5\      -   5        $��txtDistanciaDFresnel��5\   =   $
��Left=�6"   $��23��6Y   $��
148,81,0,0q�6e   $
	 Wrap=�6y   $	��Top=�6�   $	��358��6�   �� 5]      -   5        $��txtFrecuenciaFresnel��5]   =   $
��Left=�6"   $��23��6Y   $��148,113,0,0q�6e   $
	 Wrap=�6z   $	��Top=�6�   $	��358��6�   �� 5^      -   5        $��btnCalcularFresnel��5^   U   $��Calcular��6!   $
��Left=�6o   $��358,141,0,0q�6�   $	��Top=�6�   $��75��6�   �� 5_      -   5        $��btnCancelarFresnel��5_   U   $��Cancelar��6!   $
��Left=�6o   $��443,141,0,0q�6�   $	��Top=�6�   $��75��6�   5`      5a      �� 5b      $��
Resultados��6   $
��Left=�6.   $��20��6I   $	��Top=�6U   $��76��6m   $��-2,-2,-19,0q�6x   .��5c      � ���	#FFF0F7F7.+�5d      �� -   5        $��lblMensajePIRE��5d   V   $
��PIRE��6    $
��Left=�6/   $��28��6J   $��	10,10,0,0q�6l   $	��Top=�6   $	��298��6�   �� 5e      -   5         ��Name$ lblMensajeFSL��5e   U   $	��FSL��6    $
��Left=�6.   $��28��6I   $��	10,38,0,0q�6l   $	��Top=�6   $	��298��6�   �� 5f      -   5        $��lblMensajeRSL��5f   .   $	��RSL��6    $
��Left=�6D   $��	10,71,0,0q�6_   $	��Top=�6r   $	��292��6�   �� 5g      -   5        $��lblMensajeMD��5g   -   $��MD��6    $
��Left=�6A   $��
10,102,0,0q�6\   $	��Top=�6p   �� 5h      -    5        $��lblMensajeFresnel��5h   2   $��Fresnel��6    $
��Left=�6K   $��
10,133,0,0q�6f   $	��Top=�6z   $ 	0.079,0.5&�6�   5i      5j      5k      �� 5l      -!   5        $
��Left=�5l   4   $��38��6O   $	��Top=�6[   $	��126��6s   $��0,11,0,0q�6   .+�5m      �� $��38��6   $��50��6$   $��imagenes/casa2.png��6/   �� 5n      $��Inicio��6    �� Left$ 63��6)   
 �� Top$ 4��6:   $��20(�6I   
�������6W   5o      5p      5r      5s      