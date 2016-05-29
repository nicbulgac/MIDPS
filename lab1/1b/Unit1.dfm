object Form1: TForm1
  Left = 192
  Top = 152
  Width = 489
  Height = 240
  Caption = 'MIDPS 1-a'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  ShowHint = True
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 44
    Top = 16
    Width = 363
    Height = 21
    Caption = 'Incrementare decrementare  contor'
    Font.Charset = RUSSIAN_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Courier New'
    Font.Style = []
    ParentFont = False
  end
  object RadioButton2: TRadioButton
    Left = 44
    Top = 52
    Width = 113
    Height = 17
    Caption = 'Pas 1'
    Checked = True
    TabOrder = 0
    TabStop = True
  end
  object RadioButton3: TRadioButton
    Left = 44
    Top = 80
    Width = 113
    Height = 17
    Caption = 'Pas 5'
    TabOrder = 1
  end
  object RadioButton4: TRadioButton
    Left = 44
    Top = 108
    Width = 113
    Height = 17
    Caption = 'Pas 10'
    TabOrder = 2
  end
  object RadioButton5: TRadioButton
    Left = 44
    Top = 136
    Width = 113
    Height = 17
    Caption = 'Pas 100'
    TabOrder = 3
  end
  object Button1: TButton
    Left = 180
    Top = 100
    Width = 121
    Height = 33
    Hint = 'Decrementarea rezultatului'
    Caption = 'Decrementare'
    TabOrder = 4
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 316
    Top = 100
    Width = 121
    Height = 33
    Hint = 'Incrementarea rezultatului'
    Caption = 'Incrementare'
    TabOrder = 5
    OnClick = Button2Click
  end
  object RadioButton6: TRadioButton
    Left = 44
    Top = 164
    Width = 49
    Height = 17
    Hint = 'Introduceti o valoarea proprie'
    Caption = 'Altul'
    TabOrder = 6
  end
  object Edit1: TEdit
    Left = 88
    Top = 160
    Width = 53
    Height = 21
    TabOrder = 7
    OnChange = Edit1Change
    OnClick = Edit1Click
  end
  object Edit2: TEdit
    Left = 184
    Top = 52
    Width = 249
    Height = 32
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 8
    Text = '0'
  end
  object Button3: TButton
    Left = 184
    Top = 152
    Width = 257
    Height = 29
    Hint = 'Iesire din program'
    Caption = 'Iesire'
    TabOrder = 9
    OnClick = Button3Click
  end
end
