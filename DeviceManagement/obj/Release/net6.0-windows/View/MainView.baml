   M S B A M L   `   `   `  ���� K  GDeviceManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DeviceManagement.ViewDeviceManagement.View  G(clr-namespace:DeviceManagement.ViewModelDeviceManagement.ViewModel  $    DeviceManagement.View.MainView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:DeviceManagement.View     >	viewmodel(clr-namespace:DeviceManagement.ViewModel       � WindowStartupLocation$  CenterScreen=� � Title$ Quản lý thiết bị��$	��700��$
��1300�� � DataContext .   (DeviceManagement.ViewModel.MainViewModel  .���� ._��  � ColumnDefinitions �� $	��250 ��� $��* �.+��� ���#673AB7$��0��._��  � RowDefinitions �� $��84 ��� $��* ��� $	��100 �.+��� $$��../Assets/Images/hust_logo.png��$��0����  �� Orientation$ Vertical=�$��1��.+�	�    NavigationButton#��[  $��Quản lý thiết bị�� 	� 	GroupName$ 
MenuButton�� d� 	IsChecked$
 TrueY����� *DeviceCommand+	� #��[  $��Quản lý phiếu nhập��$ 
MenuButton������ *ImportCommand+	� #��[  $��Quản lý phiếu xuất��$ 
MenuButton������ *ExportCommand+	� #��[  $��Quản lý bảo trì��$ 
MenuButton������ *GuaranteeCommand+	� #��[  $��Quản lý tài khoản��$ 
MenuButton��$��2������ *AccountCommand+� $��1�� �� $��84 ��� $��* �.+�$   DeviceManagement.View.TopPanel  $��0���� $��1��._�(� $��0q�$��Stretch=�$��Stretch=�����  �� 
TargetType" (�.���� ���� *CurrentViewModel+	 � 	Resources	 
 �� DataType1   +DeviceManagement.ViewModel.AccountViewModel'   !DeviceManagement.View.AccountView0  *DeviceManagement.ViewModel.DeviceViewModel&    DeviceManagement.View.DeviceView0   *DeviceManagement.ViewModel.ImportViewModel&    DeviceManagement.View.ImportView0	  *DeviceManagement.ViewModel.ExportViewModel&
    DeviceManagement.View.ExportView3  -DeviceManagement.ViewModel.GuaranteeViewModel)   #DeviceManagement.View.GuaranteeView��%�   (��       *, +)(��      *, +)(�� $     *, +)(�� 6     *,	 +)(�� H     *, +)�� "
  .R�  �� "
  .R�  �� "
  .R�  �� "
 	 .R�
  �� "
  .R�  