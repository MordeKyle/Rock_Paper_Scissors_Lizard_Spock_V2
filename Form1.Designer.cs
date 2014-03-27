namespace Rock_Paper_Scissors_Lizard_Spock_V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paperPB = new System.Windows.Forms.PictureBox();
            this.rockPB = new System.Windows.Forms.PictureBox();
            this.scissorsPB = new System.Windows.Forms.PictureBox();
            this.lizardPB = new System.Windows.Forms.PictureBox();
            this.spockPB = new System.Windows.Forms.PictureBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.computerChoiceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paperPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lizardPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spockPB)).BeginInit();
            this.SuspendLayout();
            // 
            // paperPB
            // 
            this.paperPB.Image = ((System.Drawing.Image)(resources.GetObject("paperPB.Image")));
            this.paperPB.Location = new System.Drawing.Point(85, 127);
            this.paperPB.Name = "paperPB";
            this.paperPB.Size = new System.Drawing.Size(60, 60);
            this.paperPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paperPB.TabIndex = 0;
            this.paperPB.TabStop = false;
            // 
            // rockPB
            // 
            this.rockPB.Image = ((System.Drawing.Image)(resources.GetObject("rockPB.Image")));
            this.rockPB.Location = new System.Drawing.Point(170, 42);
            this.rockPB.Name = "rockPB";
            this.rockPB.Size = new System.Drawing.Size(60, 60);
            this.rockPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rockPB.TabIndex = 1;
            this.rockPB.TabStop = false;
            this.rockPB.Click += new System.EventHandler(this.rockPB_Click);
            // 
            // scissorsPB
            // 
            this.scissorsPB.Image = ((System.Drawing.Image)(resources.GetObject("scissorsPB.Image")));
            this.scissorsPB.Location = new System.Drawing.Point(255, 127);
            this.scissorsPB.Name = "scissorsPB";
            this.scissorsPB.Size = new System.Drawing.Size(60, 60);
            this.scissorsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scissorsPB.TabIndex = 2;
            this.scissorsPB.TabStop = false;
            // 
            // lizardPB
            // 
            this.lizardPB.Image = ((System.Drawing.Image)(resources.GetObject("lizardPB.Image")));
            this.lizardPB.Location = new System.Drawing.Point(115, 212);
            this.lizardPB.Name = "lizardPB";
            this.lizardPB.Size = new System.Drawing.Size(60, 60);
            this.lizardPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lizardPB.TabIndex = 3;
            this.lizardPB.TabStop = false;
            // 
            // spockPB
            // 
            this.spockPB.Image = ((System.Drawing.Image)(resources.GetObject("spockPB.Image")));
            this.spockPB.Location = new System.Drawing.Point(225, 212);
            this.spockPB.Name = "spockPB";
            this.spockPB.Size = new System.Drawing.Size(60, 60);
            this.spockPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spockPB.TabIndex = 4;
            this.spockPB.TabStop = false;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(170, 152);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(66, 13);
            this.chooseLabel.TabIndex = 5;
            this.chooseLabel.Text = "Choose One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Computer\'s Choice:";
            // 
            // computerChoiceLabel
            // 
            this.computerChoiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceLabel.Location = new System.Drawing.Point(109, 309);
            this.computerChoiceLabel.Name = "computerChoiceLabel";
            this.computerChoiceLabel.Size = new System.Drawing.Size(100, 23);
            this.computerChoiceLabel.TabIndex = 7;
            this.computerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(276, 309);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(100, 23);
            this.resultsLabel.TabIndex = 9;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.computerChoiceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.spockPB);
            this.Controls.Add(this.lizardPB);
            this.Controls.Add(this.scissorsPB);
            this.Controls.Add(this.rockPB);
            this.Controls.Add(this.paperPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors Lizard Spock";
            ((System.ComponentModel.ISupportInitialize)(this.paperPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lizardPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spockPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paperPB;
        private System.Windows.Forms.PictureBox rockPB;
        private System.Windows.Forms.PictureBox scissorsPB;
        private System.Windows.Forms.PictureBox lizardPB;
        private System.Windows.Forms.PictureBox spockPB;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultsLabel;
    }
}

