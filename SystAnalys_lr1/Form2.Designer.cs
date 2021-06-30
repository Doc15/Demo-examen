namespace SystAnalys_lr1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.AddObjects = new System.Windows.Forms.Button();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.olvNodes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Objects = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.btnViewAdjMatrix = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddObjects
            // 
            this.AddObjects.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddObjects.Location = new System.Drawing.Point(20, 341);
            this.AddObjects.Name = "AddObjects";
            this.AddObjects.Size = new System.Drawing.Size(37, 23);
            this.AddObjects.TabIndex = 2;
            this.AddObjects.Text = "+";
            this.AddObjects.UseVisualStyleBackColor = true;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveNode.Location = new System.Drawing.Point(92, 341);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(37, 23);
            this.btnRemoveNode.TabIndex = 3;
            this.btnRemoveNode.Text = "-";
            this.btnRemoveNode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFrom.Location = new System.Drawing.Point(252, 345);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 21);
            this.txtFrom.TabIndex = 4;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTo.Location = new System.Drawing.Point(403, 345);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 21);
            this.txtTo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ИЗ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(383, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "В";
            // 
            // olvNodes
            // 
            this.olvNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.olvNodes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvNodes.HideSelection = false;
            this.olvNodes.Location = new System.Drawing.Point(19, 39);
            this.olvNodes.Name = "olvNodes";
            this.olvNodes.Size = new System.Drawing.Size(121, 277);
            this.olvNodes.TabIndex = 8;
            this.olvNodes.UseCompatibleStateImageBehavior = false;
            this.olvNodes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Узел";
            // 
            // Objects
            // 
            this.Objects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Objects.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Objects.HideSelection = false;
            this.Objects.Location = new System.Drawing.Point(209, 39);
            this.Objects.Name = "Objects";
            this.Objects.Size = new System.Drawing.Size(294, 277);
            this.Objects.TabIndex = 9;
            this.Objects.UseCompatibleStateImageBehavior = false;
            this.Objects.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Из";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "В";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Путь";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(529, 343);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnAddPath
            // 
            this.btnAddPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPath.Location = new System.Drawing.Point(529, 39);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(75, 23);
            this.btnAddPath.TabIndex = 11;
            this.btnAddPath.Text = "Добавить путь";
            this.btnAddPath.UseVisualStyleBackColor = true;
            // 
            // btnRemovePath
            // 
            this.btnRemovePath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemovePath.Location = new System.Drawing.Point(529, 98);
            this.btnRemovePath.Name = "btnRemovePath";
            this.btnRemovePath.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePath.TabIndex = 12;
            this.btnRemovePath.Text = "Удалить путь";
            this.btnRemovePath.UseVisualStyleBackColor = true;
            // 
            // btnViewAdjMatrix
            // 
            this.btnViewAdjMatrix.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewAdjMatrix.Location = new System.Drawing.Point(529, 266);
            this.btnViewAdjMatrix.Name = "btnViewAdjMatrix";
            this.btnViewAdjMatrix.Size = new System.Drawing.Size(95, 41);
            this.btnViewAdjMatrix.TabIndex = 13;
            this.btnViewAdjMatrix.Text = "Посмотреть матрицу";
            this.btnViewAdjMatrix.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(634, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewAdjMatrix);
            this.Controls.Add(this.btnRemovePath);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.Objects);
            this.Controls.Add(this.olvNodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnRemoveNode);
            this.Controls.Add(this.AddObjects);
            this.Name = "Form2";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddObjects;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView olvNodes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView Objects;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.Button btnRemovePath;
        private System.Windows.Forms.Button btnViewAdjMatrix;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}