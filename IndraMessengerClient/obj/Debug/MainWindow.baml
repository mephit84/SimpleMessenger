   M S B A M L   `   `   `  ����O  KIndraMessengerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:IndraMessengerClientIndraMessengerClient  5   	   %    IndraMessengerClient.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:IndraMessengerClient     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��257* �6   �� 5      $
��134* �6   �� 5      $
��126* �6    � RowDefinitions 5   
   �� 5      $	��87* �6   �� 5      $	��25* �6   �� 5      $
��144* �6   �� 5      $	��32* �6   �� 5      $��60 �6   .+�5   
   �� -   5         ��Name$ loginTextbox��5      $��Center=�6(    �� TextWrapping$
 Wrap=�6E   $�� ��6Y   $��Center=�6a   $	��120��6|   �� 5   
   -   5         ��Name$ loginButton��5      $��Login��6&   $��1��66   $��80,28,80,29q�6`   $��2��6u   �� 5   
   -   5         ��Name$ ErrLabel��5      $�� ��6"   $��Center=�6-   $��1��6K   $��Center=�6X   $��124,0,123,0q�6s   $��25��6�   $��10��6�   �� 5   
   -   5        $ datadinascita��5      $��Data di nascita��6'   $��2��6A   $��Center=�6Q   $��1��6n   $��Center=�6{   �� 5   
   -   5        $ email��5      $
��mail��6   $��1��6.   $��Center=�6;   $��Center=�6V   $��1��6t   �� 5   
   -   5         ��Name$ listaUtentiLoggati��5       �� DisplayMemberPath$ Username��6.   $��10q�6K   $��2��6W   $��2��6d   6w   �� 5   
   $��2��6   $��10q�6+   $��1��67   $��2��6H   .��5      �� -   5        	 ��Name$	 messaggi��5      $	��110��6*   $	��240��67   5      �� 5   
   -   5        $ textBoxMessage��5      $��2��6*   $��1��6>   $
��Left=�6N   $��17��6i   $��8,5,0,0q�6u   $��3��6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��242��6�   �� 5    
   -	   5        $ 
sendButton��5       $��2��6%   $��invia��69   $��1��6I   $��Stretch=�6Y   $��10q�6x   $��4��6�   $��Stretch=�6�   6�   �� 5!   
   -
   5        $ recuperaUtentiButton��5!      $��Recupera Utenti��6/   $��Stretch=�6I   $��10q�6h   $��4��6t   $��Stretch=�6�   6�   5#      5$      