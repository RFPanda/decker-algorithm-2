   M S B A M L   `   `   `  ����F  BALG_Dekkera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ALG_DekkeraALG_Dekkera  5   	       ALG_Dekkera.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ALG_Dekkera     5   	     � Title$  Algorithm Dekkera��5   	   $	��748��6#   $
��1280��60    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S   .��5	      � ���	#FF6F6F6F$	��732��6"   $	��Top=�6/    � ColumnDefinitions 5
   
   �� 5      $
��125* �6   �� 5      $
��304* �6   �� 5      $
��851* �6   .+�5   
   �� -   5         ��Name$ Button_1��5      $��Установка f1��6#   $
��Left=�6:   $��44��6U   $��	48,40,0,0q�6a   $	��Top=�6t   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��6/  ��6�   Z� 6/  �� 5   
   -   5         ��Name$	 TB1��5      $
��Left=�6   $	��129��6:   $��
48,485,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��212��6�   $
��Bold"�6�   $��Bahnschrift SemiLight)�6�   $��15(�6�   $��Italic$�6�   
���   �
����������	#FF06ED00$��2��6'  $��Waiting... ... ...��67  �� 5   
   -   5        $��Проверка f1��5      $
��Left=�6'   $��44��6B   $��	48,89,0,0q�6N   $	��Top=�6a   $	��212��6y   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6  �� 5   
   -   5        $ 	Button1_6��5      $(��"Выход из критич уч.��6$   $
��Left=�6B   $��44��6]   $��
48,285,0,0q�6i   $	��Top=�6}   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6  $��20(�6  
���   �$��2��68  ��6�   Z� 68  �� 5   
   -   5        $ 	Button1_5��5      $$��Вход в критич уч.��6$   $
��Left=�6@   $��44��6[   $��
48,236,0,0q�6g   $	��Top=�6{   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6  $��20(�6  
���   �$��2��66  ��6�   Z� 66  �� 5   
   -   5        $��Проверка zr��5      $
��Left=�6'   $��44��6B   $��
48,138,0,0q�6N   $	��Top=�6b   $	��212��6z   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6  �� 5   
   -   5        $ 	Button1_4��5      $��Установка zr��6$   $
��Left=�6;   $��44��6V   $��
48,187,0,0q�6b   $	��Top=�6v   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��61  ��6�   Z� 61  �� 5   
   -   5        $ 	Button1_8��5      $��Cброс f1��6$   $
��Left=�67   $��44��6R   $��
48,383,0,0q�6^   $	��Top=�6r   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��6-  ��6�   Z� 6-  �� 5   
   -	   5        $ 	Button1_7��5      $��Сброс zr��6$   $
��Left=�67   $��44��6R   $��
48,334,0,0q�6^   $	��Top=�6r   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��6-  ��6�   Z� 6-  �� 5   
   -
   5        $ Button_2��5      $��Установка f2��6#   $��Center=�6:   $��44��6W   $��0,40,0,0q�6c   $	��Top=�6u   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��60  ��6�   Z� 60  �� 5   
   -   5        $	 TB2��5      $��Center=�6   $	��129��6<   $��	0,485,0,0q�6I   $
 Wrap=�6\   $	��Top=�6p   $	��212��6�   $��Bahnschrift SemiLight)�6�   $��15(�6�   $
��Bold"�6�   $��Italic$�6�   
���   �
����������	#FF06ED00$��2��6(  $��Waiting... ... ...��68  �� 5   
   -   5        $ 	Button2_6��5      $(��"Выход из критич уч.��6$   $��Center=�6B   $��44��6_   $��	0,285,0,0q�6k   $	��Top=�6~   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6  $��20(�6  
���   �$��2��6:  ��6�   Z� 6:  �� 5   
   -   5        $ 	Button2_5��5      $$��Вход в критич уч.��6$   $��Center=�6@   $��44��6]   $��	0,236,0,0q�6i   $	��Top=�6|   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6  $��20(�6  
���   �$��2��68  ��6�   Z� 68  �� 5   
   -   5        $ 	Button2_4��5      $��Установка zr��6$   $��Center=�6;   $��44��6X   $��	0,187,0,0q�6d   $	��Top=�6w   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��62  ��6�   Z� 62  �� 5   
   -   5        $ 	Button2_8��5      $��Cброс f2��6$   $��Center=�67   $��44��6T   $��	0,383,0,0q�6`   $	��Top=�6s   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��6/  ��6�   Z� 6/  �� 5   
   -   5        $ 	Button2_7��5      $��Сброс zr��6$   $��Center=�67   $��44��6T   $��	0,334,0,0q�6`   $	��Top=�6s   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6  
���   �$��2��6/  ��6�   Z� 6/  �� 5   
   -   5        $��Проверка f2��5      $��Center=�6'   $��44��6D   $��0,89,0,0q�6P   $	��Top=�6b   $	��210��6z   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6  �� 5    
   -   5        $��Проверка zr��5       $��Center=�6'   $��44��6D   $��	0,138,0,0q�6P   $	��Top=�6c   $	��212��6{   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6  �� 5!   
   $��	Console 1��6   $
��Left=�6$   $��
48,441,0,0q�6?   $	��Top=�6S   $��Bahnschrift SemiLight)�6k   $��24(�6�   $��2��6�   $��39��6�   $	��110��6�   �� 5"   
   $��	Console 2��6   $
��Left=�6$   $��326,441,0,0q�6?   $	��Top=�6T   $��Bahnschrift SemiLight)�6l   $��24(�6�   $��2��6�   $��39��6�   $	��116��6�   �� 5#   
   $0��*Лабораторная
работа №2��6   $
��Left=�65   $��	25,39,0,0q�6P   $	��Top=�6c   $��Bahnschrift SemiLight)�6{   $��40(�6�   $	��116��6�   $	��309��6�   ���	#FFE5E5E5$
��Left=�6�   $��2��6�   �� 5$   
   $L��Fпо дисциплине: 
"операционные системы"��6   $
��Left=�6T   $��
25,137,0,0q�6o   $	��Top=�6�   $��Bahnschrift SemiLight)�6�   $��24(�6�   $��88��6�   $	��309��6�   ���	#FFE5E5E5$
��Left=�6�   $��2��6  �� 5%   
   $w��qВыполнили:
Студенты гр. 4203
Абдулхаев Роберт Р.
Хасанов Айнур А.��6   $
��Left=�6h   $��
25,566,0,0q�6�   $	��Top=�6�   $��Bahnschrift SemiLight)�6�   $��24(�6�   $	��128��6�   $	��309��6�   ���	#FFE5E5E5$
��Left=�6  $��2��62   J� IsHitTestVisible$ False��6F  �� 5&   
   $
��Left=�6   $��	7,-2,0,-7q�6/   
���   �$��4��6Q   
���   �$��2��6h   �� 5'   
   -   5        $ Button_3��5'      $��Установка f3��6#   $
��Left=�6:   $��44��6U   $��
599,40,0,0q�6a   $	��Top=�6u   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6)  �� 5(   
   -   5        $	 TB3��5(      $
��Left=�6   $	��129��6:   $��599,485,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��212��6�   $��Bahnschrift SemiLight)�6�   $��15(�6�   $
��Bold"�6�   $��Italic$�6�   
���   �
����������	#FF07F601$��2��6(  $��Waiting... ... ...��68  �� 5)   
   -   5        $ 	Button3_6��5)      $(��"Выход из критич уч.��6$   $
��Left=�6B   $��44��6]   $��599,285,0,0q�6i   $	��Top=�6~   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6   
���   �$��2��6"  ��6�   Z� 62  �� 5*   
   -   5        $ 	Button3_5��5*      $$��Вход в критич уч.��6$   $
��Left=�6@   $��44��6[   $��599,236,0,0q�6g   $	��Top=�6|   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6   ��6�   Z� 60  �� 5+   
   -   5        $ 	Button3_4��5+      $��Установка zr��6$   $
��Left=�6;   $��44��6V   $��599,187,0,0q�6b   $	��Top=�6w   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6+  �� 5,   
   -   5        $ 	Button3_8��5,      $��Cброс f3��6$   $
��Left=�67   $��44��6R   $��599,383,0,0q�6^   $	��Top=�6s   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6'  �� 5-   
   -   5        $ 	Button3_7��5-      $��Сброс zr��6$   $
��Left=�67   $��44��6R   $��599,334,0,0q�6^   $	��Top=�6s   $	��212��6�   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6'  �� 5.   
   -   5        $��Проверка f3��5.      $
��Left=�6'   $��44��6B   $��
599,89,0,0q�6N   $	��Top=�6b   $	��211��6z   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6  �� 5/   
   -   5        $��Проверка zr��5/      $
��Left=�6'   $��44��6B   $��599,138,0,0q�6N   $	��Top=�6c   $	��212��6{   
���   �$��Bahnschrift SemiLight)�6�   $
��Bold"�6�   $��20(�6�   
���   �$��2��6  ��6�   Z� 6  �� 50   
   $��	Console 3��6   $
��Left=�6$   $��599,441,0,0q�6?   $	��Top=�6T   $��Bahnschrift SemiLight)�6l   $��24(�6�   $��2��6�   $��39��6�   $	��116��6�   �� 51   
   -   5        $	 TB4��51      $
��Left=�6   $��321,636,0,0q�6:   $
 Wrap=�6O   $	��490��6c   $��Bahnschrift SemiLight)�6o   $��15(�6�   $
��Bold"�6�   $��Italic$�6�   
���   �
����������	#FF07F601$��2��6  $��59��6  $	��Top=�6  �� 52   
   -   5         ��Name$ Label4��52      $��Process bar��6    $
��Left=�66   $��
48,647,0,0q�6Q   $	��Top=�6e   $��Bahnschrift SemiLight)�6}   $��24(�6�   $��2��6�   $��39��6�   $	��212��6�   �� 53   
   $
��Left=�6   $��48,694,0,37q�6/   
�������$	��763��6S   
�������$��2��6l   �� 54   
   $
��Left=�6   $��
48,636,0,0q�6/   
�������$��1��6R   
�������$��2��6i   $��59��6y   $	��Top=�6�   �� 55   
   $
��Left=�6   $��
49,636,0,0q�6/   
�������$	��761��6R   
�������$��2��6k   $��1��6{   $	��Top=�6�   57      58      