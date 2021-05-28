
namespace Tic_Tac_Toe
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(13, 89);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(145, 137);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(164, 89);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(145, 137);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(315, 89);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(145, 137);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(315, 232);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(145, 137);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(164, 232);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(145, 137);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(13, 232);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(145, 137);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(315, 375);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(145, 137);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(164, 375);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(145, 137);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(13, 375);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(145, 137);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources._5570238;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 599);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
    }
}

