namespace redTaller.Vista
{
    partial class VistaListaProvincia
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(800, 45);
            this.panelTop.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.gridPrincipal);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 45);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(800, 405);
            this.panelCenter.TabIndex = 2;
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPrincipal.Location = new System.Drawing.Point(0, 0);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.Size = new System.Drawing.Size(800, 405);
            this.gridPrincipal.TabIndex = 1;
            // 
            // textSearch
            // 
            this.textSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.textSearch.Location = new System.Drawing.Point(547, 10);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(243, 20);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // VistaListaProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Name = "VistaListaProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincia";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridView gridPrincipal;
        private System.Windows.Forms.TextBox textSearch;
    }
}