﻿namespace RecipeApp
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 608);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(-1, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Placeholder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(-1, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Placeholder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(-1, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Placeholder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Add
            // 
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.Control;
            this.Add.Location = new System.Drawing.Point(-1, 145);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(214, 50);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add Recipe";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(168, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.PlaceholderText = "Find a recipe...";
            this.txtRecipeName.Size = new System.Drawing.Size(209, 23);
            this.txtRecipeName.TabIndex = 2;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.FlatAppearance.BorderSize = 0;
            this.btnAddRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnAddRecipe.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRecipe.ForeColor = System.Drawing.Color.Black;
            this.btnAddRecipe.Location = new System.Drawing.Point(383, 3);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(86, 23);
            this.btnAddRecipe.TabIndex = 3;
            this.btnAddRecipe.Text = "Find";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(220, 0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(472, 560);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddRecipe);
            this.flowLayoutPanel1.Controls.Add(this.txtRecipeName);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(220, 566);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 42);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Recipe App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListView listView1;
        private TextBox txtRecipeName;
        private Button btnAddRecipe;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Add;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}