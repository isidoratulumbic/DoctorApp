   M S B A M L   `   `   `  ����B  >SIMSKT3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SIMSKT3.View.DoctorSIMSKT3.View.Doctor  5   	   C&clr-namespace:SIMSKT3.ValidationDoctorSIMSKT3.ValidationDoctor  5   	   1clr-namespace:SIMSKT3.KomandeSIMSKT3.Komande  5   	   %    SIMSKT3.View.Doctor.LogInDoctor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SIMSKT3.View.Doctor     5   	   6loc&clr-namespace:SIMSKT3.ValidationDoctor     5   	   -cmdclr-namespace:SIMSKT3.Komande     5   	     � WindowStartupLocation$  CenterScreen=�5	      |�.  � Title$ LogIn��5
   	   $	��768��6   $
��1024��6$   ���	#FFD0B8E5 J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cmd:RoutedCommands.LogIn��5      6v   .��5      � -   5         �Name$ LogIn��5      $��0,0,0,-6q�6   .+�5   
   �� ���	#FFA694B7$��Center=�6%   $	��322��6B   
���   �$	��Top=�6^   $	��560��6v   $��	0,167,0,0q�6�   �� 5   
   -   5         ��Name$ username��5   L      errorTemplate =� ErrorTemplate# [  6   $��Center=�6^   $��25(�6{   $��35��6�   $��	0,243,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��302��6�   .��6�   ��5      �� 5       �� Path$ Letters�6   	 �� ValidatesOnDataErrors	 . 
 �� UpdateSourceTrigger$
 PropertyChanged=�6F    �� ValidationRules 5      0   *SIMSKT3.ValidationDoctor.MinimumNumberRule  5         MinimumCharacters$ 3��60   1   +SIMSKT3.ValidationDoctor.PasswordValidation  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�61   5      .��5      5      �� 5   
   -   5         ��Name$ btnlogin��5      ���	#FF8AB3F0$��LogIn (Ctrl+L)��6:   $��25(�6S   $��Center=�6a   $��52��6~   $��	0,519,0,0q�6�   $	��Top=�6�   $	��302��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ���	#FF262C61���	#FF262C61z�5      V� 5       .~�5!      ��  �� ScaleY$ 1Q�6%   �� 5"      �� 5#      T� 5$      5%      5'      G� 5)   
   -   5         G�Name$ password��5)      $��Center=�6(   $��25(�6E   $��35��6S   $��	0,364,0,0q�6_   $	��Top=�6r   $	��302��6�   �� 5+   
   $��LOGIN��6   $
��Left=�6    $��
440,27,0,0q�6;   $��35(�6O   $��Times New Roman)�6]   $	��Top=�6z   ���	#FF262C616�   �� 5,   
   ���	#FF262C61$��1q�6)   $��Center=�6=   $��1��6Z   $��0,82,0,0q�6e   $	��Top=�6w   $	��424��6�   �� 5-   
   $��Username��6   $
��Left=�6#   $��25(�6>   $��440,199,0,0q�6L   $	��Top=�6a   $��Arial)�6y   ���	#FF262C616�   �� 5.   
   $��Password��6   $
��Left=�6#   $��25(�6>   $	��Top=�6L   $��443,320,0,0q�6d   $��Arial)�6y   ���	#FF262C616�   �� 5/   
   $��19,5,881,649q�6   $��0��6&   $&�� /View/Doctor/Images/hospital.png��66   $ 	0.525,0.5&�6`    J� OpacityMask 50      �� 51       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��52      �  � Color$ 	#FFBE5050��6#   � 53      $ 	#FFD0B8E5��6#    � Offset$ 1Q�65   � 54      $ 	#FFD0B8E5��6#   $ 1Q�65   55      57      �� 58   
   ���	#FF0059DF$��Forgot username?��6(   $��Italic$�6C   $
��Left=�6V   $��545,278,0,0q�6q   $	��Top=�6�   $��14(�6�   �� 59   
   ���	#FF0059DF$��Forgot password?��6'   $��Italic$�6B   $
��Left=�6V   $��548,399,0,0q�6q   $	��Top=�6�   $��14(�6�   �� 5:   
   -   5        $ greska��5:      ���	#FFD0B8E5���	#FFD0B8E5$
��Left=�6Q   $��56��6l   $��
399,92,0,0q�6x   $
 Wrap=�6�   $	��Top=�6�   $	��216��6�   $��15(�6�   $ 0.5,0.5&�6�   .��6�   z�5;      V� 5<      .~�5=      �� �� 5>      �� 5?       �� Angle$ -0.394Q�6&   T� 5@      5A      .��5B   '   5C      5D      5E      