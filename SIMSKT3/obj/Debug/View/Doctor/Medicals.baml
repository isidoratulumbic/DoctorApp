   M S B A M L   `   `   `  ����B  >SIMSKT3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SIMSKT3.KomandeSIMSKT3.Komande  5   	   "    SIMSKT3.View.Doctor.Medicals   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -cmdclr-namespace:SIMSKT3.Komande     5   	   |�.   N� Title$  Medicals��5   	   $	��768��6   $
��1024��6'    N� 
Background �	#FFD0B8E5 J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$) #cmd:RoutedCommands.UpdateMedication��5      6�     5   
   -   5        $ cmd:RoutedCommands.SeeAll��5      6y     5   
   -   5        $ cmd:RoutedCommands.Accept��5      6y     5   
   -   5        $  cmd:RoutedCommands.Decline��5      6|   .��5      � $��0,0,2,0q�6   .+�5   
   �� ���	#FFA694B7$��Center=�6%   $	��280��6B   
���   �$	��Top=�6^   $	��738��6v   $��	0,350,0,0q�6�   �� 5   
   $��171,361,565,373q�6   $��0��6)   $ ��/View/Doctor/Images/id.png��69   �� 5   
   $��117,401,507,333q�6   $��0��6)   $'��!/View/Doctor/Images/medicines.png��69   �� 5   
   $��141,445,535,293q�6   $��0��6)   $$��/View/Doctor/Images/status.png��69   �� 5   
   $��135,489,515,243q�6   $��0��6)   $"��/View/Doctor/Images/desc.png��69   �� 5   
   -   5         ��Name$ lv_medicines��5      $��Center=�6)   $	��246��6F   $��0,86,0,0q�6S   $	��Top=�6e   $	��738��6}   ���	#FF262C61���	#FF262C61 �� View 5      �� 5      .P�5      ��  �� Width$ 30��6%   $��ID��60    �� DisplayMemberBinding 6<   �� *id+�� 5      $ 80��6%   $��MEDICINE��60    6B   �� *name+�� 5      $ 80��6%   $��STATUS��60    6@   �� *status+�� 5      $	 310��6%   $��DESCRIPTION��61    6F   �� *description+5      5!      �� 5"   
   $��MEDICATIONS��6   $��35(�6&   $��Times New Roman)�64   $��Center=�6Q   $��0,3,0,0q�6n   $	��Top=�6   $	��312��6�   ���	#FF262C616�   �� 5#   
   -   5        ���	#FFD0B8E5$
��Left=�5#   (   $��48��6C   $��17,4,0,0q�6O   $	��Top=�6a   $��47��6y   $��2��6�   ���	#FF262C61���	#FF262C61.��5$      �� $��24��6   $��30��6    $"��/View/Doctor/Images/back.jpg��6+    J� OpacityMask �	#FF262C616Q   5%      �� 5&   
   $��List of medications:��6   $
��Left=�6/   $��
381,53,0,0q�6J   $	��Top=�6^   ���	#FF262C61$��20(�6�   $��Arial)�6�   �� 5(   
   ���	#FF262C61$��1q�6)   $
��Left=�6=   $��60��6X   $��69,0,0,0q�6d   $	��Top=�6v   $��1��6�   �� 5)   
   ���	#FF262C61$��1q�6)   $
��Left=�6=   $��1��6X   $��
259,50,0,0q�6c   $	��Top=�6w   $	��425��6�   �� 5*   
   $��Validation:��6   $
��Left=�6&   $��665,354,0,0q�6A   $	��Top=�6V   ���	#FF262C61$��15(�6�   �� 5,   
   -   5        $��Medications (Ctrl+W)��5,      ���	#FF8AB3F0$
��Left=�6G   $��
886,86,0,0q�6b   $	��Top=�6v   $	��126��6�   $��30��6�   $��13(�6�   ���	#FF262C61���	#FF262C616�   �� 5-   
   -   5        	 ��Name$	 Textbox1��5-      $
��Left=�6_   $��20��6z   $��438,369,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��186��6�   {�.  ��6$   �� *SelectedItem.id+ �� ElementName$ lv_medicines��6�   �� 5.   
   -	   5        $��Accept (Ctrl+F)��5.      ���	#FF9EE99E$
��Left=�6B   $��651,384,0,0q�6]   $	��Top=�6r   $	��107��6�   $��30��6�   $��13(�6�   ���	#FF262C61���	#FF262C616�   �� 5/   
   $	��ID:��6   $
��Left=�6   $��337,365,0,0q�69   $	��Top=�6N   $��13(�6f   ���	#FF262C616t   �� 50   
   -
   5        $��Decline (Ctrl+R)��50      ���	#FFE39191$
��Left=�6C   $��651,423,0,0q�6^   $	��Top=�6s   $	��107��6�   $��30��6�   $��13(�6�   ���	#FF262C61���	#FF262C616�   �� 51   
   -   5        $��Update (Ctrl+U)��51      ���	#FF8AB3F0$
��Left=�6B   $��716,635,0,0q�6]   $	��Top=�6r   $	��107��6�   $��30��6�   $��13(�6�   ���	#FF262C61���	#FF262C616�   �� 52   
   $��	MEDICINE:��6   $
��Left=�6$   $��337,403,0,0q�6?   $	��Top=�6T   ���	#FF262C61$��13(�6�   �� 53   
   -   5        $	 Textbox2��53   L      errorTemplate =� ErrorTemplate# [  6   $
��Left=�6�   $��24��6�   $��438,406,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��186��6  ��6^   �� *SelectedItem.name+$ lv_medicines��6  �� 56   
   $��DESCRIPTION:��6   $
��Left=�6'   $��337,485,0,0q�6B   $	��Top=�6W   ���	#FF262C61$��13(�6�   �� 57   
   -   5        $	 Textbox3��57      $
��Left=�6h   $	��128��6�   $��438,490,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��186��6�   ��6$   �� *SelectedItem.description+$ lv_medicines��6�   �� 58   
   -   5        $	 status��58      $
��Left=�6a   $��22��6|   $��438,450,0,0q�6�   $

 Wrap=�6�   $	��Top=�6�   $	��186��6�   {�.  ��6"   �� *SelectedItem.status+$ lv_medicines��6�   �� 59   
   $��STATUS:��6   $
��Left=�6"   $��337,445,0,0q�6=   $	��Top=�6R   $��13(�6j   ���	#FF262C616x   5;      5<      