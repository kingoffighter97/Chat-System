   M S B A M L   `   `   `  ����D  @MsgClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MsgClient	MsgClient  5   	       MsgClient.Lobby   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MsgClient     5   	   -   5          � 
ResizeMode$  NoResize=�5   	    � Title$ Lobby��5   	   $	��500��6   $	��450��6$   .��5      � .+�5   
   �� -   5         ��Name$ lblServerName��5      $��[Server Name]��6'   $��Center=�6?   $��	0,6,0,414q�6d   $��24(�6w   $��Center=�6�   $	��444��6�   �� 5   
   -   5        $ lblChatName��5      $��[Chat Name]��6%   $��Center=�6;   $��
0,57,0,373q�6_   $��41��6s   $��16(�6   $��Italic$�6�   �� 5   
   -   5         ��Name$ lbOnlineUsers��5      $��Center=�6)   $��84,126,82,59q�6M   6c   �� 5   
   -   5         ��Name$ btnRefreshOnlineList��5      $��Refresh��6/   $
��Left=�6A   $��174,417,0,0q�6\   $	��Top=�6q   $	��102��6�   $��31��6�   6�   �� 5   
   -   5        $ lblOnlineUsers��5      $��Online Users��6(   $��Center=�6?   $
��Left=�6c   $��
84,100,0,0q�6~   $	��Top=�6�   $	��278��6�   $
��Bold"�6�   5      5      