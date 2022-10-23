namespace SoccerFieldManager
{
    partial class Form2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_reser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.configBt = new System.Windows.Forms.Button();
            this.clientesBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // bt_reser
            // 
            this.bt_reser.Location = new System.Drawing.Point(588, 55);
            this.bt_reser.Name = "bt_reser";
            this.bt_reser.Size = new System.Drawing.Size(90, 23);
            this.bt_reser.TabIndex = 3;
            this.bt_reser.Text = "Reservar";
            this.bt_reser.UseVisualStyleBackColor = true;
            this.bt_reser.Click += new System.EventHandler(this.bt_ReservationClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 354);
            this.dataGridView1.TabIndex = 4;
            // 
            // configBt
            // 
            this.configBt.Location = new System.Drawing.Point(588, 26);
            this.configBt.Name = "configBt";
            this.configBt.Size = new System.Drawing.Size(90, 23);
            this.configBt.TabIndex = 5;
            this.configBt.Text = "Configuración";
            this.configBt.UseVisualStyleBackColor = true;
            this.configBt.Click += new System.EventHandler(this.configBtClick);
            // 
            // clientesBT
            // 
            this.clientesBT.Location = new System.Drawing.Point(492, 55);
            this.clientesBT.Name = "clientesBT";
            this.clientesBT.Size = new System.Drawing.Size(90, 23);
            this.clientesBT.TabIndex = 6;
            this.clientesBT.Text = "Clientes";
            this.clientesBT.UseVisualStyleBackColor = true;
            this.clientesBT.Click += new System.EventHandler(this.clientesBTClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Horarios";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientesBT);
            this.Controls.Add(this.configBt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_reser);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_reser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button configBt;
        private System.Windows.Forms.Button clientesBT;
        private System.Windows.Forms.Label label1;
    }
}