namespace DLCupController
{
    partial class frmMain
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnSubtractHomeScore = new System.Windows.Forms.Button();
            this.btnAddHomeScore = new System.Windows.Forms.Button();
            this.btnSubtractGuestScore = new System.Windows.Forms.Button();
            this.btnAddGuestScore = new System.Windows.Forms.Button();
            this.cboMatch = new System.Windows.Forms.ComboBox();
            this.cboSet = new System.Windows.Forms.ComboBox();
            this.btnResetSet = new System.Windows.Forms.Button();
            this.btnRemoveSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnSubtractHomeScore);
            this.splitContainer.Panel1.Controls.Add(this.btnAddHomeScore);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnSubtractGuestScore);
            this.splitContainer.Panel2.Controls.Add(this.btnAddGuestScore);
            this.splitContainer.Size = new System.Drawing.Size(557, 208);
            this.splitContainer.SplitterDistance = 274;
            this.splitContainer.TabIndex = 1;
            // 
            // btnSubtractHomeScore
            // 
            this.btnSubtractHomeScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubtractHomeScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubtractHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractHomeScore.Location = new System.Drawing.Point(0, 179);
            this.btnSubtractHomeScore.Name = "btnSubtractHomeScore";
            this.btnSubtractHomeScore.Size = new System.Drawing.Size(274, 29);
            this.btnSubtractHomeScore.TabIndex = 1;
            this.btnSubtractHomeScore.Text = "-";
            this.btnSubtractHomeScore.UseVisualStyleBackColor = false;
            this.btnSubtractHomeScore.Click += new System.EventHandler(this.btnSubtractHomeScore_Click);
            // 
            // btnAddHomeScore
            // 
            this.btnAddHomeScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHomeScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHomeScore.Location = new System.Drawing.Point(0, 0);
            this.btnAddHomeScore.Name = "btnAddHomeScore";
            this.btnAddHomeScore.Size = new System.Drawing.Size(274, 179);
            this.btnAddHomeScore.TabIndex = 0;
            this.btnAddHomeScore.Text = "H&emma +";
            this.btnAddHomeScore.UseVisualStyleBackColor = false;
            this.btnAddHomeScore.Click += new System.EventHandler(this.btnAddHomeScore_Click);
            // 
            // btnSubtractGuestScore
            // 
            this.btnSubtractGuestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubtractGuestScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubtractGuestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractGuestScore.Location = new System.Drawing.Point(0, 179);
            this.btnSubtractGuestScore.Name = "btnSubtractGuestScore";
            this.btnSubtractGuestScore.Size = new System.Drawing.Size(279, 29);
            this.btnSubtractGuestScore.TabIndex = 2;
            this.btnSubtractGuestScore.Text = "-";
            this.btnSubtractGuestScore.UseVisualStyleBackColor = false;
            this.btnSubtractGuestScore.Click += new System.EventHandler(this.btnSubtractGuestScore_Click);
            // 
            // btnAddGuestScore
            // 
            this.btnAddGuestScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGuestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddGuestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuestScore.Location = new System.Drawing.Point(0, 0);
            this.btnAddGuestScore.Name = "btnAddGuestScore";
            this.btnAddGuestScore.Size = new System.Drawing.Size(279, 179);
            this.btnAddGuestScore.TabIndex = 2;
            this.btnAddGuestScore.Text = "B&orta +";
            this.btnAddGuestScore.UseVisualStyleBackColor = false;
            this.btnAddGuestScore.Click += new System.EventHandler(this.btnAddGuestScore_Click);
            // 
            // cboMatch
            // 
            this.cboMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMatch.FormattingEnabled = true;
            this.cboMatch.Location = new System.Drawing.Point(12, 222);
            this.cboMatch.Name = "cboMatch";
            this.cboMatch.Size = new System.Drawing.Size(193, 21);
            this.cboMatch.TabIndex = 2;
            this.cboMatch.SelectedIndexChanged += new System.EventHandler(this.cboMatch_SelectedIndexChanged);
            // 
            // cboSet
            // 
            this.cboSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSet.FormattingEnabled = true;
            this.cboSet.Location = new System.Drawing.Point(12, 249);
            this.cboSet.Name = "cboSet";
            this.cboSet.Size = new System.Drawing.Size(193, 21);
            this.cboSet.TabIndex = 3;
            // 
            // btnResetSet
            // 
            this.btnResetSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSet.Location = new System.Drawing.Point(226, 247);
            this.btnResetSet.Name = "btnResetSet";
            this.btnResetSet.Size = new System.Drawing.Size(75, 23);
            this.btnResetSet.TabIndex = 4;
            this.btnResetSet.TabStop = false;
            this.btnResetSet.Text = "Nollställ SET";
            this.btnResetSet.UseVisualStyleBackColor = true;
            this.btnResetSet.Click += new System.EventHandler(this.btnResetSet_Click);
            // 
            // btnRemoveSet
            // 
            this.btnRemoveSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSet.Location = new System.Drawing.Point(307, 247);
            this.btnRemoveSet.Name = "btnRemoveSet";
            this.btnRemoveSet.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSet.TabIndex = 5;
            this.btnRemoveSet.TabStop = false;
            this.btnRemoveSet.Text = "Ta bort SET";
            this.btnRemoveSet.UseVisualStyleBackColor = true;
            this.btnRemoveSet.Click += new System.EventHandler(this.btnRemoveSet_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 282);
            this.Controls.Add(this.btnRemoveSet);
            this.Controls.Add(this.btnResetSet);
            this.Controls.Add(this.cboSet);
            this.Controls.Add(this.cboMatch);
            this.Controls.Add(this.splitContainer);
            this.Name = "frmMain";
            this.Text = "DLCup Controller";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnAddHomeScore;
        private System.Windows.Forms.Button btnAddGuestScore;
        private System.Windows.Forms.Button btnSubtractHomeScore;
        private System.Windows.Forms.Button btnSubtractGuestScore;
        private System.Windows.Forms.ComboBox cboMatch;
        private System.Windows.Forms.ComboBox cboSet;
        private System.Windows.Forms.Button btnResetSet;
        private System.Windows.Forms.Button btnRemoveSet;

    }
}

