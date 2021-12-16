
namespace Vsite.CSharp.KvadratnaJednadzba.Gui
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
            this.display = new Vsite.CSharp.KvadratnaJednadzba.Gui.display();
            this.functionPanel1 = new Vsite.CSharp.KvadratnaJednadzba.Gui.FunctionPanel();
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(296, 392);
            this.display.TabIndex = 0;
            this.display.Load += new System.EventHandler(this.display_Load);
            // 
            // functionPanel1
            // 
            this.functionPanel1.Location = new System.Drawing.Point(287, 12);
            this.functionPanel1.Name = "functionPanel1";
            this.functionPanel1.Size = new System.Drawing.Size(501, 415);
            this.functionPanel1.TabIndex = 1;
            this.functionPanel1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.functionPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private display display;
        private FunctionPanel functionPanel1;
    }
}

