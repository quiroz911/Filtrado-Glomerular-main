
namespace Filtrado_Glomerular
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edadTxt = new System.Windows.Forms.TextBox();
            this.pesoTxt = new System.Windows.Forms.TextBox();
            this.creatininaTxt = new System.Windows.Forms.TextBox();
            this.relacionACTxt = new System.Windows.Forms.TextBox();
            this.sexoHombreRadioButton = new System.Windows.Forms.RadioButton();
            this.sexoMujerRadioButton = new System.Windows.Forms.RadioButton();
            this.razaNegraCheckBox = new System.Windows.Forms.CheckBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.resultadoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.copiarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso (kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creatinina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Relación Albuminuria/Creatinuria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo:";
            // 
            // edadTxt
            // 
            this.edadTxt.Location = new System.Drawing.Point(342, 43);
            this.edadTxt.Name = "edadTxt";
            this.edadTxt.Size = new System.Drawing.Size(100, 23);
            this.edadTxt.TabIndex = 5;
            // 
            // pesoTxt
            // 
            this.pesoTxt.Location = new System.Drawing.Point(342, 99);
            this.pesoTxt.Name = "pesoTxt";
            this.pesoTxt.Size = new System.Drawing.Size(100, 23);
            this.pesoTxt.TabIndex = 6;
            // 
            // creatininaTxt
            // 
            this.creatininaTxt.Location = new System.Drawing.Point(342, 157);
            this.creatininaTxt.Name = "creatininaTxt";
            this.creatininaTxt.Size = new System.Drawing.Size(100, 23);
            this.creatininaTxt.TabIndex = 7;
            // 
            // relacionACTxt
            // 
            this.relacionACTxt.Location = new System.Drawing.Point(342, 217);
            this.relacionACTxt.Name = "relacionACTxt";
            this.relacionACTxt.Size = new System.Drawing.Size(100, 23);
            this.relacionACTxt.TabIndex = 8;
            // 
            // sexoHombreRadioButton
            // 
            this.sexoHombreRadioButton.AutoSize = true;
            this.sexoHombreRadioButton.Checked = true;
            this.sexoHombreRadioButton.Location = new System.Drawing.Point(231, 280);
            this.sexoHombreRadioButton.Name = "sexoHombreRadioButton";
            this.sexoHombreRadioButton.Size = new System.Drawing.Size(69, 19);
            this.sexoHombreRadioButton.TabIndex = 9;
            this.sexoHombreRadioButton.TabStop = true;
            this.sexoHombreRadioButton.Tag = "sex";
            this.sexoHombreRadioButton.Text = "Hombre";
            this.sexoHombreRadioButton.UseVisualStyleBackColor = true;
            this.sexoHombreRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sexoMujerRadioButton
            // 
            this.sexoMujerRadioButton.AutoSize = true;
            this.sexoMujerRadioButton.Location = new System.Drawing.Point(342, 280);
            this.sexoMujerRadioButton.Name = "sexoMujerRadioButton";
            this.sexoMujerRadioButton.Size = new System.Drawing.Size(56, 19);
            this.sexoMujerRadioButton.TabIndex = 10;
            this.sexoMujerRadioButton.Tag = "sex";
            this.sexoMujerRadioButton.Text = "Mujer";
            this.sexoMujerRadioButton.UseVisualStyleBackColor = true;
            // 
            // razaNegraCheckBox
            // 
            this.razaNegraCheckBox.AutoSize = true;
            this.razaNegraCheckBox.Location = new System.Drawing.Point(51, 355);
            this.razaNegraCheckBox.Name = "razaNegraCheckBox";
            this.razaNegraCheckBox.Size = new System.Drawing.Size(85, 19);
            this.razaNegraCheckBox.TabIndex = 11;
            this.razaNegraCheckBox.Text = "Raza Negra";
            this.razaNegraCheckBox.UseVisualStyleBackColor = true;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(342, 335);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(100, 49);
            this.calcularButton.TabIndex = 12;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.ForeColor = System.Drawing.Color.Red;
            this.limpiarButton.Location = new System.Drawing.Point(231, 335);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 13;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // resultadoTxt
            // 
            this.resultadoTxt.Location = new System.Drawing.Point(27, 410);
            this.resultadoTxt.Name = "resultadoTxt";
            this.resultadoTxt.ReadOnly = true;
            this.resultadoTxt.Size = new System.Drawing.Size(452, 23);
            this.resultadoTxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Utilice la coma para los decimales :)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // copiarButton
            // 
            this.copiarButton.Location = new System.Drawing.Point(231, 364);
            this.copiarButton.Name = "copiarButton";
            this.copiarButton.Size = new System.Drawing.Size(75, 23);
            this.copiarButton.TabIndex = 16;
            this.copiarButton.Text = "Copiar";
            this.copiarButton.UseVisualStyleBackColor = true;
            this.copiarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 476);
            this.Controls.Add(this.copiarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultadoTxt);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.razaNegraCheckBox);
            this.Controls.Add(this.sexoMujerRadioButton);
            this.Controls.Add(this.sexoHombreRadioButton);
            this.Controls.Add(this.relacionACTxt);
            this.Controls.Add(this.creatininaTxt);
            this.Controls.Add(this.pesoTxt);
            this.Controls.Add(this.edadTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Filtrado Glomerular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edadTxt;
        private System.Windows.Forms.TextBox pesoTxt;
        private System.Windows.Forms.TextBox creatininaTxt;
        private System.Windows.Forms.TextBox relacionACTxt;
        private System.Windows.Forms.RadioButton sexoHombreRadioButton;
        private System.Windows.Forms.RadioButton sexoMujerRadioButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.CheckBox razaNegraCheckBox;
        private System.Windows.Forms.TextBox resultadoTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button copiarButton;
    }
}

