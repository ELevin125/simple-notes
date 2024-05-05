namespace SimpleNotes
{
    partial class StickyNoteForm
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
            this.txt_mainNote = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.btn_pin = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_mainNote
            // 
            this.txt_mainNote.BackColor = System.Drawing.Color.LightCyan;
            this.txt_mainNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mainNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mainNote.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_mainNote.Location = new System.Drawing.Point(10, 10);
            this.txt_mainNote.Margin = new System.Windows.Forms.Padding(10);
            this.txt_mainNote.Multiline = true;
            this.txt_mainNote.Name = "txt_mainNote";
            this.txt_mainNote.PlaceholderText = "Note";
            this.txt_mainNote.Size = new System.Drawing.Size(305, 267);
            this.txt_mainNote.TabIndex = 1;
            this.txt_mainNote.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.LightCyan;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Image = global::SimpleNotes.Properties.Resources.close;
            this.btn_delete.Location = new System.Drawing.Point(296, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(24, 24);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.TabStop = false;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.txt_mainNote);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(325, 287);
            this.panel1.TabIndex = 11;
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(231, 26);
            this.pnl_topBar.TabIndex = 13;
            this.pnl_topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_topBar_MouseMove);
            // 
            // btn_pin
            // 
            this.btn_pin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pin.BackColor = System.Drawing.Color.LightCyan;
            this.btn_pin.FlatAppearance.BorderSize = 0;
            this.btn_pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pin.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pin.Image = global::SimpleNotes.Properties.Resources.pin;
            this.btn_pin.Location = new System.Drawing.Point(264, 0);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(24, 24);
            this.btn_pin.TabIndex = 14;
            this.btn_pin.TabStop = false;
            this.btn_pin.UseVisualStyleBackColor = false;
            this.btn_pin.Click += new System.EventHandler(this.btn_pin_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.LightCyan;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Image = global::SimpleNotes.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(234, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(24, 24);
            this.btn_add.TabIndex = 15;
            this.btn_add.TabStop = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // StickyNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(324, 314);
            this.ControlBox = false;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_pin);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StickyNoteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txt_mainNote;
        private Button btn_delete;
        private Panel panel1;
        private Panel pnl_topBar;
        private Button btn_pin;
        private Button btn_add;
    }
}