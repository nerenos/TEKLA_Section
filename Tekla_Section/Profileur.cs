using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

using Tekla.Structures;
using TSM = Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.Operations;

namespace Tekla_Section
{
    public partial class Profileur : Form
    {
        int Ligne;
        int LigneCombo;
        string[] TableauPliages;
        string[] TableauCombo;
        string Fichier_Pliages = @"C:\TMP\Pliages.txt";

        Excel.Application objApp;
        Excel._Workbook objBook;

        private static TSM.Model TSModel = new TSM.Model();

        public struct PliageInfo
        {
            public PliageInfo(string Pliage)
            {
                Ligne = -1;
                NombreSegment = 2;
                Libelle = "";
                AngleInitial = "0";
                Epaisseur = "0";
                Valeurs = null;

                Pliage = Pliage.Replace(',', '.');
                string[] TableauChaine = Pliage.Split(';');
                if (TableauChaine.Length >= 0) Ligne = int.Parse(TableauChaine[0]);
                if (TableauChaine.Length >= 1) NombreSegment = int.Parse(TableauChaine[1]);
                if (TableauChaine.Length >= 2) Libelle = TableauChaine[2];
                if (TableauChaine.Length >= 3) AngleInitial = TableauChaine[3];
                if (TableauChaine.Length >= 4) Epaisseur = TableauChaine[4];
                if (TableauChaine.Length >= 5) Valeurs = TableauChaine[5].Split(':');
            }

            public int Ligne { get; set; }
            public int NombreSegment { get; set; }
            public string Libelle { get; set; }
            public string AngleInitial { get; set; }
            public string Epaisseur { get; set; }
            public string[] Valeurs { get; set; }

        }

        public Profileur()
        {
            InitializeComponent();
            InitFenetre();

            if (!TSModel.GetConnectionStatus())
            {
                MsgBox("Erreur de connexion", "Echec de connexion avec le model TEKLA!", MessageBoxButtons.OK);
                Environment.Exit(-1);
            }
            TSM.ModelInfo Info = TSModel.GetInfo();
            TeklaStructuresInfo.GetCurrentProgramVersion();
            this.Text = "Connexion au model " + Info.ModelName;
        }

        private void Modifier_Parametres(object sender, EventArgs e)
        {
            GenererImage();
        }

        private void Sai_nSegments_ValueChanged(object sender, EventArgs e)
        {
            SupprimerSuperChamp();
            InitFenetre();
            GenererImage();
        }

