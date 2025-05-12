
namespace HASH_Checker
{
    partial class HashReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashReaderForm));
            label1 = new Label();
            cmb_HashType = new ComboBox();
            btn_AddFiles = new Button();
            btn_Inspect = new Button();
            dgv_FilePaths = new DataGridView();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ofd_FileSelect = new OpenFileDialog();
            bgw_Processing = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgv_FilePaths).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Hash Type:";
            // 
            // cmb_HashType
            // 
            cmb_HashType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_HashType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_HashType.FormattingEnabled = true;
            cmb_HashType.Location = new Point(82, 6);
            cmb_HashType.Name = "cmb_HashType";
            cmb_HashType.Size = new Size(490, 23);
            cmb_HashType.TabIndex = 1;
            // 
            // btn_AddFiles
            // 
            btn_AddFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddFiles.Location = new Point(578, 5);
            btn_AddFiles.Name = "btn_AddFiles";
            btn_AddFiles.Size = new Size(102, 23);
            btn_AddFiles.TabIndex = 2;
            btn_AddFiles.Text = "Add File(s)";
            btn_AddFiles.UseVisualStyleBackColor = true;
            btn_AddFiles.Click += btn_AddFiles_Click;
            // 
            // btn_Inspect
            // 
            btn_Inspect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Inspect.Location = new Point(686, 5);
            btn_Inspect.Name = "btn_Inspect";
            btn_Inspect.Size = new Size(102, 23);
            btn_Inspect.TabIndex = 3;
            btn_Inspect.Text = "Inspect Hash";
            btn_Inspect.UseVisualStyleBackColor = true;
            btn_Inspect.Click += btn_Inspect_Click;
            // 
            // dgv_FilePaths
            // 
            dgv_FilePaths.AllowUserToAddRows = false;
            dgv_FilePaths.AllowUserToDeleteRows = false;
            dgv_FilePaths.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_FilePaths.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_FilePaths.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column1, Column2, Column3, Column4 });
            dgv_FilePaths.Location = new Point(12, 35);
            dgv_FilePaths.Name = "dgv_FilePaths";
            dgv_FilePaths.ReadOnly = true;
            dgv_FilePaths.RowHeadersVisible = false;
            dgv_FilePaths.Size = new Size(776, 403);
            dgv_FilePaths.TabIndex = 5;
            dgv_FilePaths.CellContentClick += dgv_FilePaths_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = " ";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Text = "X";
            Column5.Width = 30;
            // 
            // Column6
            // 
            Column6.HeaderText = " ";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 10;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column1.HeaderText = "File Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 85;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "File Path";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Hash String";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 10;
            // 
            // ofd_FileSelect
            // 
            ofd_FileSelect.Filter = "All Files|*.*";
            ofd_FileSelect.Multiselect = true;
            // 
            // bgw_Processing
            // 
            bgw_Processing.DoWork += bgw_Processing_DoWork;
            // 
            // HashReaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_FilePaths);
            Controls.Add(btn_Inspect);
            Controls.Add(btn_AddFiles);
            Controls.Add(cmb_HashType);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HashReaderForm";
            Text = "MARCsystems: Hash Code Checker Tool";
            ((System.ComponentModel.ISupportInitialize)dgv_FilePaths).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_HashType;
        private Button btn_AddFiles;
        private Button btn_Inspect;
        private DataGridView dgv_FilePaths;
        private OpenFileDialog ofd_FileSelect;
        private System.ComponentModel.BackgroundWorker bgw_Processing;
        private DataGridViewButtonColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
