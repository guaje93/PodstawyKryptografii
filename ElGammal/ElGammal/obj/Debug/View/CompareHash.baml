   M S B A M L   `   `   `  ����G  COne-Time-Pad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5      'clr-namespace:Converters
Converters  5          View.CompareHash   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:View     5      )convclr-namespace:Converters     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � 	Resources  5
         Converters.KeyPConverter   keyPConverter(   "Converters.BigIntToStringConverter  bigIntToStringConverter&    Converters.ByteToStringConverter  byteToStringConverter��%W   &	        &	      &	 &       5      6     5      6!     5      6   5      .��5      �� .+�5      �� $
��Left=�6   $��50��5      $	��800��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Odszyfrowany skrót��5       % !MaterialDesignFloatingHintTextBox#��[ 5       �� TextWrapping$
 Wrap=�5      " �� VerticalScrollBarVisibility$
 Auto=�5      ��5      �� *+)ElGamalManager.HashComparer.DecryptedHash+ �� 	Converter# [  �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��50��6   $	��800��5      $ Wczytany skrót��5      #��[ 5      $
 Wrap=�5      $
 Auto=�5      ��5      �� **(ElGamalManager.HashComparer.OriginalHash+# [ $ TwoWay=�$ PropertyChanged=�5      �� 5       
�������$��Comparer��5"      ��5!      �� *LoadCommand+.��5#      �� $/��)pack://application:,,,/Resources/load.png��6   $��25��5$   
   $��25��5%   
   5&      5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $
��Left=�6   $��30��5*      $	��100��5+      $��	Porównaj��5-      ��5,      �� *CompareHashCommand+5-      �� 5.      $��50��6   $	��800��5/      $ Wynik porównania��50      #��[ 51      $
 Wrap=�53      $
 Auto=�54       �� 
IsReadOnly . ��52      �� **(ElGamalManager.HashComparer.StringResult+$ TwoWay=�$ PropertyChanged=�55      56      57      58      