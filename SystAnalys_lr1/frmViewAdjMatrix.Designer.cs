namespace SystAnalys_lr1
{
    partial class frmViewAdjMatrix
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
            this.lvwAdjMatrix = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwAdjMatrix
            // 
            this.lvwAdjMatrix.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvwAdjMatrix.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwAdjMatrix.HideSelection = false;
            this.lvwAdjMatrix.Location = new System.Drawing.Point(10, 11);
            this.lvwAdjMatrix.Name = "lvwAdjMatrix";
            this.lvwAdjMatrix.Size = new System.Drawing.Size(173, 28);
            this.lvwAdjMatrix.TabIndex = 1;
            this.lvwAdjMatrix.UseCompatibleStateImageBehavior = false;
            this.lvwAdjMatrix.View = System.Windows.Forms.View.Details;
            // 
            // frmViewAdjMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 48);
            this.Controls.Add(this.lvwAdjMatrix);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewAdjMatrix";
            this.Text = "Матрица";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwAdjMatrix;
    }

#endregion

    private System.Windows.Forms.TextBox lvwAdjMatrix;
    }
}