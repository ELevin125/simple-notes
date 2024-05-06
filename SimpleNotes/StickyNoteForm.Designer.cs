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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNoteForm));
            this.btn_delete = new System.Windows.Forms.Button();
            this.imgList_toolbar = new System.Windows.Forms.ImageList(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.rtxt_mainText = new System.Windows.Forms.RichTextBox();
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_pin = new System.Windows.Forms.Button();
            this.pnl_highlight = new System.Windows.Forms.Panel();
            this.panel_main.SuspendLayout();
            this.pnl_topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ImageKey = "close.png";
            this.btn_delete.ImageList = this.imgList_toolbar;
            this.btn_delete.Location = new System.Drawing.Point(300, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(25, 25);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.TabStop = false;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // imgList_toolbar
            // 
            this.imgList_toolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList_toolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_toolbar.ImageStream")));
            this.imgList_toolbar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_toolbar.Images.SetKeyName(0, "add.png");
            this.imgList_toolbar.Images.SetKeyName(1, "pin.png");
            this.imgList_toolbar.Images.SetKeyName(2, "unpin.png");
            this.imgList_toolbar.Images.SetKeyName(3, "close.png");
            this.imgList_toolbar.Images.SetKeyName(4, "save.png");
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.LightCyan;
            this.panel_main.Controls.Add(this.rtxt_mainText);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_main.Location = new System.Drawing.Point(0, 25);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(324, 289);
            this.panel_main.TabIndex = 11;
            // 
            // rtxt_mainText
            // 
            this.rtxt_mainText.BackColor = System.Drawing.Color.LightCyan;
            this.rtxt_mainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_mainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_mainText.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxt_mainText.Location = new System.Drawing.Point(10, 10);
            this.rtxt_mainText.Name = "rtxt_mainText";
            this.rtxt_mainText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxt_mainText.Size = new System.Drawing.Size(304, 269);
            this.rtxt_mainText.TabIndex = 0;
            this.rtxt_mainText.Text = "";
            this.rtxt_mainText.DoubleClick += new System.EventHandler(this.rtxt_mainText_DoubleClick);
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnl_topBar.Controls.Add(this.btn_save);
            this.pnl_topBar.Controls.Add(this.btn_add);
            this.pnl_topBar.Controls.Add(this.btn_delete);
            this.pnl_topBar.Controls.Add(this.btn_pin);
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(325, 26);
            this.pnl_topBar.TabIndex = 13;
            this.pnl_topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_topBar_MouseDown);
            this.pnl_topBar.MouseLeave += new System.EventHandler(this.pnl_topBar_MouseLeave);
            this.pnl_topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_topBar_MouseMove);
            this.pnl_topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_topBar_MouseUp);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ImageKey = "save.png";
            this.btn_save.ImageList = this.imgList_toolbar;
            this.btn_save.Location = new System.Drawing.Point(225, 0);
            this.btn_save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(25, 25);
            this.btn_save.TabIndex = 16;
            this.btn_save.TabStop = false;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ImageKey = "add.png";
            this.btn_add.ImageList = this.imgList_toolbar;
            this.btn_add.Location = new System.Drawing.Point(275, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(25, 25);
            this.btn_add.TabIndex = 15;
            this.btn_add.TabStop = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_pin
            // 
            this.btn_pin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_pin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pin.FlatAppearance.BorderSize = 0;
            this.btn_pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pin.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pin.ImageKey = "pin.png";
            this.btn_pin.ImageList = this.imgList_toolbar;
            this.btn_pin.Location = new System.Drawing.Point(250, 0);
            this.btn_pin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(25, 25);
            this.btn_pin.TabIndex = 14;
            this.btn_pin.TabStop = false;
            this.btn_pin.UseVisualStyleBackColor = false;
            this.btn_pin.Click += new System.EventHandler(this.btn_pin_Click);
            // 
            // pnl_highlight
            // 
            this.pnl_highlight.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnl_highlight.Location = new System.Drawing.Point(0, 0);
            this.pnl_highlight.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_highlight.Name = "pnl_highlight";
            this.pnl_highlight.Size = new System.Drawing.Size(325, 15);
            this.pnl_highlight.TabIndex = 2;
            this.pnl_highlight.MouseEnter += new System.EventHandler(this.pnl_highlight_MouseEnter);
            // 
            // StickyNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(324, 314);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_highlight);
            this.Controls.Add(this.pnl_topBar);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StickyNoteForm";
            this.panel_main.ResumeLayout(false);
            this.pnl_topBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_delete;
        private Panel panel_main;
        private Panel pnl_topBar;
        private Button btn_pin;
        private Button btn_add;
        private ImageList imgList_toolbar;
        private Button btn_save;
        private Panel pnl_highlight;
        private RichTextBox rtxt_mainText;
    }
}