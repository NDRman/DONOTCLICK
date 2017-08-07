using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace UnitConvertor
{
    public partial class MainForm : MaterialForm
    {
        public static class Globals
        {
            
            public static Dictionary<string, double> units = new Dictionary<string, double>();

        }

        public static class Globals2
        {

            public static MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            

        }

        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Globals.units.Add("mtpa", 1);
            Globals.units.Add("tcm", 0.00138026224);
            Globals.units.Add("tcf", 0.0487);
            Globals.units.Add("mmbtu", 52000000);
            Globals.units.Add("mwh", 14447205);
            Globals.units.Add("therm", 492578990);
            Globals.units.Add("gj", 52009937);
            Globals.units.Add("mmtoe", 1.23);
            Globals.units.Add("mmboe", 8.68);
            Globals.units.Add("bcf", 48.7);
            Globals.units.Add("bcm", 1.38);
            Globals.units.Add("mcf", 48700);
            Globals.units.Add("mcm", 1380);
            Globals2.sc.Language = "VBScript";

        }

        public string Convert(string ConvertFrom, string ConvertTo, double convertVal)
        {
            return RoundToSignificantDigits((convertVal * Globals.units[ConvertTo] / Globals.units[ConvertFrom])).ToString();
        }

        public double RoundToSignificantDigits(double d)
        { 

            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);
            return scale * Math.Round(d / scale, 3);
        }

        private void convertFeets()
        {
            try
            {
                double result = Globals2.sc.Eval(TCF.Text);
                TCM.Text = Convert(CUBICFEET.Text, CUBICMETERS.Text, result);
                MMTOE.Text = Convert(CUBICFEET.Text, "mmtoe", result);
                MTPA.Text = Convert(CUBICFEET.Text, "mtpa", result);
                MMBTU.Text = Convert(CUBICFEET.Text, "mmbtu", result);
                MMBOE.Text = Convert(CUBICFEET.Text, "mmboe", result);
                THERM.Text = Convert(CUBICFEET.Text, "therm", result);
                GJ.Text = Convert(CUBICFEET.Text, "gj", result);
                MWH.Text = Convert(CUBICFEET.Text, "mwh", result);

            }
            catch
            {

                TCM.Text = "";
                MMTOE.Text = "";
                MTPA.Text = "";
                MMBTU.Text = "";
                MMBOE.Text = "";
                THERM.Text = "";
                GJ.Text = "";
                MWH.Text = "";

            }
        }

        private void convertMeters()
        {
            try
            {
                double result = Globals2.sc.Eval(TCM.Text);
                TCF.Text = Convert(CUBICMETERS.Text, CUBICFEET.Text, result);
                MMTOE.Text = Convert(CUBICMETERS.Text, "mmtoe", result);
                MTPA.Text = Convert(CUBICMETERS.Text, "mtpa", result);
                MMBTU.Text = Convert(CUBICMETERS.Text, "mmbtu", result);
                MMBOE.Text = Convert(CUBICMETERS.Text, "mmboe", result);
                THERM.Text = Convert(CUBICMETERS.Text, "therm", result);
                GJ.Text = Convert(CUBICMETERS.Text, "gj", result);
                MWH.Text = Convert(CUBICMETERS.Text, "mwh", result);

            }
            catch
            {

                TCF.Text = "";
                MMTOE.Text = "";
                MTPA.Text = "";
                MMBTU.Text = "";
                MMBOE.Text = "";
                THERM.Text = "";
                GJ.Text = "";
                MWH.Text = "";

            }
        }

        private void MMTOE_TextChanged(object sender, EventArgs e)
        {
            

            if (MMTOE.ContainsFocus)

            {
                
                try
                {
                    double result = Globals2.sc.Eval(MMTOE.Text);
                    TCM.Text = Convert("mmtoe", CUBICMETERS.Text, result);
                    TCF.Text = Convert("mmtoe", CUBICFEET.Text, result);
                    MTPA.Text = Convert("mmtoe", "mtpa", result);
                    MMBTU.Text = Convert("mmtoe", "mmbtu", result);
                    MMBOE.Text = Convert("mmtoe", "mmboe", result);
                    GJ.Text = Convert("mmtoe", "gj", result);
                    MWH.Text = Convert("mmtoe", "mwh", result);
                    THERM.Text = Convert("mmtoe", "therm", result);

                }
                catch
                {

                    TCM.Text = "";
                    TCF.Text = "";
                    MTPA.Text = "";
                    MMBTU.Text = "";
                    MMBOE.Text = "";
                    GJ.Text = "";
                    MWH.Text = "";
                    THERM.Text = "";


                }
            }
        }

        private void MWH_TextChanged(object sender, EventArgs e)
        {
            if (MWH.ContainsFocus)
            {
              
                try
                {
                    double result = Globals2.sc.Eval(MWH.Text);
                    TCM.Text = Convert("mwh", CUBICMETERS.Text, result);
                    TCF.Text = Convert("mwh", CUBICFEET.Text, result);
                    MMTOE.Text = Convert("mwh", "mmtoe", result);
                    MMBTU.Text = Convert("mwh", "mmbtu", result);
                    MMBOE.Text = Convert("mwh", "mmboe", result);
                    MTPA.Text = Convert("mwh", "mtpa", result);
                    GJ.Text = Convert("mwh", "gj", result);
                    THERM.Text = Convert("mwh", "therm", result);

                }
                catch
                {

                    TCM.Text = "";
                    TCF.Text = "";
                    MMTOE.Text = "";
                    MMBTU.Text = "";
                    MTPA.Text = "";
                    MMBOE.Text = "";
                    GJ.Text = "";
                    THERM.Text = "";
                }
            }
        }

        private void THERM_TextChanged(object sender, EventArgs e)
        {
            
            if (THERM.ContainsFocus)
            {

                try
                {
                    double result = Globals2.sc.Eval(THERM.Text);
                    TCM.Text = Convert("therm", CUBICMETERS.Text, result);
                    TCF.Text = Convert("therm", CUBICFEET.Text, result);
                    MMTOE.Text = Convert("therm", "mmtoe", result);
                    MMBTU.Text = Convert("therm", "mmbtu", result);
                    MMBOE.Text = Convert("therm", "mmboe", result);
                    MTPA.Text = Convert("therm", "mtpa", result);
                    GJ.Text = Convert("therm", "gj", result);
                    MWH.Text = Convert("therm", "mwh", result);

                }
                catch
                {

                    TCM.Text = "";
                    TCF.Text = "";
                    MMTOE.Text = "";
                    MMBTU.Text = "";
                    MTPA.Text = "";
                    MMBOE.Text = "";
                    GJ.Text = "";
                    MWH.Text = "";
                }
            }
        }

        private void MTPA_TextChanged(object sender, EventArgs e)
        {
            if (MTPA.ContainsFocus)
            {

                try
                {
                    double result = Globals2.sc.Eval(MTPA.Text);
                    TCM.Text = Convert("mtpa", CUBICMETERS.Text, result);
                    TCF.Text = Convert("mtpa", CUBICFEET.Text, result);
                    MMTOE.Text = Convert("mtpa", "mmtoe", result);
                    MMBTU.Text = Convert("mtpa", "mmbtu", result);
                    MMBOE.Text = Convert("mtpa", "mmboe", result);
                    MWH.Text = Convert("mtpa", "mwh", result);
                    GJ.Text = Convert("mtpa", "gj", result);
                    THERM.Text = Convert("mtpa", "therm", result);

                }
                catch
                {

                    TCM.Text = "";
                    TCF.Text = "";
                    MMTOE.Text = "";
                    MMBTU.Text = "";
                    MMBOE.Text = "";
                    MWH.Text = "";
                    GJ.Text = "";
                    THERM.Text = "";

                }
            }
        }

        private void TCF_TextChanged(object sender, EventArgs e)
        {
               if (TCF.ContainsFocus)
                {

                convertFeets();

                }
        }

        private void GJ_TextChanged(object sender, EventArgs e)
        {
            if (GJ.ContainsFocus)
            {
                
                try
                {
                    double result = Globals2.sc.Eval(GJ.Text);
                    TCM.Text = Convert("gj", CUBICMETERS.Text, result);
                    TCF.Text = Convert("gj", CUBICFEET.Text, result);
                    MMTOE.Text = Convert("gj", "mmtoe", result);
                    MTPA.Text = Convert("gj", "mtpa", result);
                    MMBTU.Text = Convert("gj", "mmbtu", result);
                    MMBOE.Text = Convert("gj", "mmboe", result);
                    THERM.Text = Convert("gj", "therm", result);
                    MWH.Text = Convert("gj", "mwh", result);

                }
                catch
                {

                    TCM.Text = "";
                    MMTOE.Text = "";
                    MTPA.Text = "";
                    MMBTU.Text = "";
                    MMBOE.Text = "";
                    THERM.Text = "";
                    TCF.Text = "";
                    MWH.Text = "";

                }
            }
        }

        private void TCM_TextChanged(object sender, EventArgs e)
        {
            if (TCM.ContainsFocus)
            {
                convertMeters();
            }

            
        }

        private void MMBTU_TextChanged(object sender, EventArgs e)
        {
            if (MMBTU.ContainsFocus)

            {
               
                try
                {
                    double result = Globals2.sc.Eval(MMBTU.Text);
                    TCF.Text = Convert("mmbtu", CUBICFEET.Text, result);
                    MMTOE.Text = Convert("mmbtu", "mmtoe", result);
                    MTPA.Text = Convert("mmbtu", "mtpa", result);
                    TCM.Text = Convert("mmbtu", CUBICMETERS.Text, result);
                    MMBOE.Text = Convert("mmbtu", "mmboe", result);
                    THERM.Text = Convert("mmbtu", "therm", result);
                    GJ.Text = Convert("mmbtu", "gj", result);
                    MWH.Text = Convert("mmbtu", "mwh", result);

                }
                catch
                {

                    TCF.Text = "";
                    MMTOE.Text = "";
                    MTPA.Text = "";
                    TCM.Text = "";
                    MMBOE.Text = "";
                    THERM.Text = "";
                    GJ.Text = "";
                    MWH.Text = "";

                }
            }


        }

        private void MMBOE_TextChanged(object sender, EventArgs e)
        {
            if (MMBOE.ContainsFocus)
            {
                
                try
                {
                    double result = Globals2.sc.Eval(MMBOE.Text);
                    TCF.Text = Convert("mmboe", CUBICFEET.Text, result);
                    MMTOE.Text = Convert("mmboe", "mmtoe", result);
                    MTPA.Text = Convert("mmboe", "mtpa", result);
                    TCM.Text = Convert("mmboe", CUBICMETERS.Text, result);
                    MMBTU.Text = Convert("mmboe", "mmbtu", result);
                    THERM.Text = Convert("mmboe", "therm", result);
                    GJ.Text = Convert("mmboe", "gj", result);
                    MWH.Text = Convert("mmboe", "mwh", result);

                }
                catch
                {

                    TCF.Text = "";
                    MMTOE.Text = "";
                    MTPA.Text = "";
                    TCM.Text = "";
                    MMBTU.Text = "";
                    THERM.Text = "";
                    GJ.Text = "";
                    MWH.Text = "";

                }
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            string tmp;
            if (CUBICFEET.Text == "tcf")
            {
                CUBICFEET.Text = "bcf";
                tmp = "tcf";
            }
            else if (CUBICFEET.Text == "bcf")
            {
                CUBICFEET.Text = "mcf";
                tmp = "bcf";
            }
            else
            {
                CUBICFEET.Text = "tcf";
                tmp = "mcf";
            }

            if (TCF.ContainsFocus)
            {
                convertFeets();
            }
            else
            {
                try
                {
                    TCF.Text = Convert(tmp, CUBICFEET.Text, Globals2.sc.Eval(TCF.Text));
                }
                catch
                {
                    TCF.Text = "";
                }


            }
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {
            string tmp;
            if (CUBICMETERS.Text == "tcm")
            {
                CUBICMETERS.Text = "bcm";
                tmp = "tcm";
            }
            else if (CUBICMETERS.Text == "bcm")
            {
                CUBICMETERS.Text = "mcm";
                tmp = "bcm";
            }
            else
            {
                CUBICMETERS.Text = "tcm";
                tmp = "mcm";
            }

            if (TCM.ContainsFocus)
            {
                convertMeters();
            }
            else
            {
                try
                {
                    TCM.Text = Convert(tmp, CUBICMETERS.Text, Globals2.sc.Eval(TCM.Text));
                }
                catch
                {
                    TCM.Text = "";
                }


            }


        }
    }
}