        private void okApplyModifyGetOnOffCancel1_CancelClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void saveLoad1_AttributesLoadClicked(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void COMBO_Pliages_Enter(object sender, EventArgs e)
        {
            List<string> Liste = new List<string>();

            if (File.Exists(Fichier_Pliages))
            {
                TableauPliages = File.ReadAllLines(Fichier_Pliages);
                COMBO_Pliages.Items.Clear();
                foreach (string Pliage in TableauPliages)
                {
                    PliageInfo Infos = new PliageInfo(Pliage);
                    if (Infos.NombreSegment == Sai_nSegments.Value)
                    {
                        COMBO_Pliages.Items.Add(Infos.Libelle);
                        Liste.Add(Pliage);
                    }
                }
                TableauCombo = Liste.ToArray();
            }
        }

        private void BTN_EnregistrerSous_Click(object sender, EventArgs e)
        {
            string ChaineStockage;
            int NombreLigne;

            Verifier_Fichier:
            if(!File.Exists(Fichier_Pliages))
            {
                try
                {
                    FileStream fs = File.Create(Fichier_Pliages);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    if(MsgBox("Erreur à la création du fichier de configuration", ex.ToString(), MessageBoxButtons.RetryCancel) == System.Windows.Forms.DialogResult.Retry)
                    {
                        goto Verifier_Fichier;
                    }
                    Environment.Exit(-1);
                }
            }

            TableauPliages = File.ReadAllLines(Fichier_Pliages);
            NombreLigne = TableauPliages.Length + 1;
            ChaineStockage = NombreLigne.ToString() + ";" + Sai_nSegments.Value.ToString() + ";" + SAI_Pliage.Text + ";" + Sai_AngleInit.Text + ";" + Sai_Epaisseur.Text + ";";
            for(int i = 0; i < ((int)Sai_nSegments.Value - 1); i++)
            {
                ChaineStockage += Tab_Sai_Longueur[i].Text + ":" + Tab_Sai_Angle[i].Text + ":" + Tab_Int_Angle[i].Checked.ToString() + ":";
            }
            ChaineStockage += Tab_Sai_Longueur[(int)Sai_nSegments.Value - 1].Text;
            
            Enregistrer_Fichier:
            try
            {
                StreamWriter fw = File.AppendText(Fichier_Pliages);
                fw.WriteLine(ChaineStockage.Replace('.', ','));
                fw.Close();
            }
            catch (Exception ex)
            {
                if (MsgBox("Erreur à l'enregistrement du fichier de configuration", ex.ToString(), MessageBoxButtons.RetryCancel) == System.Windows.Forms.DialogResult.Retry)
                {
                    goto Enregistrer_Fichier;
                }
                this.Close();
            }
        }

        public DialogResult MsgBox(string Titre, string Message, MessageBoxButtons Buttons)
        {
            return MessageBox.Show(Message, Titre, Buttons);
        }

        public string PointVirgule(string chaine)
        {
            return chaine.Replace('.', ',');
        }

        private void BTN_Charger_Click(object sender, EventArgs e)
        {
            if(COMBO_Pliages.SelectedIndex >= 0)
            {
                PliageInfo Infos = new PliageInfo(TableauCombo[COMBO_Pliages.SelectedIndex]);
                Ligne = Infos.Ligne;
                LigneCombo = COMBO_Pliages.SelectedIndex;
                Sai_AngleInit.Text = Infos.AngleInitial;
                Sai_Epaisseur.Text = Infos.Epaisseur;

                for (int i = 0; i < ((int)Sai_nSegments.Value - 1); i++)
                {
                    Tab_Sai_Longueur[i].Text = Infos.Valeurs[i * 3];
                    Tab_Sai_Angle[i].Text = Infos.Valeurs[(i * 3) + 1];
                    Tab_Int_Angle[i].Checked = (Infos.Valeurs[(i * 3) + 2] == "True");
                }
                Tab_Sai_Longueur[((int)Sai_nSegments.Value - 1)].Text = Infos.Valeurs[((int)Sai_nSegments.Value - 1) * 3];
            }
        }

        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            string ChaineStockage;
            string Texte = "";
            int NombreLigne;

            if (LigneCombo < 0 && !File.Exists(Fichier_Pliages))
            {
                return;
            }

            PliageInfo Infos = new PliageInfo(TableauCombo[LigneCombo]);
            NombreLigne = Infos.Ligne;
                        
            ChaineStockage = NombreLigne.ToString() + ";" + Sai_nSegments.Value.ToString() + ";" + COMBO_Pliages.Text + ";" + Sai_AngleInit.Text + ";" + Sai_Epaisseur.Text + ";";
            for (int i = 0; i < ((int)Sai_nSegments.Value - 1); i++)
            {
                ChaineStockage += Tab_Sai_Longueur[i].Text + ":" + Tab_Sai_Angle[i].Text + ":" + Tab_Int_Angle[i].Checked.ToString() + ":";
            }
            ChaineStockage += Tab_Sai_Longueur[(int)Sai_nSegments.Value - 1].Text;

            TableauPliages = File.ReadAllLines(Fichier_Pliages);
            for(int i= 0; i < TableauPliages.Length; i++)
            {
                PliageInfo MonInfo = new PliageInfo(TableauCombo[i]);
                if (NombreLigne == MonInfo.Ligne)
                {
                    Texte += ChaineStockage + "\r\n";
                }
                else
                {
                    Texte += TableauCombo[i] + "\r\n";
                }
            }

            EnregistrerSous_Fichier:
            try
            {
                StreamWriter fw = new StreamWriter(Fichier_Pliages);
                fw.Write(Texte);
                fw.Close();
            }
            catch (Exception ex)
            {
                if (MsgBox("Erreur à l'enregistrement du fichier de configuration", ex.ToString(), MessageBoxButtons.RetryCancel) == System.Windows.Forms.DialogResult.Retry)
                {
                    goto EnregistrerSous_Fichier;
                }
                this.Close();
            }
        }

