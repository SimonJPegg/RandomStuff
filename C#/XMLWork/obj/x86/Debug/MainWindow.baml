   M S B A M L   `   `   `  ����  XMLWork    XMLWork.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   r   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   -   5        $��XMLDemo��5   E    � Title$7  1This is a demonstration of XML processing in .NET��6	    � OverridesDefaultStyle .  $	��697��6�   $	��632��6   � AllowsTransparency .  � WindowStyle$
 None=�6)  
 � Top$ 20��6<   � WindowStartupLocation$ CenterScreen=�6T  .��5      �  J� IsManipulationEnabled . .+�5   
   �� -   5        $��myScroll��5      $��Disabled=�6'   $
��Auto=�6P   $��Right=�6s   $	��465��6�   $	��634��6�   $��Bottom=�6�   $��
0,0,133,12q�6�   .��5      � -   5        $
��Grid��5      .+�5      �� -   5        $��Display��5      $
��Wrap=�6+   $��Bradley Hand ITC)�6w   $��16(�6�   $��Black"�6�   
�������$��0,6,0,0q�6�   ��6?   ��  �� ElementName$
 Grid�� �� Path$ ActualWidth�Display Area5
      5      5      �� 5   
   -   5        $��ReadXML��5   _   $��Read XML��6   $��24��6$   $
��Left=�60   $��
513,12,0,0q�6K   $	��Top=�6n   $��85��6�   $��Bradley Hand ITC)�6�   $��14(�6�   $
��Bold"�6�   	 � UseLayoutRounding	 .  
 J� Opacity$	
 0.7Q�6�   �� 5   
   -   5        $��WriteXML��5   `   $��	Write XML��6   $��24��6%   $
��Left=�61   $��
513,42,0,0q�6L   $	��Top=�6p   $��85��6�   $��Bradley Hand ITC)�6�   $��14(�6�   $
��Bold"�6�   	 .  $	
 0.7Q�6�   6�   �� 5   
   -   5        $��ParseXML��5   `   $��	Parse XML��6   $��24��6%   $
��Left=�61   $��
513,72,0,0q�6L   $	��Top=�6p   $��85��6�   $��Bradley Hand ITC)�6�   $��14(�6�   $
��Bold"�6�   	 .  $	
 0.7Q�6�   6�   �� 5   
   -   5        $��XPath��5   ]   $��XPath��6   $��24��6!   $
��Left=�6-   $��513,102,0,0q�6H   $	��Top=�6j   $��85��6�   $��Bradley Hand ITC)�6�   $��14(�6�   $
��Bold"�6�   	 .  $	
 0.7Q�6�   6�   �� 5   
   -	   5        $��XPathDoc��5   `   $��XPathDoc��6   $��24��6$   $
��Left=�60   $��513,132,0,0q�6K   $	��Top=�6p   $��85��6�   $��Bradley Hand ITC)�6�   $��14(�6�   $
��Bold"�6�   	 .  $	
 0.7Q�6�   �� 5   
   -
   5        $
��XSLT��5   \   $
��XSLT��6   $��24��6    $
��Left=�6,   $��513,162,0,0q�6G   $	��Top=�6h   $��85��6�   $��Bradley Hand ITC)�6�   $��14(�6�   $
��Bold"�6�   	 .  $	
 0.7Q�6�   6�   �� 5   
   -   5        $
��Exit��5   \   $
��Exit��6   $��24��6    $
��Left=�6,   $��513,192,0,0q�6G   $	��Top=�6h   $��85��6�   $��Bradley Hand ITC)�6�   $��14(�6�   $
��Bold"�6�   	 .  $	
 0.7Q�6�   5      ��5      �� 5   
    �� ImageSource$' !/XMLWork;component/background.png��6    j� Stretch$
 None=�6E    j� TileMode$
 None=�6T   5      