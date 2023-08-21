namespace Btl_DFS
{
    partial class font1
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
            this.numNumVertices = new System.Windows.Forms.NumericUpDown();
            this.numVertex1 = new System.Windows.Forms.NumericUpDown();
            this.numVertex2 = new System.Windows.Forms.NumericUpDown();
            this.numStartVertex = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInitializeGraph = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.lstEdges = new System.Windows.Forms.ListBox();
            this.lstDFSResult = new System.Windows.Forms.ListBox();
            this.btnDFS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumVertices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertex1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertex2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartVertex)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumVertices
            // 
            this.numNumVertices.Location = new System.Drawing.Point(314, 136);
            this.numNumVertices.Name = "numNumVertices";
            this.numNumVertices.Size = new System.Drawing.Size(120, 20);
            this.numNumVertices.TabIndex = 0;
            // 
            // numVertex1
            // 
            this.numVertex1.Location = new System.Drawing.Point(314, 167);
            this.numVertex1.Name = "numVertex1";
            this.numVertex1.Size = new System.Drawing.Size(120, 20);
            this.numVertex1.TabIndex = 1;
            // 
            // numVertex2
            // 
            this.numVertex2.Location = new System.Drawing.Point(314, 198);
            this.numVertex2.Name = "numVertex2";
            this.numVertex2.Size = new System.Drawing.Size(120, 20);
            this.numVertex2.TabIndex = 2;
            // 
            // numStartVertex
            // 
            this.numStartVertex.Location = new System.Drawing.Point(314, 229);
            this.numStartVertex.Name = "numStartVertex";
            this.numStartVertex.Size = new System.Drawing.Size(120, 20);
            this.numStartVertex.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số đỉnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đỉnh xuất phát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đỉnh đích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đỉnh khởi đầu";
            // 
            // btnInitializeGraph
            // 
            this.btnInitializeGraph.AutoSize = true;
            this.btnInitializeGraph.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializeGraph.Location = new System.Drawing.Point(81, 287);
            this.btnInitializeGraph.Name = "btnInitializeGraph";
            this.btnInitializeGraph.Size = new System.Drawing.Size(353, 41);
            this.btnInitializeGraph.TabIndex = 8;
            this.btnInitializeGraph.Text = "Khởi tạo đồ thị";
            this.btnInitializeGraph.UseVisualStyleBackColor = true;
            this.btnInitializeGraph.Click += new System.EventHandler(this.btnInitializeGraph_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.AutoSize = true;
            this.btnAddEdge.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdge.Location = new System.Drawing.Point(81, 334);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(353, 41);
            this.btnAddEdge.TabIndex = 9;
            this.btnAddEdge.Text = "Thêm cạnh vào đồ thị";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // lstEdges
            // 
            this.lstEdges.FormattingEnabled = true;
            this.lstEdges.Location = new System.Drawing.Point(449, 132);
            this.lstEdges.Name = "lstEdges";
            this.lstEdges.Size = new System.Drawing.Size(263, 290);
            this.lstEdges.TabIndex = 11;
            // 
            // lstDFSResult
            // 
            this.lstDFSResult.FormattingEnabled = true;
            this.lstDFSResult.Location = new System.Drawing.Point(730, 132);
            this.lstDFSResult.Name = "lstDFSResult";
            this.lstDFSResult.Size = new System.Drawing.Size(263, 290);
            this.lstDFSResult.TabIndex = 12;
            // 
            // btnDFS
            // 
            this.btnDFS.AutoSize = true;
            this.btnDFS.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.Location = new System.Drawing.Point(81, 381);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(353, 41);
            this.btnDFS.TabIndex = 13;
            this.btnDFS.Text = "Thực Hiện";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1060, 120);
            this.label5.TabIndex = 14;
            this.label5.Text = "THUẬT TOÁN TÌM KIẾM DFS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // font1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.lstDFSResult);
            this.Controls.Add(this.lstEdges);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.btnInitializeGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numStartVertex);
            this.Controls.Add(this.numVertex2);
            this.Controls.Add(this.numVertex1);
            this.Controls.Add(this.numNumVertices);
            this.Name = "font1";
            this.Text = "DFS";
            this.Load += new System.EventHandler(this.LoadEvent);
            ((System.ComponentModel.ISupportInitialize)(this.numNumVertices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertex1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertex2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartVertex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumVertices;
        private System.Windows.Forms.NumericUpDown numVertex1;
        private System.Windows.Forms.NumericUpDown numVertex2;
        private System.Windows.Forms.NumericUpDown numStartVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInitializeGraph;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.ListBox lstEdges;
        private System.Windows.Forms.ListBox lstDFSResult;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Label label5;
    }
}

