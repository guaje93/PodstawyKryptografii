   M S B A M L   `   `   `  ����G  COne-Time-Pad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Converters
Converters  5          View.FileCrypt   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      #convclr-namespace:Converters  5        � 	Resources  5         Converters.KeyPConverter   keyPConverter&    Converters.ByteToStringConverter  byteToStringConverter��%:   &	        &	        5      6     5      6   5      .��5      �� .+�5      �� $��Wczytaj plik��6   $	��350��6"   $��20(�6.   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $	��380��6   $��50��5   	    �� TextWrapping$
 Wrap=�5      " �� VerticalScrollBarVisibility$
 Auto=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Wiadomość w pliku��5       % !MaterialDesignFloatingHintTextBox#��[ 5      ��5      �� *75ElGamalManager.OriginalMessageFactory.OperationStatus+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      
�������$��FileMessage��5      ��5      �� *LoadCommand+.��5       �� $/��)pack://application:,,,/Resources/load.png��6   $��25��5!   
   $��25��5"   
   5#      �� 5%      
�������$��HashFile��5'      $��SHA-256��5(      $��57��5)      $��12(�5*      $��0q�5+      
���   ���5&      �� *HashCommand+5,      5/      �� 51      $ 
Horizontal=�6   .+�52      �� $	��380��6   $��50��53   
   $
 Wrap=�54      $
 Auto=�55      $ Skrót wiadomości��56      #��[ 57      ��58      �� *0.ElGamalManager.MessageFactory.FileMessage.Hash+ �� 	Converter# [ $ TwoWay=�$ PropertyChanged=��� 5:      
�������$
��Hash��5<      ��5;      �� *LoadCommand+.��5=      �� $/��)pack://application:,,,/Resources/load.png��6   $��25��5>   
   $��25��5?   
   5@      �� 5B      
�������$��HashFile��5D      ��5C      �� *SaveCommand+.��5E      �� $/��)pack://application:,,,/Resources/save.png��6   $��25��5F   
   $��25��5G   
   5H      5J      �� 5K      $ 
Horizontal=�6   .+�5L      �� $	��120��6   $��30��5M      $
��file��5O      $��Szyfruj��5P      ��5N      �� *EncryptCommand+5P      �� 5Q      $	��170��6   $��30��5R      $
��file��5T      $��Deszyfruj wiadomosc��5U      ��5S      �� *DecryptCommand+5U      5V      �� 5X      $ 
Horizontal=�6   .+�5Y      �� $	��380��6   $��50��5Z   
   $
 Wrap=�5[      $
 Auto=�5\      $ C1��5]      #��[ 5^      ��5_      �� *:8ElGamalManager.MessageFactory.CipheredFileMessage.HashC1+# [ $ TwoWay=�$ PropertyChanged=��� 5a      
�������$��C1��5c      ��5b      �� *LoadCommand+.��5d      �� $/��)pack://application:,,,/Resources/load.png��6   $��25��5e   
   $��25��5f   
   5g      �� 5i      
�������$��C1��5k      ��5j      �� *SaveCommand+.��5l      �� $/��)pack://application:,,,/Resources/save.png��6   $��25��5m   
   $��25��5n   
   5o      5q      �� 5s      $ 
Horizontal=�6   .+�5t      �� $	��380��6   $��50��5u   
   $
 Wrap=�5v      $
 Auto=�5w      $ C2��5x      #��[ 5y      ��5z      �� *:8ElGamalManager.MessageFactory.CipheredFileMessage.HashC2+# [ $ TwoWay=�$ PropertyChanged=��� 5|      
�������$��C2��5~      ��5}      �� *LoadCommand+.��5      �� $/��)pack://application:,,,/Resources/load.png��6   $��25��5�   
   $��25��5�   
   5�      �� 5�      
�������$��C2��5�      ��5�      �� *SaveCommand+.��5�      �� $/��)pack://application:,,,/Resources/save.png��6   $��25��5�   
   $��25��5�   
   5�      5�      5�      5�      