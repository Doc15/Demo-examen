
namespace Dijkstra
{
    partial class frmAnalysis
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
            this.olvNodes = new BrightIdeasSoftware.FastObjectListView();
            this.node = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.orderoflabelling = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.finalworkingvalue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // olvNodes
            // 
            this.olvNodes.AllColumns.Add(this.node);
            this.olvNodes.AllColumns.Add(this.orderoflabelling);
            this.olvNodes.AllColumns.Add(this.finalworkingvalue);
            this.olvNodes.CellEditUseWholeCell = false;
            this.olvNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.node,
            this.orderoflabelling,
            this.finalworkingvalue});
            this.olvNodes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvNodes.FullRowSelect = true;
            this.olvNodes.HideSelection = false;
            this.olvNodes.Location = new System.Drawing.Point(13, 13);
            this.olvNodes.Margin = new System.Windows.Forms.Padding(4);
            this.olvNodes.Name = "olvNodes";
            this.olvNodes.ShowGroups = false;
            this.olvNodes.Size = new System.Drawing.Size(444, 632);
            this.olvNodes.TabIndex = 2;
            this.olvNodes.UseCompatibleStateImageBehavior = false;
            this.olvNodes.View = System.Windows.Forms.View.Details;
            this.olvNodes.VirtualMode = true;
            // 
            // node
            // 
            this.node.AspectName = "name";
            this.node.Text = "Узел";
            this.node.Width = 100;
            // 
            // orderoflabelling
            // 
            this.orderoflabelling.AspectName = "orderOfLabelling";
            this.orderoflabelling.Text = "Порядок";
            this.orderoflabelling.Width = 110;
            // 
            // finalworkingvalue
            // 
            this.finalworkingvalue.AspectName = "workingValue";
            this.finalworkingvalue.Text = "Значения";
            this.finalworkingvalue.Width = 120;
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 658);
            this.Controls.Add(this.olvNodes);
            this.Name = "frmAnalysis";
            this.Text = "Анализ";
            ((System.ComponentModel.ISupportInitialize)(this.olvNodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView olvNodes;
        private BrightIdeasSoftware.OLVColumn node;
        private BrightIdeasSoftware.OLVColumn orderoflabelling;
        private BrightIdeasSoftware.OLVColumn finalworkingvalue;
    }
}