using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //string[] File1 = File.ReadAllLines(@"C:\Users\Thalitha\Desktop\MyData1.txt");
            //string[] myString = File1;
            //string[] myString1 = new string[File1.Length];
            //for (int i = File1.Length; i ==0; i--)
            //{
            //  myString1[i] = myString[i].Substring(myString[i].LastIndexOf("-") + 1, myString[i].Length - myString[i].LastIndexOf("-") - 1);
            //   // MessageBox.Show("Test");
            //}
            // Array.Reverse(myString1);
            //File.WriteAllLines(@"C:\Users\Thalitha\Desktop\MyData9.txt", myString1);
        }








        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");

            string[] File1 = File.ReadAllLines(@"C:\Users\Thalitha\Desktop\MyData1.txt");
            string[] myString = File1;
            string[] myString1 = new string[myString.Length];
          
           // int temp = 0;
            int inc = 0;
            for (int i =myString.Length-1;i>=0;i--)
            {
               
                myString1[inc] = (inc+1)+"-" + myString[i].Substring(myString[i].LastIndexOf("-") + 1, myString[i].Length - myString[i].LastIndexOf("-") - 1);
                inc++;
                //temp++;
              
            }
            File.WriteAllLines(@"C:\Users\Thalitha\Desktop\MyData2.txt", myString1);
            //(temp+1).ToString()+"-"+ 
           
        }
    } 
}
  