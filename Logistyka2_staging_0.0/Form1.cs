using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;


namespace Logistyka2_staging_0._0
{
    public partial class Form1 : Form
    {
        private int obiektCounter = 0;
        private List<TextBox> poprzednieList = new List<TextBox>();
        private List<TextBox> nastepneList = new List<TextBox>();
        private List<TextBox> czasNList = new List<TextBox>();
        private List<TextBox> czasGList = new List<TextBox>();
        private List<TextBox> kosztNList = new List<TextBox>();
        private List<TextBox> kosztGList = new List<TextBox>();
        private MainObiekt obiekt;
        private string czasKoncowy;
        private string koszt;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            if (obiektCounter > 15)
            {
                MessageBox.Show("za dużo tego!!!");
                return;
            }

            TextBox multi1 = new TextBox();
            multi1.Width = 105;
            flowLayoutPanel1.Controls.Add(multi1);
            poprzednieList.Add(multi1);

            TextBox multi2 = new TextBox();
            multi2.Width = 100;
            flowLayoutPanel1.Controls.Add(multi2);
            nastepneList.Add(multi2);

            TextBox multi3 = new TextBox();
            multi3.Width = 70;
            flowLayoutPanel1.Controls.Add(multi3);
            czasNList.Add(multi3);

            TextBox multi4 = new TextBox();
            multi4.Width = 70;
            flowLayoutPanel1.Controls.Add(multi4);
            czasGList.Add(multi4);

            TextBox multi5 = new TextBox();
            multi5.Width = 77;
            flowLayoutPanel1.Controls.Add(multi5);
            kosztNList.Add(multi5);

            TextBox multi6 = new TextBox();
            multi6.Width = 77;
            flowLayoutPanel1.Controls.Add(multi6);
            kosztGList.Add(multi6);

            obiektCounter++;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void licz_button_Click(object sender, EventArgs e)
        {
            obiekt = new MainObiekt();
            obiekt.krawedzie = new List<Obiekt>();
            try
            {
                obiekt.czasDocelowy = Int32.Parse(TimeBox.Text);
                for (int i = 0; i < obiektCounter; i++)
                {
                    obiekt.krawedzie.Add(new Obiekt
                    {
                        poprzednie = Int32.Parse(poprzednieList[i].Text),
                        nastepne = Int32.Parse(nastepneList[i].Text),
                        czasNormalny = Int32.Parse(czasNList[i].Text),
                        czasGraniczny = Int32.Parse(czasGList[i].Text),
                        kosztNormalny = Convert.ToDouble(kosztNList[i].Text),
                        kosztGraniczny = Convert.ToDouble(kosztGList[i].Text),

                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawny format danych");
                return;
            }

            using (StreamWriter w = new StreamWriter("ObiektList.json"))
            {
                var convertedJson = JsonConvert.SerializeObject(obiekt, Formatting.Indented);
                w.Write(convertedJson);
            }

            pythonoweCuda();
            CzasLabel.Text = "Skrócono czas do:";
            CzasResult.Text = czasKoncowy;
            KosztLabel.Text = "Koszt skrócenia:";
            KosztResult.Text = koszt;    
        }

        private void pythonoweCuda()
        {
            bool Laptop = false;
            string python = "";
            string myPythonApp = "";
            if (Laptop)
            {
                // full path of python interpreter 
                python = @"C:\Users\Aku\venv\logistyka\Scripts\python.exe";

                // python app to call 
                myPythonApp = @"C:\Users\Aku\Documents\logistyka_1\Logistyka_Transport\LogistykaTransport\sum.py";
            }
            else
            {
                python = "python";
                myPythonApp = @"C:\Users\admin\Source\Repos\ProjektLogistyka\Logistyka2_staging_0.0\graph.py";

            }

            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            // start python app with 3 arguments  
            // 1st arguments is pointer to itself,  
            // 2nd and 3rd are actual arguments we want to send 
            myProcessStartInfo.Arguments = myPythonApp;

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            Console.WriteLine("Calling Python script with arguments\n {0}", myProcessStartInfo.Arguments);
            // start the process 
            myProcess.Start();

            // Read the standard output of the app we called.  
            // in order to avoid deadlock we will read output first 
            // and then wait for process terminate: 
            StreamReader myStreamReader = myProcess.StandardOutput;
            czasKoncowy= myStreamReader.ReadLine(); //tu podaj czas
            koszt = myStreamReader.ReadLine(); //tu podaj koszt

            myProcess.WaitForExit();
            myProcess.Close();

            // write the output we got from python app 
            Console.WriteLine("Value received from script: " + czasKoncowy + "\n\n");
            Console.WriteLine("Value received from script: " + koszt + "\n\n");
            Console.WriteLine();
        }
    }
}
