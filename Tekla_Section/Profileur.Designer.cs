namespace Tekla_Section
{
    partial class Profileur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Drawing.Image bmp = null;
        private System.Drawing.Graphics Img_Pliage = null;

        public int nSegment;
        public int nAngle;

        private double xCoefImage;
        private double xLargeurInit = 0;
        private double xHauteurInit = 0;

        private System.Windows.Forms.FlowLayoutPanel[] Tab_Disp_Longueur = null;
        private System.Windows.Forms.Label[] Tab_Lib_Longueur = null;
        private Tekla_Section.NumberBox[] Tab_Sai_Longueur = null;

        private System.Windows.Forms.FlowLayoutPanel[] Tab_Disp_Angle = null;
        private System.Windows.Forms.Label[] Tab_Lib_Angle = null;
        private Tekla_Section.NumberBox[] Tab_Sai_Angle = null;
        private System.Windows.Forms.CheckBox[] Tab_Int_Angle = null;

        private System.Drawing.Pen Pen_Ligne = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
        private System.Drawing.Pen Pen_Circle = new System.Drawing.Pen(System.Drawing.Color.Red, 1);

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profileur));
            this.Model = new System.Windows.Forms.GroupBox();
            this.Img_Viewer = new System.Windows.Forms.PictureBox();
            this.Parametres = new System.Windows.Forms.GroupBox();
            this.Disp_Parametres = new System.Windows.Forms.FlowLayoutPanel();
            this.Disp_AngleInit = new System.Windows.Forms.FlowLayoutPanel();
            this.Lib_AngleInit = new System.Windows.Forms.Label();
            this.Sai_AngleInit = new Tekla_Section.NumberBox();
            this.Lib_Epaisseur = new System.Windows.Forms.Label();
            this.Sai_Epaisseur = new Tekla_Section.NumberBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Sai_nSegments = new System.Windows.Forms.NumericUpDown();
            this.Lib_nSegments = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_EnregistrerSous = new System.Windows.Forms.Button();
            this.SAI_Pliage = new System.Windows.Forms.TextBox();
            this.COMBO_Pliages = new System.Windows.Forms.ComboBox();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.BTN_Charger = new System.Windows.Forms.Button();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.Model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Viewer)).BeginInit();
            this.Parametres.SuspendLayout();
            this.Disp_Parametres.SuspendLayout();
            this.Disp_AngleInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sai_nSegments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Model
            // 
            this.Model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Model.Controls.Add(this.Img_Viewer);
            this.Model.Location = new System.Drawing.Point(3, 3);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(394, 357);
            this.Model.TabIndex = 4;
            this.Model.TabStop = false;
            this.Model.Text = "Model";
            // 
            // Img_Viewer
            // 
            this.Img_Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Img_Viewer.BackColor = System.Drawing.Color.Azure;
            this.Img_Viewer.Location = new System.Drawing.Point(7, 19);
            this.Img_Viewer.Name = "Img_Viewer";
            this.Img_Viewer.Size = new System.Drawing.Size(382, 332);
            this.Img_Viewer.TabIndex = 0;
            this.Img_Viewer.TabStop = false;
            this.Img_Viewer.DoubleClick += new System.EventHandler(this.ExportExcel);
            // 
            // Parametres
            // 
            this.Parametres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parametres.Controls.Add(this.Disp_Parametres);
            this.Parametres.Location = new System.Drawing.Point(3, 3);
            this.Parametres.Name = "Parametres";
            this.Parametres.Size = new System.Drawing.Size(366, 357);
            this.Parametres.TabIndex = 5;
            this.Parametres.TabStop = false;
            this.Parametres.Text = "Paramètres";
            // 
            // Disp_Parametres
            // 
            this.Disp_Parametres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Disp_Parametres.AutoScroll = true;
            this.Disp_Parametres.Controls.Add(this.Disp_AngleInit);
            this.Disp_Parametres.Location = new System.Drawing.Point(6, 19);
            this.Disp_Parametres.Name = "Disp_Parametres";
            this.Disp_Parametres.Size = new System.Drawing.Size(354, 332);
            this.Disp_Parametres.TabIndex = 0;
            // 
            // Disp_AngleInit
            // 
            this.Disp_AngleInit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Disp_AngleInit.Controls.Add(this.Lib_AngleInit);
            this.Disp_AngleInit.Controls.Add(this.Sai_AngleInit);
            this.Disp_AngleInit.Controls.Add(this.Lib_Epaisseur);
            this.Disp_AngleInit.Controls.Add(this.Sai_Epaisseur);
            this.Disp_AngleInit.Location = new System.Drawing.Point(3, 3);
            this.Disp_AngleInit.Name = "Disp_AngleInit";
            this.Disp_AngleInit.Size = new System.Drawing.Size(348, 26);
            this.Disp_AngleInit.TabIndex = 0;
            // 
            // Lib_AngleInit
            // 
            this.Lib_AngleInit.AutoSize = true;
            this.Lib_AngleInit.Location = new System.Drawing.Point(3, 7);
            this.Lib_AngleInit.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.Lib_AngleInit.Name = "Lib_AngleInit";
            this.Lib_AngleInit.Size = new System.Drawing.Size(66, 13);
            this.Lib_AngleInit.TabIndex = 0;
            this.Lib_AngleInit.Text = "Angle initiale";
            // 
            // Sai_AngleInit
            // 
            this.Sai_AngleInit.Location = new System.Drawing.Point(75, 3);
            this.Sai_AngleInit.Name = "Sai_AngleInit";
            this.Sai_AngleInit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sai_AngleInit.Size = new System.Drawing.Size(42, 20);
            this.Sai_AngleInit.TabIndex = 1;
            this.Sai_AngleInit.Text = "0";
            this.Sai_AngleInit.TextChanged += new System.EventHandler(this.Modifier_Parametres);
            // 
            // Lib_Epaisseur
            // 
            this.Lib_Epaisseur.AutoSize = true;
            this.Lib_Epaisseur.Location = new System.Drawing.Point(173, 7);
            this.Lib_Epaisseur.Margin = new System.Windows.Forms.Padding(53, 7, 3, 0);
            this.Lib_Epaisseur.Name = "Lib_Epaisseur";
            this.Lib_Epaisseur.Size = new System.Drawing.Size(52, 13);
            this.Lib_Epaisseur.TabIndex = 2;
            this.Lib_Epaisseur.Text = "épaisseur";
            // 
            // Sai_Epaisseur
            // 
            this.Sai_Epaisseur.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sai_Epaisseur.Location = new System.Drawing.Point(231, 3);
            this.Sai_Epaisseur.Name = "Sai_Epaisseur";
            this.Sai_Epaisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sai_Epaisseur.Size = new System.Drawing.Size(42, 20);
            this.Sai_Epaisseur.TabIndex = 3;
            this.Sai_Epaisseur.Text = "0.75";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Model);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Parametres);
            this.splitContainer1.Size = new System.Drawing.Size(776, 363);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 6;
            // 
            // Sai_nSegments
            // 
            this.Sai_nSegments.Location = new System.Drawing.Point(12, 20);
            this.Sai_nSegments.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Sai_nSegments.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Sai_nSegments.Name = "Sai_nSegments";
            this.Sai_nSegments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sai_nSegments.Size = new System.Drawing.Size(51, 20);
            this.Sai_nSegments.TabIndex = 7;
            this.Sai_nSegments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Sai_nSegments.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Sai_nSegments.ValueChanged += new System.EventHandler(this.Sai_nSegments_ValueChanged);
            // 
            // Lib_nSegments
            // 
            this.Lib_nSegments.AutoSize = true;
            this.Lib_nSegments.Location = new System.Drawing.Point(9, 4);
            this.Lib_nSegments.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Lib_nSegments.Name = "Lib_nSegments";
            this.Lib_nSegments.Size = new System.Drawing.Size(54, 13);
            this.Lib_nSegments.TabIndex = 8;
            this.Lib_nSegments.Text = "Segments";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_EnregistrerSous);
            this.panel1.Controls.Add(this.SAI_Pliage);
            this.panel1.Controls.Add(this.COMBO_Pliages);
            this.panel1.Controls.Add(this.BTN_Enregistrer);
            this.panel1.Controls.Add(this.BTN_Charger);
            this.panel1.Location = new System.Drawing.Point(72, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 39);
            this.panel1.TabIndex = 9;
            // 
            // BTN_EnregistrerSous
            // 
            this.BTN_EnregistrerSous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_EnregistrerSous.Location = new System.Drawing.Point(612, 7);
            this.BTN_EnregistrerSous.Name = "BTN_EnregistrerSous";
            this.BTN_EnregistrerSous.Size = new System.Drawing.Size(100, 24);
            this.BTN_EnregistrerSous.TabIndex = 5;
            this.BTN_EnregistrerSous.Text = "Enregistrer sous";
            this.BTN_EnregistrerSous.UseVisualStyleBackColor = true;
            this.BTN_EnregistrerSous.Click += new System.EventHandler(this.BTN_EnregistrerSous_Click);
            // 
            // SAI_Pliage
            // 
            this.SAI_Pliage.Location = new System.Drawing.Point(400, 9);
            this.SAI_Pliage.Name = "SAI_Pliage";
            this.SAI_Pliage.Size = new System.Drawing.Size(206, 20);
            this.SAI_Pliage.TabIndex = 4;
            // 
            // COMBO_Pliages
            // 
            this.COMBO_Pliages.FormattingEnabled = true;
            this.COMBO_Pliages.Location = new System.Drawing.Point(89, 9);
            this.COMBO_Pliages.Name = "COMBO_Pliages";
            this.COMBO_Pliages.Size = new System.Drawing.Size(219, 21);
            this.COMBO_Pliages.TabIndex = 3;
            this.COMBO_Pliages.SelectionChangeCommitted += new System.EventHandler(this.COMBO_Pliages_SelectionChangeCommitted);
            this.COMBO_Pliages.Enter += new System.EventHandler(this.COMBO_Pliages_Enter);
            // 
            // BTN_Enregistrer
            // 
            this.BTN_Enregistrer.Location = new System.Drawing.Point(314, 7);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(80, 24);
            this.BTN_Enregistrer.TabIndex = 2;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = true;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // BTN_Charger
            // 
            this.BTN_Charger.Location = new System.Drawing.Point(3, 7);
            this.BTN_Charger.Name = "BTN_Charger";
            this.BTN_Charger.Size = new System.Drawing.Size(80, 24);
            this.BTN_Charger.TabIndex = 1;
            this.BTN_Charger.Text = "Charger";
            this.BTN_Charger.UseVisualStyleBackColor = true;
            this.BTN_Charger.Click += new System.EventHandler(this.BTN_Charger_Click);
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 421);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(800, 29);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 10;
            this.okApplyModifyGetOnOffCancel1.ModifyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ModifyClicked);
            this.okApplyModifyGetOnOffCancel1.GetClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_GetClicked);
            this.okApplyModifyGetOnOffCancel1.CancelClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_CancelClicked);
            this.okApplyModifyGetOnOffCancel1.Load += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_Load);
            // 
            // Profileur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lib_nSegments);
            this.Controls.Add(this.Sai_nSegments);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profileur";
            this.Text = "Profileur";
            this.SizeChanged += new System.EventHandler(this.Modifier_Parametres);
            this.Model.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Viewer)).EndInit();
            this.Parametres.ResumeLayout(false);
            this.Disp_Parametres.ResumeLayout(false);
            this.Disp_AngleInit.ResumeLayout(false);
            this.Disp_AngleInit.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sai_nSegments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        public void InitFenetre()
        {
            nSegment = System.Convert.ToUInt16(Sai_nSegments.Value);
            nAngle = nSegment - 1;

            Tab_Disp_Longueur = new System.Windows.Forms.FlowLayoutPanel[nSegment];
            Tab_Lib_Longueur = new System.Windows.Forms.Label[nSegment];
            Tab_Sai_Longueur = new Tekla_Section.NumberBox[nSegment];

            Tab_Disp_Angle = new System.Windows.Forms.FlowLayoutPanel[nAngle];
            Tab_Lib_Angle = new System.Windows.Forms.Label[nAngle];
            Tab_Sai_Angle = new Tekla_Section.NumberBox[nAngle];
            Tab_Int_Angle = new System.Windows.Forms.CheckBox[nAngle];

            //SupprimerSuperChamp();

            for (int i = 0; i < nSegment; i++)
            {
                this.GenererSuperChampLongueur(i);
                if (i < nAngle) { this.GenererSuperChampAngle(i); }
            }
        }

        public void GenererSuperChampLongueur(int ID)
        {
            this.Tab_Disp_Longueur[ID] = new System.Windows.Forms.FlowLayoutPanel();
            this.Tab_Lib_Longueur[ID] = new System.Windows.Forms.Label();
            this.Tab_Sai_Longueur[ID] = new Tekla_Section.NumberBox();

            this.Disp_Parametres.Controls.Add(this.Tab_Disp_Longueur[ID]);

            // 
            // Disp_Longueur_1
            // 
            this.Tab_Disp_Longueur[ID].Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Disp_Longueur[ID].Controls.Add(this.Tab_Lib_Longueur[ID]);
            this.Tab_Disp_Longueur[ID].Controls.Add(this.Tab_Sai_Longueur[ID]);
            this.Tab_Disp_Longueur[ID].Location = new System.Drawing.Point(3, ID * 32 + 3);
            this.Tab_Disp_Longueur[ID].Name = "Disp_Longueur_" + ID;
            this.Tab_Disp_Longueur[ID].Size = new System.Drawing.Size(320, 26);
            this.Tab_Disp_Longueur[ID].TabIndex = 5;
            // 
            // Lib_Longueur_1
            // 
            this.Tab_Lib_Longueur[ID].AutoSize = true;
            this.Tab_Lib_Longueur[ID].Location = new System.Drawing.Point(3, 7);
            this.Tab_Lib_Longueur[ID].Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.Tab_Lib_Longueur[ID].Name = "Lib_Longueur_" + ID;
            this.Tab_Lib_Longueur[ID].Size = new System.Drawing.Size(61, 13);
            this.Tab_Lib_Longueur[ID].TabIndex = 0;
            this.Tab_Lib_Longueur[ID].Text = "Longueur " + ID;
            // 
            // Sai_Longueur_1
            // 
            this.Tab_Sai_Longueur[ID].Location = new System.Drawing.Point(70, 3);
            this.Tab_Sai_Longueur[ID].Name = "Sai_Longueur_" + ID;
            this.Tab_Sai_Longueur[ID].Size = new System.Drawing.Size(100, 20);
            this.Tab_Sai_Longueur[ID].TabIndex = 1;
            this.Tab_Sai_Longueur[ID].TextChanged += new System.EventHandler(this.Tab_Sai_Longueur[ID].Verif_Saisie);
            this.Tab_Sai_Longueur[ID].TextChanged += new System.EventHandler(this.Modifier_Parametres);


        }

        public void GenererSuperChampAngle(int ID)
        {
            this.Tab_Disp_Angle[ID] = new System.Windows.Forms.FlowLayoutPanel();
            this.Tab_Lib_Angle[ID] = new System.Windows.Forms.Label();
            this.Tab_Sai_Angle[ID] = new Tekla_Section.NumberBox();
            this.Tab_Int_Angle[ID] = new System.Windows.Forms.CheckBox();

            this.Disp_Parametres.Controls.Add(this.Tab_Disp_Angle[ID]);

            // 
            // Disp_Angle_1
            // 
            this.Tab_Disp_Angle[ID].Controls.Add(this.Tab_Lib_Angle[ID]);
            this.Tab_Disp_Angle[ID].Controls.Add(this.Tab_Sai_Angle[ID]);
            this.Tab_Disp_Angle[ID].Controls.Add(this.Tab_Int_Angle[ID]);
            this.Tab_Disp_Angle[ID].Location = new System.Drawing.Point(3, 35);
            this.Tab_Disp_Angle[ID].Name = "Disp_Angle_" + ID;
            this.Tab_Disp_Angle[ID].Size = new System.Drawing.Size(320, 26);
            this.Tab_Disp_Angle[ID].TabIndex = 0;
            // 
            // Lib_Angle_1
            // 
            this.Tab_Lib_Angle[ID].AutoSize = true;
            this.Tab_Lib_Angle[ID].Location = new System.Drawing.Point(3, 7);
            this.Tab_Lib_Angle[ID].Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.Tab_Lib_Angle[ID].Name = "Lib_Angle_" + ID;
            this.Tab_Lib_Angle[ID].Size = new System.Drawing.Size(43, 13);
            this.Tab_Lib_Angle[ID].TabIndex = 0;
            this.Tab_Lib_Angle[ID].Text = "Angle " + ID;
            // 
            // Sai_Angle_1
            // 
            this.Tab_Sai_Angle[ID].Location = new System.Drawing.Point(52, 3);
            this.Tab_Sai_Angle[ID].Name = "Sai_Angle_" + ID;
            this.Tab_Sai_Angle[ID].Size = new System.Drawing.Size(100, 20);
            this.Tab_Sai_Angle[ID].TabIndex = 1;
            this.Tab_Sai_Angle[ID].TextChanged += new System.EventHandler(this.Tab_Sai_Angle[ID].Verif_Saisie);
            this.Tab_Sai_Angle[ID].TextChanged += new System.EventHandler(this.Modifier_Parametres);
            // 
            // Int_Angle_1
            // 
            this.Tab_Int_Angle[ID].AutoSize = true;
            this.Tab_Int_Angle[ID].Location = new System.Drawing.Point(158, 6);
            this.Tab_Int_Angle[ID].Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.Tab_Int_Angle[ID].Name = "Int_Angle_" + ID;
            this.Tab_Int_Angle[ID].Size = new System.Drawing.Size(69, 17);
            this.Tab_Int_Angle[ID].TabIndex = 2;
            this.Tab_Int_Angle[ID].Text = "Inversion";
            this.Tab_Int_Angle[ID].UseVisualStyleBackColor = true;
            this.Tab_Int_Angle[ID].CheckedChanged += new System.EventHandler(this.Modifier_Parametres);


        }

        public void SupprimerSuperChamp()
        {
            for(int i = 0; i < nSegment; i++)
            {
                this.Tab_Disp_Longueur[i].Dispose();
                this.Tab_Lib_Longueur[i].Dispose();
                this.Tab_Sai_Longueur[i].Dispose();
            }
            for (int i = 0; i < nAngle; i++)
            {
                this.Tab_Disp_Angle[i].Dispose();
                this.Tab_Lib_Angle[i].Dispose();
                this.Tab_Sai_Angle[i].Dispose();
                this.Tab_Int_Angle[i].Dispose();
            }
        }

        public void GenererImage()
        {
            double xAngle = 0;
            double xLargeur;
            double xHauteur;
            double xLargeurOld;
            double xHauteurOld;
            System.Drawing.Font drawFont;
            System.Drawing.SolidBrush drawBrush;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(); ;

            drawFont = new System.Drawing.Font("Century", 12);
            
            drawFormat.LineAlignment = System.Drawing.StringAlignment.Near;
            drawFormat.Alignment = System.Drawing.StringAlignment.Center;

            if (Sai_AngleInit.Text != "" && Sai_AngleInit.Text != "-") { xAngle = (System.Math.PI / 180) * System.Convert.ToDouble(Sai_AngleInit.Text.Replace(".", ",")); }

            CoefImage();
            xLargeur = xLargeurInit;
            xHauteur = xHauteurInit;
            xLargeurOld = xLargeurInit;
            xHauteurOld = xHauteurInit;

            bmp = new System.Drawing.Bitmap(Img_Viewer.Width, Img_Viewer.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Img_Pliage = System.Drawing.Graphics.FromImage(bmp);
            Img_Pliage.Clear(System.Drawing.Color.Transparent);

            Img_Pliage.DrawEllipse(Pen_Circle, (int)xLargeurOld - 2, (int)xHauteurOld - 2, 4, 4);
            Img_Pliage.FillEllipse(System.Drawing.Brushes.Red, (int)xLargeurOld - 2, (int)xHauteurOld - 2, 4, 4);

            for (int i = 0; i < nSegment; i++)
            {
                if (Tab_Sai_Longueur[i].Text != "" && Tab_Sai_Longueur[i].Text != "-")
                {
                    xLargeur += System.Math.Cos(xAngle) * System.Convert.ToDouble(Tab_Sai_Longueur[i].Text.Replace(".", ",")) * xCoefImage;
                    xHauteur += System.Math.Sin(xAngle) * System.Convert.ToDouble(Tab_Sai_Longueur[i].Text.Replace(".", ",")) * xCoefImage;
                }

                if (i < nAngle && Tab_Sai_Angle[i].Text != "" && Tab_Sai_Angle[i].Text != "-")
                {
                    if (Tab_Int_Angle[i].Checked)
                    {
                        xAngle += (System.Math.PI / 180) * (180 - System.Convert.ToDouble(Tab_Sai_Angle[i].Text.Replace(".", ",")));
                    }
                    else
                    {
                        xAngle += (System.Math.PI / 180) * (180 + System.Convert.ToDouble(Tab_Sai_Angle[i].Text.Replace(".", ",")));
                    }
                }

                Img_Pliage.DrawLine(Pen_Ligne,
                    System.Convert.ToSingle(xLargeurOld), System.Convert.ToSingle(xHauteurOld),
                    System.Convert.ToSingle(xLargeur), System.Convert.ToSingle(xHauteur));

                drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                Img_Pliage.DrawString(Tab_Sai_Longueur[i].Text, drawFont, drawBrush,
                    (System.Convert.ToSingle(xLargeurOld) + System.Convert.ToSingle(xLargeur))/2,
                    (System.Convert.ToSingle(xHauteurOld) + System.Convert.ToSingle(xHauteur))/2,
                    drawFormat);

                if (i < nAngle && Tab_Sai_Angle[i].Text != "90")
                {
                    drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
                    Img_Pliage.DrawString(Tab_Sai_Angle[i].Text, drawFont, drawBrush,
                        System.Convert.ToSingle(xLargeur), System.Convert.ToSingle(xHauteur), drawFormat);
                }
                
                

                xLargeurOld = xLargeur;
                xHauteurOld = xHauteur;
            }
        
            this.Img_Viewer.Image = bmp;
        }

        private void CoefImage()
        {
            double xAngle = 0;
            double xLargeurMax = 0;
            double xHauteurMax = 0;
            double xLargeurMin = 0;
            double xHauteurMin = 0;
            double xLargeur = 0;
            double xHauteur = 0;

            double xCoefHauteur = 1;
            double xCoefLargeur = 1;

            if (Sai_AngleInit.Text != "" && Sai_AngleInit.Text != "-") { xAngle = (System.Math.PI / 180) * System.Convert.ToDouble(Sai_AngleInit.Text.Replace(".", ",")); }

            for (int i = 0; i < nSegment; i++)
            {
                if (Tab_Sai_Longueur[i].Text != ""  && Tab_Sai_Longueur[i].Text != "-")
                {
                    xLargeur += System.Math.Cos(xAngle) * System.Convert.ToDouble(Tab_Sai_Longueur[i].Text.Replace(".", ","));
                    xHauteur += System.Math.Sin(xAngle) * System.Convert.ToDouble(Tab_Sai_Longueur[i].Text.Replace(".", ","));
                }

                if (i < nAngle && Tab_Sai_Angle[i].Text != "" && Tab_Sai_Angle[i].Text != "-")
                { 
                    if (Tab_Int_Angle[i].Checked)
                    {
                        xAngle += (System.Math.PI / 180) * (180 - System.Convert.ToDouble(Tab_Sai_Angle[i].Text.Replace(".", ",")));
                    }
                    else
                    {
                        xAngle += (System.Math.PI / 180) * (180 + System.Convert.ToDouble(Tab_Sai_Angle[i].Text.Replace(".", ",")));
                    }
                }

                if (xLargeur > xLargeurMax) { xLargeurMax = xLargeur; }
                if (xHauteur > xHauteurMax) { xHauteurMax = xHauteur; }
                if (xLargeur < xLargeurMin) { xLargeurMin = xLargeur; }
                if (xHauteur < xHauteurMin) { xHauteurMin = xHauteur; }
            }

            if ((xLargeurMax - xLargeurMin) != 0) { xCoefLargeur = Img_Viewer.Width * 0.9/ (xLargeurMax - xLargeurMin); }
            if ((xHauteurMax - xHauteurMin) != 0) { xCoefHauteur = Img_Viewer.Height * 0.9 / (xHauteurMax - xHauteurMin); }

            if (xCoefHauteur < xCoefLargeur)
            {
                xCoefImage = xCoefHauteur;
            }
            else
            {
                xCoefImage = xCoefLargeur;
            }

            xLargeurInit = (System.Math.Abs(xLargeurMin) * xCoefLargeur) + (Img_Viewer.Width * 0.05);
            xHauteurInit = (System.Math.Abs(xHauteurMin) * xCoefHauteur) + (Img_Viewer.Height * 0.05);
        }

        #endregion
        private System.Windows.Forms.GroupBox Model;
        private System.Windows.Forms.GroupBox Parametres;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel Disp_Parametres;
        private System.Windows.Forms.PictureBox Img_Viewer;
        private System.Windows.Forms.FlowLayoutPanel Disp_AngleInit;
        private System.Windows.Forms.Label Lib_AngleInit;
        private Tekla_Section.NumberBox Sai_AngleInit;
        private System.Windows.Forms.Label Lib_Epaisseur;
        private NumberBox Sai_Epaisseur;
        private System.Windows.Forms.NumericUpDown Sai_nSegments;
        private System.Windows.Forms.Label Lib_nSegments;
        private System.Windows.Forms.Panel panel1;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
        private System.Windows.Forms.Button BTN_Charger;
        private System.Windows.Forms.ComboBox COMBO_Pliages;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.Button BTN_EnregistrerSous;
        private System.Windows.Forms.TextBox SAI_Pliage;
    }
}