        private void COMBO_Pliages_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LigneCombo = COMBO_Pliages.SelectedIndex;
        }

        private void okApplyModifyGetOnOffCancel1_ModifyClicked(object sender, EventArgs e)
        {
            ModifierSection();
        }

        private void ModifierSection()
        {
            string NomProfil = "";
            double Angle = 0;

            switch(Sai_nSegments.Value)
            {
                case 2:
                    NomProfil = "PPA";
                    break;
                case 3:
                    NomProfil = "PPB";
                    break;
                case 4:
                    NomProfil = "PPC";
                    break;
                case 5:
                    NomProfil = "PPD";
                    break;
                case 6:
                    NomProfil = "PPE";
                    break;
                case 7:
                    NomProfil = "PPF";
                    break;
                case 8:
                    NomProfil = "PPG";
                    break;
                case 9:
                    NomProfil = "PPH";
                    break;
                case 10:
                    NomProfil = "PPI";
                    break;
                default:
                    MsgBox("Aucun profile enregistré.", "Attention aucun cas enregistré dans le programme!", MessageBoxButtons.OK);
                    return;
            }

            for (int i = 0; i < ((int)Sai_nSegments.Value - 1); i++)
            {
                NomProfil += Tab_Sai_Longueur[i].Text + "*";
                Angle = double.Parse(Tab_Sai_Angle[i].Text);
                if(Tab_Int_Angle[i].Checked)
                {
                    Angle = -1 * double.Parse(Tab_Sai_Angle[i].Text);
                }
                if(Angle < 0)
                {
                    Angle += 360;
                }
                NomProfil += Angle.ToString() + "*";
            }
            NomProfil += Tab_Sai_Longueur[(int)Sai_nSegments.Value - 1].Text + "*" + Sai_Epaisseur.Text;

            Tekla.Structures.Model.UI.ModelObjectSelector selector = new Tekla.Structures.Model.UI.ModelObjectSelector();
            TSM.ModelObjectEnumerator objects = selector.GetSelectedObjects();
            objects.Reset();
            while (objects.MoveNext())
            {
                TSM.Part monPart = objects.Current as TSM.Part;
                if (monPart != null)
                {
                    monPart.Profile.ProfileString = NomProfil;
                    monPart.Position.Plane = TSM.Position.PlaneEnum.RIGHT;
                    monPart.Position.Rotation = TSM.Position.RotationEnum.TOP;
                    monPart.Position.Depth = TSM.Position.DepthEnum.FRONT;
                    monPart.Position.RotationOffset = double.Parse(Sai_AngleInit.Text);
                    monPart.Modify();
                }
            }
            TSModel.CommitChanges();
        }

        private void okApplyModifyGetOnOffCancel1_Load(object sender, EventArgs e)
        {

        }

