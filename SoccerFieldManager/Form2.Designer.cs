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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_reser = new System.Windows.Forms.Button();
            this.reservationsDGV = new System.Windows.Forms.DataGridView();
            this.configBt = new System.Windows.Forms.Button();
            this.clientesBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soccerFieldBt = new System.Windows.Forms.Button();
            this.reservationEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationEntityBindingSource)).BeginInit();
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
            // reservationsDGV
            // 
            this.reservationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsDGV.Location = new System.Drawing.Point(23, 84);
            this.reservationsDGV.Name = "reservationsDGV";
            this.reservationsDGV.Size = new System.Drawing.Size(655, 354);
            this.reservationsDGV.TabIndex = 4;
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
            // soccerFieldBt
            // 
            this.soccerFieldBt.Location = new System.Drawing.Point(492, 25);
            this.soccerFieldBt.Name = "soccerFieldBt";
            this.soccerFieldBt.Size = new System.Drawing.Size(90, 23);
            this.soccerFieldBt.TabIndex = 8;
            this.soccerFieldBt.Text = "Canchas";
            this.soccerFieldBt.UseVisualStyleBackColor = true;
            this.soccerFieldBt.Click += new System.EventHandler(this.soccerFieldBtClick);
            // 
            // reservationEntityBindingSource
            // 
            this.reservationEntityBindingSource.DataSource = typeof(SoccerFieldManager.Entities.ReservationEntity);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.soccerFieldBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientesBT);
            this.Controls.Add(this.configBt);
            this.Controls.Add(this.reservationsDGV);
            this.Controls.Add(this.bt_reser);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_reser;
        private System.Windows.Forms.DataGridView reservationsDGV;
        private System.Windows.Forms.Button configBt;
        private System.Windows.Forms.Button clientesBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button soccerFieldBt;
        private System.Windows.Forms.BindingSource reservationEntityBindingSource;
    }
}