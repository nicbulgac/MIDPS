object Form1: TForm1
  Left = 198
  Top = 155
  Width = 341
  Height = 415
  Caption = 'Form1'
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
    Left = 32
    Top = 156
    Width = 126
    Height = 37
    Hint = 'Valoarea cronometrului'
    Caption = '00:00:00'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -32
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 32
    Top = 92
    Width = 198
    Height = 29
    Caption = 'Cronometru in c++'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label3: TLabel
    Left = 32
    Top = 12
    Width = 114
    Height = 29
    Caption = 'Data si ora'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label4: TLabel
    Left = 32
    Top = 56
    Width = 48
    Height = 20
    Hint = 'Data calculatorului'
    Caption = 'Label4'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label5: TLabel
    Left = 216
    Top = 56
    Width = 48
    Height = 20
    Hint = 'Ora calcuatorului'
    Caption = 'Label5'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Button1: TButton
    Left = 32
    Top = 216
    Width = 125
    Height = 41
    Hint = 'Porneste/opreste cronometrul'
    Caption = 'Start/Stop'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button3: TButton
    Left = 32
    Top = 264
    Width = 125
    Height = 37
    Hint = 'Reseteaza cronometrul'
    Caption = 'Reset'
    Enabled = False
    TabOrder = 1
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 32
    Top = 312
    Width = 125
    Height = 37
    Hint = 'Salveaza valoarea cronometrului'
    Caption = 'Save'
    Enabled = False
    TabOrder = 2
    OnClick = Button4Click
  end
  object ListBox1: TListBox
    Left = 172
    Top = 156
    Width = 129
    Height = 193
    Hint = 'Caseta timpurilor salvate'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ItemHeight = 20
    ParentFont = False
    TabOrder = 3
  end
  object Timer1: TTimer
    Enabled = False
    Interval = 1
    OnTimer = Timer1Timer
    Left = 236
    Top = 92
  end
  object Timer2: TTimer
    OnTimer = Timer2Timer
    Left = 156
    Top = 12
  end
end
