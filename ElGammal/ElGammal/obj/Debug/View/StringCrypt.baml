   M S B A M L   `   `   `  ����G  COne-Time-Pad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Converters
Converters  5          View.StringCrypt   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      )convclr-namespace:Converters     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � 	Resources  5
         Converters.KeyPConverter   keyPConverter(   "Converters.BigIntToStringConverter  bigIntToStringConverter&    Converters.ByteToStringConverter  byteToStringConverter��%W   &	        &	      &	 &       5      6     5      6!     5      6   5      .��5      �� .+�5      �� .+�5      �� $��Wpisz tekst��6   $��20(�5   	   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $
��Left=�6   $	��100��5      $	��400��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Wiadomość tekstowa��5       % !MaterialDesignFloatingHintTextBox#��[ 5       �� TextWrapping$
 Wrap=�5      " �� VerticalScrollBarVisibility$
 Auto=�5      ��5      �� *=;ElGamalManager.OriginalMessageFactory.OriginalStringMessage+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      
�������$��
HashString��5      $��SHA-256��5      $��57��5       $��12(�5!      $��0q�5"      
���   ���5      �� *HashCommand+5#      5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $
��Left=�6   $	��400��5'      $��50��5(      $ Skrót wiadomości��5)      #��[ 5*      $
 Wrap=�5,      $
 Auto=�5-      ��5+      �� *20ElGamalManager.MessageFactory.StringMessage.Hash+ �� 	Converter# [ $ TwoWay=�$ PropertyChanged=�5-      �� 5.      
�������$��
HashString��50      ��5/   
   �� *SaveCommand+.��51      �� $/��)pack://application:,,,/Resources/save.png��6   $��25��52      $��25��53      54      55      �� 56      $ 
Horizontal=�6   .+�58      �� $	��120��6   $��30��59      $��string��5;      $��Szyfruj��5<      ��5:      �� *EncryptCommand+5<      �� 5=      $	��170��6   $��30��5>      $��string��5@      $��Deszyfruj wiadomosc��5A      ��5?      �� *DecryptCommand+5A      5B      �� 5C      $ 
Horizontal=�6   .+�5D      �� -   5         ��Name$ CipherBoxC1��5D      $��50��5E      $	��400��5F      $ C1��5G      #��[ 5H      $
 Wrap=�5J      $
 Auto=�5K      ��5I      �� *<:ElGamalManager.MessageFactory.CipheredStringMessage.HashC1+$ TwoWay=�# [ $ PropertyChanged=�5K      5L      �� 5N      $ 
Horizontal=�6   .+�5O      �� $��50��6   $	��400��5P      $ C2��5Q      #��[ 5R      $
 Wrap=�5T      $
 Auto=�5U      ��5S      �� *<:ElGamalManager.MessageFactory.CipheredStringMessage.HashC2+# [ $ TwoWay=�$ PropertyChanged=�5U      5V      5X      5Y      5Z      