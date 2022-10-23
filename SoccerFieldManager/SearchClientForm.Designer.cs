namespace SoccerFieldManager
{
    partial class SearchClientForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.selectBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.identificationTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchUserBt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.EditUserBT = new System.Windows.Forms.Button();
            this.AddUserBt = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Zof",
            "Ziro",
            "Vito",
            "Zeta"});
            this.listBox1.Location = new System.Drawing.Point(211, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 238);
            this.listBox1.TabIndex = 0;
            // 
            // selectBt
            // 
            this.selectBt.Location = new System.Drawing.Point(84, 3);
            this.selectBt.Name = "selectBt";
            this.selectBt.Size = new System.Drawing.Size(75, 23);
            this.selectBt.TabIndex = 1;
            this.selectBt.Text = "Seleccionar";
            this.selectBt.UseVisualStyleBackColor = true;
            this.selectBt.Click += new System.EventHandler(this.selectBtClick);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(15, 226);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(75, 23);
            this.cancelBt.TabIndex = 2;
            this.cancelBt.Text = "Regresar";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.CancelBtClick);
            // 
            // identificationTXT
            // 
            this.identificationTXT.Location = new System.Drawing.Point(10, 23);
            this.identificationTXT.MaxLength = 20;
            this.identificationTXT.Name = "identificationTXT";
            this.identificationTXT.Size = new System.Drawing.Size(163, 20);
            this.identificationTXT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación";
            // 
            // searchUserBt
            // 
            this.searchUserBt.Location = new System.Drawing.Point(3, 3);
            this.searchUserBt.Name = "searchUserBt";
            this.searchUserBt.Size = new System.Drawing.Size(75, 23);
            this.searchUserBt.TabIndex = 5;
            this.searchUserBt.Text = "Buscar";
            this.searchUserBt.UseVisualStyleBackColor = true;
            this.searchUserBt.Click += new System.EventHandler(this.SearchUserBtClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.identificationTXT);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 123);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.searchUserBt);
            this.flowLayoutPanel2.Controls.Add(this.selectBt);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 49);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // EditUserBT
            // 
            this.EditUserBT.Location = new System.Drawing.Point(84, 3);
            this.EditUserBT.Name = "EditUserBT";
            this.EditUserBT.Size = new System.Drawing.Size(75, 23);
            this.EditUserBT.TabIndex = 6;
            this.EditUserBT.Text = "Editar";
            this.EditUserBT.UseVisualStyleBackColor = true;
            this.EditUserBT.Click += new System.EventHandler(this.EditUserBTClick);
            // 
            // AddUserBt
            // 
            this.AddUserBt.Location = new System.Drawing.Point(3, 3);
            this.AddUserBt.Name = "AddUserBt";
            this.AddUserBt.Size = new System.Drawing.Size(75, 23);
            this.AddUserBt.TabIndex = 7;
            this.AddUserBt.Text = "Agregar";
            this.AddUserBt.UseVisualStyleBackColor = true;
            this.AddUserBt.Click += new System.EventHandler(this.AddUserBtClick);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.AddUserBt);
            this.flowLayoutPanel3.Controls.Add(this.EditUserBT);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 84);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // SearchClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.listBox1);
            this.Name = "SearchClientForm";
            this.Text = "SearchClientForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button selectBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.TextBox identificationTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchUserBt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button EditUserBT;
        private System.Windows.Forms.Button AddUserBt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}