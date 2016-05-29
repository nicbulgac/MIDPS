//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "acPNG"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
        Image2->Visible=false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
        if (Edit1->Text=="admin" && Edit2->Text=="parola" ){
          Image1->Visible=false;
          Image2->Visible=true;
          PlaySound(TEXT("start.wav"), NULL , SND_ASYNC);
        }else{
          Image1->Visible=true;
          Image2->Visible=false;
          PlaySound(TEXT("stop.wav"), NULL , SND_ASYNC);
        }
}
//---------------------------------------------------------------------------


