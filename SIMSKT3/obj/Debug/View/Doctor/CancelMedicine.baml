   M S B A M L   `   `   `  ����B  >SIMSKT3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SIMSKT3.View.DoctorSIMSKT3.View.Doctor  5   	   1clr-namespace:SIMSKT3.KomandeSIMSKT3.Komande  5   	   (    "SIMSKT3.View.Doctor.CancelMedicine   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SIMSKT3.View.Doctor     5   	   -cmdclr-namespace:SIMSKT3.Komande     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ CancelMedicine��5	   	   $	��753��6    $
��1036��6-   ���	#FFD0B8E5 J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$  cmd:RoutedCommands.Confirm��5      6|   .��5      � $��0,0,2,4q�6    � RowDefinitions 5   
   �� 5      $
��618* �6   �� 5      $	��59* �6   �� 5      $	��56* �6   .+�5   
   �� ���	#FFA694B7$��Center=�6%   $	��322��6B   
���   �$	��Top=�6^   $	��560��6v   $��	0,159,0,0q�6�   �� 5   
   $��Reason:��6   $
��Left=�6"   $��306,260,0,0q�6=   $	��Top=�6R   $��13(�6j   ���	#FF262C61$��27��6�   $��54��6�   �� 5   
   -   5         ��Name$ 	Textbox22��5      $
��Left=�6%   $	��198��6@   $��364,260,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��364��6�   ���	#FF8AB3F0���	#FF262C61 J� RenderTransformOrigin$ 0.509,0.551&�6�   �� 5   
   -   5        $ 	Textbox11��5      $
��Left=�6%   $��23��6@   $��364,205,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��364��6�   {�.  6�   �� 5   
   $��	Medicine:��6   $
��Left=�6$   $��300,201,0,0q�6?   $	��Top=�6T   ���	#FF262C61$��13(�6�   $��27��6�   $��65��6�   �� 5   
   -   5        $��Confirm (Ctrl+P)��5      ���	#FF8AB3F0$
��Left=�6C   $��690,486,0,0q�6^   $	��Top=�6s   $	��107��6�   $��30��6�   $ 0.5,0.5&�6�   ���	#FF262C61���	#FF262C616�   �� 5   
   $��REJECT MEDICINE��6   $��35(�6*   $��Times New Roman)�68   $
��Left=�6U   $��	365,4,0,0q�6p   $	��Top=�6�   $	��312��6�   ���	#FF262C61$��50��6�   �� 5   
   ���	#FF262C61$��1q�6)   $
��Left=�6=   $��1��6X   $��
284,50,0,0q�6c   $	��Top=�6w   $	��425��6�   �� 5   
   $��263,151,734,340q�6   $��0��6)   $'��!/View/Doctor/Images/medicines.png��69   �� 5   
   $��263,260,731,323q�6   $��0��6)   $$��/View/Doctor/Images/reason.png��69   $ 0.5,0.5&�6a   z�5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6%   �� 5       �� 5!      T� 5"      5#      5%      �� 5&   
   -   5        ���	#FFD0B8E5$
��Left=�5&   (   $��48��6C   $��17,4,0,0q�6O   $	��Top=�6a   $��47��6y   ���	#FF262C61.��5'      �� $��24��6   $��30��6    $"��/View/Doctor/Images/back.jpg��6+   	 J� OpacityMask	 �	#FF262C616Q   5(      �� 5)   
   ���	#FF262C61$��1q�6)   $
��Left=�6=   $��60��6X   $��69,0,0,0q�6d   $	��Top=�6v   $��1��6�   5-      5.      