        private void okApplyModifyGetOnOffCancel1_GetClicked(object sender, EventArgs e)
        {
            string NomProfil = "";
            bool Charger = true;
            double Angle = 0;

            Tekla.Structures.Model.UI.ModelObjectSelector selector = new Tekla.Structures.Model.UI.ModelObjectSelector();
            TSM.ModelObjectEnumerator objects = selector.GetSelectedObjects();
            objects.Reset();
            while (objects.MoveNext() && Charger)
            {
                TSM.Part monPart = objects.Current as TSM.Part;
                if (monPart != null)
                {
                    NomProfil = monPart.Profile.ProfileString;
                    Sai_AngleInit.Text = Math.Round(monPart.Position.RotationOffset, 6).ToString();

                    switch(monPart.Position.Rotation)
                    {
                        case TSM.Position.RotationEnum.FRONT:
                            Sai_AngleInit.Text = Math.Round(double.Parse(Sai_AngleInit.Text) - 90, 6).ToString();
                            break;
                        case TSM.Position.RotationEnum.TOP:
                            Sai_AngleInit.Text = Math.Round(double.Parse(Sai_AngleInit.Text) + 0, 6).ToString();
                            break;
                        case TSM.Position.RotationEnum.BACK:
                            Sai_AngleInit.Text = Math.Round(double.Parse(Sai_AngleInit.Text) + 90, 6).ToString();
                            break;
                        case TSM.Position.RotationEnum.BELOW:
                            Sai_AngleInit.Text = Math.Round(double.Parse(Sai_AngleInit.Text) + 180, 6).ToString();
                            break;
                    }

                    switch (NomProfil.Substring(0, 3))
                    {
                        case "PPA":
                            Sai_nSegments.Value = 2;
                            break;
                        case "PPB":
                            Sai_nSegments.Value = 3;
                            break;
                        case "PPC":
                            Sai_nSegments.Value = 4;
                            break;
                        case "PPD":
                            Sai_nSegments.Value = 5;
                            break;
                        case "PPE":
                            Sai_nSegments.Value = 6;
                            break;
                        case "PPF":
                            Sai_nSegments.Value = 7;
                            break;
                        case "PPG":
                            Sai_nSegments.Value = 8;
                            break;
                        case "PPH":
                            Sai_nSegments.Value = 9;
                            break;
                        case "PPI":
                            Sai_nSegments.Value = 10;
                            break;
                        default:
                            MsgBox("Aucun profile enregistré.", "Attention aucun cas enregistré dans le programme!", MessageBoxButtons.OK);
                            return;
                    }

                    NomProfil = NomProfil.Substring(3);

                    string[] TableauValeur = NomProfil.Split('*');

                    for (int i = 0; i < ((TableauValeur.Length - 1) / 2); i++)
                    {
                        Tab_Sai_Longueur[i].Text = TableauValeur[i * 2];
                        Angle = double.Parse(TableauValeur[(i * 2) + 1]);
                        if (Angle > 180)
                        {
                            Angle = -1 * (double.Parse(TableauValeur[(i * 2) + 1]) - 360);
                            Tab_Int_Angle[i].Checked = true;
                        }
                        Tab_Sai_Angle[i].Text = Angle.ToString();
                    }
                    Tab_Sai_Longueur[(int)Sai_nSegments.Value - 1].Text = TableauValeur[TableauValeur.Length - 2];
                    Sai_Epaisseur.Text = TableauValeur[TableauValeur.Length - 1];
                }
            }
        }

        private void ExportExcel(object sender, EventArgs e)
        {
            Excel.Workbooks objBooks;
            Excel.Sheets objSheets;
            Excel._Worksheet objSheet;
            Excel.Range range;
            Excel.Shape Img;
            String ImageFile = Server.MapPath("files/ssgear.gif");

            try
            {
                // Instantiate Excel and start a new workbook.
                objApp = new Excel.Application();
                objBooks = objApp.Workbooks;
                objBook = objBooks.Add(Missing.Value);
                objSheets = objBook.Worksheets;
                objSheet = (Excel._Worksheet)objSheets.get_Item(1);

                Img = objSheet.Shapes.AddPicture("C:\Users\nerenos\Pictures\Orcier.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 100, 100);

                //Get the range where the starting cell has the address
                //m_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
                range = objSheet.get_Range("A1", Missing.Value);

                range.set_Value(Missing.Value, "Test");
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }

            //Return control of Excel to the user.
            objApp.Visible = true;
            objApp.UserControl = true;
                       
        }
    }
}
