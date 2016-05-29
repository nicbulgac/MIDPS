//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;

unsigned int S=0;
unsigned int M=0;
unsigned int H=0;
int n=1;
int is_set=0;

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
        Label4->Caption=Date();
        ListBox1->ItemHeight=17;
        Label5->Caption=Time();
        Button3->Enabled=false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{

     S+=1;
     if (S==60)
     {M+=1; S=0; Beep(750,10);}
     if (M==60)
     {H+=1; M=0;}
     if (H==24)
     {H=0;}

     String s;
     String m;
     String h;

     if (S/10==0){ s="0"+IntToStr(S); } else { s=IntToStr(S); }
     if (M/10==0){ m="0"+IntToStr(M); } else { m=IntToStr(M); }
     if (H/10==0){ h="0"+IntToStr(H); } else { h=IntToStr(H); }

     Label1->Caption = h+":"+m+":"+s;
     

     Button3->Enabled=true;
     Button4->Enabled=true;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
   if(is_set==0){
        Timer1->Enabled = true;
        is_set=1;
        Button3->Enabled = true;
        Button4->Enabled = true;
   }else{
        Timer1->Enabled = false;
        is_set=0;
        Button4->Enabled = false;
   }

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
   Timer1->Enabled = false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
    Timer1->Enabled = false;
    Button3->Enabled = false;
    Button4->Enabled = false;
    is_set=0;
    S=0;
    M=0;
    H=0;
    Label1->Caption = "00:00:00";
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
     String s;
     String m;
     String h;
     String val_s;

     if (S/10==0){ s="0"+IntToStr(S); } else { s=IntToStr(S); }
     if (M/10==0){ m="0"+IntToStr(M); } else { m=IntToStr(M); }
     if (H/10==0){ h="0"+IntToStr(H); } else { h=IntToStr(H); }

        val_s=" "+IntToStr(n)+")"+h+":"+m+":"+s+"\n";
        ListBox1->Items->Add(val_s);
        n++;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
      Label4->Caption=Date();
      Label5->Caption=Time();
}
//---------------------------------------------------------------------------

