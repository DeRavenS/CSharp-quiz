using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    public delegate void TimerDelegate();
   
    class TimerClass
    {
        private event TimerDelegate TimerEvent;
       
        private Label label;
        private Form form;
        private int gameNum;
        public  Thread timerThread;

        public Label Label { get => label; set => label = value; }
        public Form CurrentForm { get => form; set => form = value; }
        public int GameNum { get => gameNum; set => gameNum = value; }

        public TimerClass()
        {
            
        }
        public TimerClass(Label label, Form form, int gameNum)
        {
            this.Label = label;
            this.CurrentForm = form;
            GameNum = gameNum;
        }

        public void timerMethod()//timer method
        {
            int time = 30;       
            try
            {
                while (time > 0)
                {         
                    Thread.Sleep(1000);
                    time--;
                    CurrentForm.Invoke(new MethodInvoker(delegate () {Label.Text = $"{time}"; }));                    
                }
                TimerDelegate TimerDel = new TimerDelegate(TimerExit);
                TimerEvent += TimerDel;
                TimerEvent.Invoke();//

            }

            catch (Exception e)
            {
               Thread.CurrentThread.Interrupt();//interrupts thread        
            }

        }

        public void TimerExit()
        {
            if (GameNum == 1)
            {
                CurrentForm.Invoke(new MethodInvoker(delegate () { frmGame1.GameEnd(CurrentForm); }));      //Closes Active Form for game 1 
            }
            else
                CurrentForm.Invoke(new MethodInvoker(delegate () { Game2.Game2End(CurrentForm); }));      //Closes Active Form for game 2
        }

    }
}
