//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "sPanel"
#pragma resource "*.dfm"
TForm1 *Form1;

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Edit1Change(TObject *Sender)
{
    RadioButton6->Checked=true;
}
//---------------------------------------------------------------------------
 void __fastcall TForm1::Edit1Click(TObject *Sender)
{
     RadioButton6->Checked=true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
    double val;

    if (RadioButton2->Checked) { val=1; }
    if (RadioButton3->Checked) { val=5; }
    if (RadioButton4->Checked) { val=10; }
    if (RadioButton5->Checked) { val=100; }
    if (RadioButton6->Checked) { val=Edit1->Text.ToDouble(); }

    Edit2->Text=Edit2->Text.ToDouble()-val;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
    double val;

    if (RadioButton2->Checked) { val=1; }
    if (RadioButton3->Checked) { val=5; }
    if (RadioButton4->Checked) { val=10; }
    if (RadioButton5->Checked) { val=100; }
    if (RadioButton6->Checked) { val=Edit1->Text.ToDouble(); }

    Edit2->Text=Edit2->Text.ToDouble()+val;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::Button3Click(TObject *Sender)
{
        Form1->Close();        
}
//---------------------------------------------------------------------------

