using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using askPetMDReporting.Controllers;
using askPetMDReporting.Models;

namespace askPetMDReporting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            JanrainLookup._start = startingDate.Value.ToShortDateString();
            JanrainLookup._end = endingDate.Value.ToShortDateString();
            var r = JanrainLookup.UserCount();
            totalAccount.Text = r.Count.ToString();
            var x = JanrainLookup.PetCount();
            petResultsLabel.Text = x.Count.ToString();
        }

        //private bool ValidateDate(string date)
        //{
        //    try
        //    {
        //        string[] dateParts = date.Split('/');
        //        DateTime testDate = new 
        //            DateTime(Convert.ToInt32(dateParts[2]),
        //            Convert.ToInt32(dateParts[0]),
        //            Convert.ToInt32(dateParts[1]));

        //        return true;
        //    }
        //    catch
        //    {
        //        errorMessage.Text = "Please enter a date in the following format: MM/DD/YY or MM-DD-YY.";
        //        return false;
        //    }
        //}

        
    }
}

    
    

