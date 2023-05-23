
namespace programma1
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
            this.butRED = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butBLUE = new System.Windows.Forms.Button();
            this.butGREEN = new System.Windows.Forms.Button();
            this.butYELLOW = new System.Windows.Forms.Button();
            this.butPURPLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butRED
            // 
            this.butRED.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butRED.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRED.ForeColor = System.Drawing.Color.Red;
            this.butRED.Location = new System.Drawing.Point(52, 224);
            this.butRED.Name = "butRED";
            this.butRED.Size = new System.Drawing.Size(125, 76);
            this.butRED.TabIndex = 0;
            this.butRED.Text = "red";
            this.butRED.UseVisualStyleBackColor = false;
            this.butRED.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click to change color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butBLUE
            // 
            this.butBLUE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butBLUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBLUE.ForeColor = System.Drawing.Color.Blue;
            this.butBLUE.Location = new System.Drawing.Point(201, 224);
            this.butBLUE.Name = "butBLUE";
            this.butBLUE.Size = new System.Drawing.Size(125, 76);
            this.butBLUE.TabIndex = 2;
            this.butBLUE.Text = "blue";
            this.butBLUE.UseVisualStyleBackColor = false;
            this.butBLUE.Click += new System.EventHandler(this.butBLUE_Click);
            // 
            // butGREEN
            // 
            this.butGREEN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butGREEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGREEN.ForeColor = System.Drawing.Color.Green;
            this.butGREEN.Location = new System.Drawing.Point(360, 224);
            this.butGREEN.Name = "butGREEN";
            this.butGREEN.Size = new System.Drawing.Size(125, 76);
            this.butGREEN.TabIndex = 3;
            this.butGREEN.Text = "green";
            this.butGREEN.UseVisualStyleBackColor = false;
            this.butGREEN.Click += new System.EventHandler(this.butGREEN_Click);
            // 
            // butYELLOW
            // 
            this.butYELLOW.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butYELLOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butYELLOW.ForeColor = System.Drawing.Color.Yellow;
            this.butYELLOW.Location = new System.Drawing.Point(512, 224);
            this.butYELLOW.Name = "butYELLOW";
            this.butYELLOW.Size = new System.Drawing.Size(125, 76);
            this.butYELLOW.TabIndex = 4;
            this.butYELLOW.Text = "yellow";
            this.butYELLOW.UseVisualStyleBackColor = false;
            this.butYELLOW.Click += new System.EventHandler(this.butYELLOW_Click);
            // 
            // butPURPLE
            // 
            this.butPURPLE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butPURPLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPURPLE.ForeColor = System.Drawing.Color.Fuchsia;
            this.butPURPLE.Location = new System.Drawing.Point(663, 224);
            this.butPURPLE.Name = "butPURPLE";
            this.butPURPLE.Size = new System.Drawing.Size(125, 76);
            this.butPURPLE.TabIndex = 5;
            this.butPURPLE.Text = "purple";
            this.butPURPLE.UseVisualStyleBackColor = false;
            this.butPURPLE.Click += new System.EventHandler(this.butPURPLE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butPURPLE);
            this.Controls.Add(this.butYELLOW);
            this.Controls.Add(this.butGREEN);
            this.Controls.Add(this.butBLUE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRED);
            this.Name = "Form1";
            this.Text = "krasains ekrans";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRED;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butBLUE;
        private System.Windows.Forms.Button butGREEN;
        private System.Windows.Forms.Button butYELLOW;
        private System.Windows.Forms.Button butPURPLE;
    }
}

