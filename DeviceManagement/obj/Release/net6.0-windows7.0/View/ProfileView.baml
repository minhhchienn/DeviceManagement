   M S B A M L   `   `   `  ���� K  GDeviceManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DeviceManagement.ViewDeviceManagement.View  G(clr-namespace:DeviceManagement.ViewModelDeviceManagement.ViewModel  I)clr-namespace:DeviceManagement.ValidationDeviceManagement.Validation  I)clr-namespace:DeviceManagement.ConvertersDeviceManagement.Converters  '    !DeviceManagement.View.ProfileView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:DeviceManagement.View     >	viewmodel(clr-namespace:DeviceManagement.ViewModel     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  :
validation)clr-namespace:DeviceManagement.Validation  9	converter)clr-namespace:DeviceManagement.Converters    � DataContext  1   +DeviceManagement.ViewModel.ProfileViewModel   � 	Resources >   8DeviceManagement.Converters.BooleanToVisibilityConverter    BooleanToVisibilityConverter<   6DeviceManagement.Converters.BooleanToCollapseConverter  BooleanToCollapseConverter��%   &	        &	          .���� 
������� �� CornerRadius$ 10��._��� $	��750��$	��450��._�� .+���  $  MaterialDesignHeadline6TextBlock#��[ $��Hồ sơ���� $ 10��
�������$��1q�$	��100��$	��750��$	��Top=�$��0,40,0,0q�._�� .+�A� $��80��$��80��$
��Left=�$��20,0,0,0q�����  �� ImageSource$B </DeviceManagement;component/Assets/Images/default-avatar.png���� #��[ $	��Top=�$
��Left=�$��
150,10,0,0q����� *Name+��  " MaterialDesignCaptionTextBlock#��[ $	��Top=�$
��Left=�$��
150,40,0,0q����� *Email+�� #��[ $	��Top=�$
��Left=�$��
150,60,0,0q����� *
Position+�� $ 10��
�������$��1q�$	��290��$	��750��$	��Top=�$��	0,160,0,0q�._�� .+��� $��Thông tin cá nhân��   MaterialDesignBody1TextBlock#��[ $��	20,10,0,0q���    MaterialDesignOutlinedButton#��[ $��60��$��30��$��Sửa��$	��Top=�$��Right=�$��	0,10,20,0q�y��� *IsEditingInfo+ �� 	Converter# [  �� UpdateSourceTrigger$ PropertyChanged=����� *EditInfoCommand+�� #��[ $��60��$��30��$��Hủy��$	��Top=�$��Right=�$��	0,10,20,0q�y��� *IsEditingInfo+# [  $ PropertyChanged=����� *CancelEditCommand+��  ! MaterialDesignFlatMidBgButton#��[ $��90��$��30��$��Xác nhận��$	��Top=�$��Right=�$��
0,10,100,0q�y��� *IsEditingInfo+# [  $ PropertyChanged=����� *ConfirmInfoCommand+�� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập�� ! MaterialDesignOutlinedTextBox#��[ $	��Top=�$
��Left=�$��	20,50,0,0q�$	��320��${�False��.������  �� Path$ EditUsername�$ PropertyChanged=� �� ValidationRules 8   2DeviceManagement.Validation.NotEmptyValidationRule  ,  &System.Windows.Controls.ValidationRule	   ValidatesOnTargetUpdated$
	 True��.���� $ Quyền��#��[ $	��Top=�$��Right=�$��	0,50,20,0q�$	��320��${�False��.������ $ EditRole�$ PropertyChanged=�   $
	 True��.���� $ Họ và tên��#��[ $	��Top=�$
��Left=�$��
20,130,0,0q�$	��320��{��� *IsEditingInfo+.������ $ EditName�$ PropertyChanged=�   $
	 True��.���� $ Số điện thoại��#��[ $	��Top=�$��Right=�$��
0,130,20,0q�$	��320��{��� *IsEditingInfo+.������ $ EditPhoneNumber�$ PropertyChanged=�   $
	 True��.���� $ Email��#��[ $	��Top=�$
��Left=�$��
20,210,0,0q�$	��320��{��� *IsEditingInfo+.������ $ 	EditEmail�$ PropertyChanged=�   $
	 True��.���� $ Chức vụ��#��[ $	��Top=�$��Right=�$��
0,210,20,0q�$	��320��{��� *IsEditingInfo+.������ $ EditPosition�$ PropertyChanged=�.��