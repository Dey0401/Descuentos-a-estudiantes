
namespace appPractica1
{
    partial class frmUniversidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTipoEst = new System.Windows.Forms.ComboBox();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxProm = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonProcesar = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelValAPagar = new System.Windows.Forms.Label();
            this.labelValDesc = new System.Windows.Forms.Label();
            this.labelValCred = new System.Windows.Forms.Label();
            this.labelNumCred = new System.Windows.Forms.Label();
            this.txtVrPagar = new System.Windows.Forms.TextBox();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.txtVrCred = new System.Windows.Forms.TextBox();
            this.textBoxNumCred = new System.Windows.Forms.TextBox();
            this.ButtonTerminar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.labelTipoEst = new System.Windows.Forms.Label();
            this.labelCarne = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelProm = new System.Windows.Forms.Label();
            this.MensajError = new System.Windows.Forms.TextBox();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTipoEst
            // 
            this.comboBoxTipoEst.FormattingEnabled = true;
            this.comboBoxTipoEst.Location = new System.Drawing.Point(152, 47);
            this.comboBoxTipoEst.Name = "comboBoxTipoEst";
            this.comboBoxTipoEst.Size = new System.Drawing.Size(140, 21);
            this.comboBoxTipoEst.TabIndex = 0;
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(152, 89);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(140, 20);
            this.textBoxCarnet.TabIndex = 1;
            // 
            // textBoxProm
            // 
            this.textBoxProm.Location = new System.Drawing.Point(152, 171);
            this.textBoxProm.Name = "textBoxProm";
            this.textBoxProm.Size = new System.Drawing.Size(140, 20);
            this.textBoxProm.TabIndex = 2;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(152, 128);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(230, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLimpiar.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLimpiar.Location = new System.Drawing.Point(402, 47);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 71);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonProcesar
            // 
            this.buttonProcesar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonProcesar.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.buttonProcesar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonProcesar.Location = new System.Drawing.Point(402, 144);
            this.buttonProcesar.Name = "buttonProcesar";
            this.buttonProcesar.Size = new System.Drawing.Size(75, 73);
            this.buttonProcesar.TabIndex = 5;
            this.buttonProcesar.Text = "Procesar";
            this.buttonProcesar.UseVisualStyleBackColor = false;
            this.buttonProcesar.Click += new System.EventHandler(this.buttonProcesar_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelValAPagar);
            this.groupBoxResults.Controls.Add(this.labelValDesc);
            this.groupBoxResults.Controls.Add(this.labelValCred);
            this.groupBoxResults.Controls.Add(this.labelNumCred);
            this.groupBoxResults.Controls.Add(this.txtVrPagar);
            this.groupBoxResults.Controls.Add(this.txtDscto);
            this.groupBoxResults.Controls.Add(this.txtVrCred);
            this.groupBoxResults.Controls.Add(this.textBoxNumCred);
            this.groupBoxResults.Location = new System.Drawing.Point(499, 47);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(211, 170);
            this.groupBoxResults.TabIndex = 6;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Tag = "";
            this.groupBoxResults.Text = "Datos";
            this.groupBoxResults.Visible = false;
            // 
            // labelValAPagar
            // 
            this.labelValAPagar.AllowDrop = true;
            this.labelValAPagar.AutoSize = true;
            this.labelValAPagar.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValAPagar.Location = new System.Drawing.Point(6, 129);
            this.labelValAPagar.Name = "labelValAPagar";
            this.labelValAPagar.Size = new System.Drawing.Size(93, 16);
            this.labelValAPagar.TabIndex = 14;
            this.labelValAPagar.Text = "Vr. a Pagar:";
            // 
            // labelValDesc
            // 
            this.labelValDesc.AllowDrop = true;
            this.labelValDesc.AutoSize = true;
            this.labelValDesc.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValDesc.Location = new System.Drawing.Point(6, 99);
            this.labelValDesc.Name = "labelValDesc";
            this.labelValDesc.Size = new System.Drawing.Size(70, 16);
            this.labelValDesc.TabIndex = 13;
            this.labelValDesc.Text = "Vr. Dscto:";
            // 
            // labelValCred
            // 
            this.labelValCred.AllowDrop = true;
            this.labelValCred.AutoSize = true;
            this.labelValCred.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValCred.Location = new System.Drawing.Point(6, 69);
            this.labelValCred.Name = "labelValCred";
            this.labelValCred.Size = new System.Drawing.Size(90, 16);
            this.labelValCred.TabIndex = 12;
            this.labelValCred.Text = "Vr. Créditos:";
            // 
            // labelNumCred
            // 
            this.labelNumCred.AllowDrop = true;
            this.labelNumCred.AutoSize = true;
            this.labelNumCred.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCred.Location = new System.Drawing.Point(6, 28);
            this.labelNumCred.Name = "labelNumCred";
            this.labelNumCred.Size = new System.Drawing.Size(100, 16);
            this.labelNumCred.TabIndex = 11;
            this.labelNumCred.Text = "Nro. Créditos:";
            // 
            // txtVrPagar
            // 
            this.txtVrPagar.Location = new System.Drawing.Point(101, 127);
            this.txtVrPagar.Name = "txtVrPagar";
            this.txtVrPagar.ReadOnly = true;
            this.txtVrPagar.Size = new System.Drawing.Size(104, 20);
            this.txtVrPagar.TabIndex = 8;
            // 
            // txtDscto
            // 
            this.txtDscto.Location = new System.Drawing.Point(101, 95);
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.ReadOnly = true;
            this.txtDscto.Size = new System.Drawing.Size(104, 20);
            this.txtDscto.TabIndex = 9;
            // 
            // txtVrCred
            // 
            this.txtVrCred.Location = new System.Drawing.Point(101, 67);
            this.txtVrCred.Name = "txtVrCred";
            this.txtVrCred.ReadOnly = true;
            this.txtVrCred.Size = new System.Drawing.Size(104, 20);
            this.txtVrCred.TabIndex = 10;
            // 
            // textBoxNumCred
            // 
            this.textBoxNumCred.Location = new System.Drawing.Point(112, 26);
            this.textBoxNumCred.Name = "textBoxNumCred";
            this.textBoxNumCred.ReadOnly = true;
            this.textBoxNumCred.Size = new System.Drawing.Size(30, 20);
            this.textBoxNumCred.TabIndex = 8;
            // 
            // ButtonTerminar
            // 
            this.ButtonTerminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonTerminar.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTerminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonTerminar.Location = new System.Drawing.Point(729, 95);
            this.ButtonTerminar.Name = "ButtonTerminar";
            this.ButtonTerminar.Size = new System.Drawing.Size(75, 73);
            this.ButtonTerminar.TabIndex = 7;
            this.ButtonTerminar.Text = "Terminar";
            this.ButtonTerminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonTerminar.UseVisualStyleBackColor = false;
            this.ButtonTerminar.Click += new System.EventHandler(this.ButtonTerminar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AllowDrop = true;
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(58, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(221, 24);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "Reglas de Negocio";
            // 
            // labelTipoEst
            // 
            this.labelTipoEst.AllowDrop = true;
            this.labelTipoEst.AutoSize = true;
            this.labelTipoEst.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEst.Location = new System.Drawing.Point(6, 49);
            this.labelTipoEst.Name = "labelTipoEst";
            this.labelTipoEst.Size = new System.Drawing.Size(140, 16);
            this.labelTipoEst.TabIndex = 9;
            this.labelTipoEst.Text = "Tipo de estudiante: ";
            // 
            // labelCarne
            // 
            this.labelCarne.AllowDrop = true;
            this.labelCarne.AutoSize = true;
            this.labelCarne.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarne.Location = new System.Drawing.Point(87, 89);
            this.labelCarne.Name = "labelCarne";
            this.labelCarne.Size = new System.Drawing.Size(59, 16);
            this.labelCarne.TabIndex = 10;
            this.labelCarne.Text = "Carné: ";
            // 
            // labelNom
            // 
            this.labelNom.AllowDrop = true;
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(81, 130);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(65, 16);
            this.labelNom.TabIndex = 11;
            this.labelNom.Text = "Nombre:";
            // 
            // labelProm
            // 
            this.labelProm.AllowDrop = true;
            this.labelProm.AutoSize = true;
            this.labelProm.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProm.Location = new System.Drawing.Point(69, 173);
            this.labelProm.Name = "labelProm";
            this.labelProm.Size = new System.Drawing.Size(77, 16);
            this.labelProm.TabIndex = 12;
            this.labelProm.Text = "Promedio:";
            // 
            // MensajError
            // 
            this.MensajError.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MensajError.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MensajError.Location = new System.Drawing.Point(12, 235);
            this.MensajError.Multiline = true;
            this.MensajError.Name = "MensajError";
            this.MensajError.ReadOnly = true;
            this.MensajError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MensajError.Size = new System.Drawing.Size(813, 34);
            this.MensajError.TabIndex = 13;
            // 
            // frmUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 281);
            this.Controls.Add(this.MensajError);
            this.Controls.Add(this.labelProm);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelCarne);
            this.Controls.Add(this.labelTipoEst);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.ButtonTerminar);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.buttonProcesar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxProm);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.comboBoxTipoEst);
            this.Name = "frmUniversidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmUniversidad_Load);
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoEst;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxProm;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonProcesar;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.TextBox txtDscto;
        private System.Windows.Forms.TextBox txtVrCred;
        private System.Windows.Forms.TextBox textBoxNumCred;
        private System.Windows.Forms.TextBox txtVrPagar;
        private System.Windows.Forms.Button ButtonTerminar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label labelTipoEst;
        private System.Windows.Forms.Label labelCarne;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelProm;
        private System.Windows.Forms.Label labelValAPagar;
        private System.Windows.Forms.Label labelValDesc;
        private System.Windows.Forms.Label labelValCred;
        private System.Windows.Forms.Label labelNumCred;
        private System.Windows.Forms.TextBox MensajError;
    }
}

