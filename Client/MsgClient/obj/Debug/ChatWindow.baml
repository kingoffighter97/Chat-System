   M S B A M L   `   `   `  ����D  @MsgClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MsgClient	MsgClient  5   	       MsgClient.ChatWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MsgClient     5   	   -   5          � Title$  
ChatWindow��5   	   $��330.017��6   $��541.808��6-    � 
ResizeMode$ NoResize=�6V   .��5      � .+�5   
   �� -   5         ��Name$ txtbMessages��5       �� 
IsReadOnly .  �� TextWrapping$
 Wrap=�6:   $	��182��6g   $	��472��6t   $
��Auto=�6�   $��10,30,10,57q�6�   6�   �� 5   
   -   5        $ txtbSendBox��5      $��43��6'   $��10,217,107,9q�63   $
 Wrap=�6I   $	��375��6]   6�   �� 5   
   -   5         ��Name$ btnSend��5      $
��Send��6"   $��394,222,14,14q�62   $��92��6I   $��44��6T   6`   �� 5   
   -   5         ��Name$ lblChattingWith��5      $��Chatting with:��6)   $
��Left=�6B   $��13,0,0,0q�6]   $	��Top=�6o   $��85��6�   $��29��6�   �� 5   
   -   5        $ lblChatters��5      $��[Names of people in chat]��6%   $
��Left=�6I   $��	103,0,0,0q�6d   $	��Top=�6w   $��29��6�   $	��379��6�   5      5      