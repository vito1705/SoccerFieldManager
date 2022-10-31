namespace SoccerFieldManager
{
    partial class SoccerFieldForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.isChildrenChBx = new System.Windows.Forms.CheckBox();
            this.soccerFieldCBX = new System.Windows.Forms.ComboBox();
            this.selectPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.editBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combsoccerFieldFatherCBX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameSoccerFieldTxB = new System.Windows.Forms.TextBox();
            this.saveBt = new System.Windows.Forms.Button();
            this.savePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxB = new System.Windows.Forms.TextBox();
            this.selectPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canchas";
            // 
            // isChildrenChBx
            // 
            this.isChildrenChBx.AutoSize = true;
            this.isChildrenChBx.Location = new System.Drawing.Point(10, 88);
            this.isChildrenChBx.Name = "isChildrenChBx";
            this.isChildrenChBx.Size = new System.Drawing.Size(144, 17);
            this.isChildrenChBx.TabIndex = 1;
            this.isChildrenChBx.Text = "Pertenece a otra cancha";
            this.isChildrenChBx.UseVisualStyleBackColor = true;
            // 
            // soccerFieldCBX
            // 
            this.soccerFieldCBX.DropDownHeight = 150;
            this.soccerFieldCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soccerFieldCBX.FormattingEnabled = true;
            this.soccerFieldCBX.IntegralHeight = false;
            this.soccerFieldCBX.Location = new System.Drawing.Point(10, 23);
            this.soccerFieldCBX.Name = "soccerFieldCBX";
            this.soccerFieldCBX.Size = new System.Drawing.Size(243, 21);
            this.soccerFieldCBX.TabIndex = 2;
            this.soccerFieldCBX.SelectedIndexChanged += new System.EventHandler(this.soccerFieldCBX_SelectedIndexChanged);
            // 
            // selectPanel
            // 
            this.selectPanel.AutoSize = true;
            this.selectPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectPanel.Controls.Add(this.label1);
            this.selectPanel.Controls.Add(this.soccerFieldCBX);
            this.selectPanel.Controls.Add(this.flowLayoutPanel2);
            this.selectPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.selectPanel.Location = new System.Drawing.Point(10, 10);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Padding = new System.Windows.Forms.Padding(7);
            this.selectPanel.Size = new System.Drawing.Size(263, 96);
            this.selectPanel.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.editBt);
            this.flowLayoutPanel2.Controls.Add(this.deleteBt);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 36);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(3, 3);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(93, 30);
            this.editBt.TabIndex = 4;
            this.editBt.Text = "Editar";
            this.editBt.UseVisualStyleBackColor = true;
            // 
            // deleteBt
            // 
            this.deleteBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBt.Location = new System.Drawing.Point(102, 3);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(93, 30);
            this.deleteBt.TabIndex = 5;
            this.deleteBt.Text = "Borrar";
            this.deleteBt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Cancha";
            // 
            // combsoccerFieldFatherCBX
            // 
            this.combsoccerFieldFatherCBX.FormattingEnabled = true;
            this.combsoccerFieldFatherCBX.Location = new System.Drawing.Point(10, 124);
            this.combsoccerFieldFatherCBX.Name = "combsoccerFieldFatherCBX";
            this.combsoccerFieldFatherCBX.Size = new System.Drawing.Size(243, 21);
            this.combsoccerFieldFatherCBX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione la cancha a la cual pertenece";
            // 
            // nameSoccerFieldTxB
            // 
            this.nameSoccerFieldTxB.Location = new System.Drawing.Point(10, 23);
            this.nameSoccerFieldTxB.MaxLength = 48;
            this.nameSoccerFieldTxB.Name = "nameSoccerFieldTxB";
            this.nameSoccerFieldTxB.Size = new System.Drawing.Size(243, 20);
            this.nameSoccerFieldTxB.TabIndex = 9;
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(10, 151);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(93, 30);
            this.saveBt.TabIndex = 10;
            this.saveBt.Text = "Guardar";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBtClick);
            // 
            // savePanel
            // 
            this.savePanel.AutoSize = true;
            this.savePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savePanel.Controls.Add(this.label2);
            this.savePanel.Controls.Add(this.nameSoccerFieldTxB);
            this.savePanel.Controls.Add(this.label4);
            this.savePanel.Controls.Add(this.priceTxB);
            this.savePanel.Controls.Add(this.isChildrenChBx);
            this.savePanel.Controls.Add(this.label3);
            this.savePanel.Controls.Add(this.combsoccerFieldFatherCBX);
            this.savePanel.Controls.Add(this.saveBt);
            this.savePanel.Enabled = false;
            this.savePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.savePanel.Location = new System.Drawing.Point(279, 10);
            this.savePanel.Name = "savePanel";
            this.savePanel.Padding = new System.Windows.Forms.Padding(7);
            this.savePanel.Size = new System.Drawing.Size(263, 191);
            this.savePanel.TabIndex = 11;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.selectPanel);
            this.flowLayoutPanel4.Controls.Add(this.savePanel);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(7);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(552, 211);
            this.flowLayoutPanel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // priceTxB
            // 
            this.priceTxB.Location = new System.Drawing.Point(10, 62);
            this.priceTxB.Name = "priceTxB";
            this.priceTxB.Size = new System.Drawing.Size(243, 20);
            this.priceTxB.TabIndex = 12;
            // 
            // SoccerFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 228);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "SoccerFieldForm";
            this.Text = "SoccerFieldForm";
            this.Load += new System.EventHandler(this.SoccerFieldForm_Load);
            this.selectPanel.ResumeLayout(false);
            this.selectPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isChildrenChBx;
        private System.Windows.Forms.ComboBox soccerFieldCBX;
        private System.Windows.Forms.FlowLayoutPanel selectPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combsoccerFieldFatherCBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameSoccerFieldTxB;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.FlowLayoutPanel savePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxB;
    }
}