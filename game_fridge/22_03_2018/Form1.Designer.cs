namespace _22_03_2018
{
    partial class frmFridge
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGame = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGame
            // 
            this.dgvGame.AllowUserToResizeColumns = false;
            this.dgvGame.AllowUserToResizeRows = false;
            this.dgvGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGame.ColumnHeadersVisible = false;
            this.dgvGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGame.Location = new System.Drawing.Point(0, 0);
            this.dgvGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGame.Name = "dgvGame";
            this.dgvGame.RowHeadersVisible = false;
            this.dgvGame.Size = new System.Drawing.Size(585, 506);
            this.dgvGame.TabIndex = 0;
            this.dgvGame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGame_CellClick);
            // 
            // frmFridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 506);
            this.Controls.Add(this.dgvGame);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFridge";
            this.Text = "Холодильник";
            this.Load += new System.EventHandler(this.frmFridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGame;
    }
}

