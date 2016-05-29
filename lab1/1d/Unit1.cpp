//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
int i=80;
int t=0;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
        Label2->Caption=" "+Date()+"   "+Time();
        Panel2->Caption=" ";

        t=0;
        PaintBox1->Repaint();
        PaintBox1->Canvas->Brush->Style=bsCross;
        PaintBox1->Canvas->Rectangle(0,0,217,169);
        PaintBox1->Canvas->MoveTo(0,80);
        Panel2->Height=169;

        


}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
        Label2->Caption=" "+Date()+"   "+Time();        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
        Timer2->Enabled=true;
        PaintBox1->Canvas->Pen->Color=clRed;
        PaintBox1->Canvas->MoveTo(t,i);

        Button1->Enabled = false;
        Button2->Enabled = true;
        Button4->Enabled=true;
        


}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
        Timer2->Enabled=false;
        Button1->Enabled = true;
        Button2->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer2Timer(TObject *Sender)
{


        t=t+4;
        i=rand() % 150 + 1;
        Panel2->Height=i;
        PaintBox1->Canvas->LineTo(t,i);
        PaintBox1->Canvas->Brush->Style=bsCross;
        PaintBox1->Canvas->Rectangle(0,0,217,169);
        if (t%220==0) {
                PaintBox1->Repaint();
                PaintBox1->Canvas->MoveTo(0,80);
                i=80;
                t=0;
        }

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
        Form1->Close();        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
        if (Timer2->Enabled == true) {
                Button1->Enabled = false;
                Button2->Enabled = true;
        }

        if (Timer2->Enabled == false){
           Button4->Enabled=false;
        }

        t=0;
        PaintBox1->Repaint();
        PaintBox1->Canvas->Brush->Style=bsCross;
        PaintBox1->Canvas->Rectangle(0,0,217,169);
        PaintBox1->Canvas->MoveTo(0,80);
        Panel2->Height=169;

}
//---------------------------------------------------------------------------



