namespace Nutrition_App
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
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtbxResults = new System.Windows.Forms.TextBox();
            this.txtbxAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbxCarbs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.Location = new System.Drawing.Point(12, 12);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(383, 49);
            this.txtbxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(427, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 49);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 202);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(153, 42);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Results:";
            // 
            // txtbxResults
            // 
            this.txtbxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxResults.Location = new System.Drawing.Point(12, 247);
            this.txtbxResults.Multiline = true;
            this.txtbxResults.Name = "txtbxResults";
            this.txtbxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxResults.Size = new System.Drawing.Size(383, 523);
            this.txtbxResults.TabIndex = 5;
            // 
            // txtbxAdd
            // 
            this.txtbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAdd.Location = new System.Drawing.Point(12, 94);
            this.txtbxAdd.Name = "txtbxAdd";
            this.txtbxAdd.Size = new System.Drawing.Size(378, 49);
            this.txtbxAdd.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(624, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 49);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbxCarbs
            // 
            this.txtbxCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCarbs.Location = new System.Drawing.Point(427, 97);
            this.txtbxCarbs.Name = "txtbxCarbs";
            this.txtbxCarbs.Size = new System.Drawing.Size(153, 49);
            this.txtbxCarbs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 792);
            this.Controls.Add(this.txtbxCarbs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbxAdd);
            this.Controls.Add(this.txtbxResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Name = "Form1";
            this.Text = "Nutrition Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtbxResults;
        private System.Windows.Forms.TextBox txtbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxCarbs;
    }
}

