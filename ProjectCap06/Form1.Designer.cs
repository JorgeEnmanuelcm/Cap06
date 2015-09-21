namespace ProjectCap06
{
    partial class Form1
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.labelLista = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(96, 200);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(63, 23);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(96, 229);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(63, 20);
            this.textBoxRes.TabIndex = 2;
            this.textBoxRes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.Items.AddRange(new object[] {
            "7",
            "6",
            "1",
            "2",
            "9",
            "3",
            "5",
            "8"});
            this.listBoxList.Location = new System.Drawing.Point(39, 70);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(120, 108);
            this.listBoxList.TabIndex = 3;
            this.listBoxList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Location = new System.Drawing.Point(39, 27);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(87, 13);
            this.labelLista.TabIndex = 4;
            this.labelLista.Text = "Lista de numeros";
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Location = new System.Drawing.Point(36, 229);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(54, 13);
            this.labelPromedio.TabIndex = 5;
            this.labelPromedio.Text = "Promedio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.buttonCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Label labelPromedio;
    }
}

