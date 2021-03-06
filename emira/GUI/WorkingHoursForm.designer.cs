namespace emira.GUI
{
    partial class WorkingHoursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingHoursForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnMinimalize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pMenuBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnMSWord = new System.Windows.Forms.Button();
            this.btnAddRemoveTask = new System.Windows.Forms.Button();
            this.cbYearWithMonth = new System.Windows.Forms.ComboBox();
            this.dgvWorkingHours = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lMonth = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.pHeader.SuspendLayout();
            this.pMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingHours)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pHeader.Controls.Add(this.btnMaximize);
            this.pHeader.Controls.Add(this.lTitle);
            this.pHeader.Controls.Add(this.btnMinimalize);
            this.pHeader.Controls.Add(this.btnExit);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1030, 30);
            this.pHeader.TabIndex = 0;
            this.pHeader.DoubleClick += new System.EventHandler(this.pHeader_DoubleClick);
            this.pHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseDown);
            this.pHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseMove);
            this.pHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = global::emira.Properties.Resources.maximize_icon_white_26;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(930, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 30);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(305, 29);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Emira - Munkaidő Kezelő";
            // 
            // btnMinimalize
            // 
            this.btnMinimalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimalize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimalize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimalize.BackgroundImage")));
            this.btnMinimalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimalize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMinimalize.FlatAppearance.BorderSize = 0;
            this.btnMinimalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMinimalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMinimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimalize.Location = new System.Drawing.Point(880, 0);
            this.btnMinimalize.Name = "btnMinimalize";
            this.btnMinimalize.Size = new System.Drawing.Size(50, 30);
            this.btnMinimalize.TabIndex = 3;
            this.btnMinimalize.UseVisualStyleBackColor = false;
            this.btnMinimalize.Click += new System.EventHandler(this.btnMinimalize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(980, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pMenuBar
            // 
            this.pMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pMenuBar.Controls.Add(this.btnHome);
            this.pMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenuBar.Location = new System.Drawing.Point(0, 30);
            this.pMenuBar.Name = "pMenuBar";
            this.pMenuBar.Size = new System.Drawing.Size(1030, 85);
            this.pMenuBar.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(181, 84);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(186)))), ((int)(((byte)(62)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(167)))), ((int)(((byte)(55)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(167)))), ((int)(((byte)(55)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::emira.Properties.Resources.save_icon_white_32;
            this.btnSave.Location = new System.Drawing.Point(30, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Mentés";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPDF.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(133)))), ((int)(((byte)(218)))));
            this.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(133)))), ((int)(((byte)(218)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Image = global::emira.Properties.Resources.pdf_icon_white_32;
            this.btnPDF.Location = new System.Drawing.Point(294, 142);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(120, 50);
            this.btnPDF.TabIndex = 3;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnMSWord
            // 
            this.btnMSWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btnMSWord.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMSWord.FlatAppearance.BorderSize = 0;
            this.btnMSWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnMSWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.btnMSWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMSWord.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMSWord.ForeColor = System.Drawing.Color.White;
            this.btnMSWord.Image = global::emira.Properties.Resources.word_icon_white_32;
            this.btnMSWord.Location = new System.Drawing.Point(420, 142);
            this.btnMSWord.Name = "btnMSWord";
            this.btnMSWord.Size = new System.Drawing.Size(140, 50);
            this.btnMSWord.TabIndex = 4;
            this.btnMSWord.Text = "MS Word";
            this.btnMSWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMSWord.UseVisualStyleBackColor = false;
            this.btnMSWord.Click += new System.EventHandler(this.btnMSWord_Click);
            // 
            // btnAddRemoveTask
            // 
            this.btnAddRemoveTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRemoveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.btnAddRemoveTask.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddRemoveTask.FlatAppearance.BorderSize = 0;
            this.btnAddRemoveTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(98)))));
            this.btnAddRemoveTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(98)))));
            this.btnAddRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRemoveTask.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRemoveTask.ForeColor = System.Drawing.Color.White;
            this.btnAddRemoveTask.Image = global::emira.Properties.Resources.task_icon_white_32;
            this.btnAddRemoveTask.Location = new System.Drawing.Point(783, 142);
            this.btnAddRemoveTask.Name = "btnAddRemoveTask";
            this.btnAddRemoveTask.Size = new System.Drawing.Size(217, 50);
            this.btnAddRemoveTask.TabIndex = 5;
            this.btnAddRemoveTask.Text = "Feladat hozzáadás";
            this.btnAddRemoveTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRemoveTask.UseVisualStyleBackColor = false;
            this.btnAddRemoveTask.Click += new System.EventHandler(this.btnAddRemoveTask_Click);
            // 
            // cbYearWithMonth
            // 
            this.cbYearWithMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbYearWithMonth.FormattingEnabled = true;
            this.cbYearWithMonth.Location = new System.Drawing.Point(621, 154);
            this.cbYearWithMonth.MaxDropDownItems = 12;
            this.cbYearWithMonth.Name = "cbYearWithMonth";
            this.cbYearWithMonth.Size = new System.Drawing.Size(100, 32);
            this.cbYearWithMonth.TabIndex = 6;
            this.cbYearWithMonth.Text = "Hónap";
            this.cbYearWithMonth.DropDownClosed += new System.EventHandler(this.cbYearWithMonth_DropDownClosed);
            this.cbYearWithMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbYearWithMonth_KeyPress);
            // 
            // dgvWorkingHours
            // 
            this.dgvWorkingHours.AllowUserToAddRows = false;
            this.dgvWorkingHours.AllowUserToDeleteRows = false;
            this.dgvWorkingHours.AllowUserToResizeColumns = false;
            this.dgvWorkingHours.AllowUserToResizeRows = false;
            this.dgvWorkingHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkingHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWorkingHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWorkingHours.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvWorkingHours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkingHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkingHours.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkingHours.Location = new System.Drawing.Point(30, 261);
            this.dgvWorkingHours.Name = "dgvWorkingHours";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvWorkingHours.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWorkingHours.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvWorkingHours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvWorkingHours.Size = new System.Drawing.Size(970, 368);
            this.dgvWorkingHours.TabIndex = 7;
            this.dgvWorkingHours.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkingHours_CellEndEdit);
            this.dgvWorkingHours.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvWorkingHours_CellValidating);
            this.dgvWorkingHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvWorkingHours_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(725, 157);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.TabIndex = 9;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(592, 157);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 25);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lMonth
            // 
            this.lMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMonth.AutoSize = true;
            this.lMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMonth.Location = new System.Drawing.Point(459, 219);
            this.lMonth.Name = "lMonth";
            this.lMonth.Size = new System.Drawing.Size(118, 39);
            this.lMonth.TabIndex = 10;
            this.lMonth.Text = "Hónap";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(116)))), ((int)(((byte)(38)))));
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(116)))), ((int)(((byte)(38)))));
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Image = global::emira.Properties.Resources.lock_icon_white_32;
            this.btnLock.Location = new System.Drawing.Point(156, 142);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(132, 50);
            this.btnLock.TabIndex = 11;
            this.btnLock.Text = "Lezárás";
            this.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // WorkingHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 650);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.lMonth);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dgvWorkingHours);
            this.Controls.Add(this.cbYearWithMonth);
            this.Controls.Add(this.btnAddRemoveTask);
            this.Controls.Add(this.btnMSWord);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pMenuBar);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkingHoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.WorkingHours_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pMenuBar;
        private System.Windows.Forms.Button btnMinimalize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnMSWord;
        private System.Windows.Forms.Button btnAddRemoveTask;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lMonth;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.DataGridView dgvWorkingHours;
        private System.Windows.Forms.ComboBox cbYearWithMonth;
        private System.Windows.Forms.Button btnLock;
    }
}