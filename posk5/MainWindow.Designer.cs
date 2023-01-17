namespace posk5
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.btnA = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnMov = new System.Windows.Forms.Button();
            this.groupCommands = new System.Windows.Forms.GroupBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.shortcutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSh8 = new System.Windows.Forms.Button();
            this.btnSh7 = new System.Windows.Forms.Button();
            this.btnSh6 = new System.Windows.Forms.Button();
            this.btnSh5 = new System.Windows.Forms.Button();
            this.btnSh1 = new System.Windows.Forms.Button();
            this.btnSh2 = new System.Windows.Forms.Button();
            this.btnSh3 = new System.Windows.Forms.Button();
            this.btnSh4 = new System.Windows.Forms.Button();
            this.resulltBox = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentQueue = new System.Windows.Forms.TextBox();
            this.groupRegs = new System.Windows.Forms.GroupBox();
            this.valuesRegs = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDX = new System.Windows.Forms.Label();
            this.labelAX = new System.Windows.Forms.Label();
            this.labelCX = new System.Windows.Forms.Label();
            this.labelBX = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQueueClr = new System.Windows.Forms.Button();
            this.btnMakro = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.macro = new System.Windows.Forms.Label();
            this.historyBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnqueueAg = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMode = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openMacro = new System.Windows.Forms.OpenFileDialog();
            this.controlPanel.SuspendLayout();
            this.groupCommands.SuspendLayout();
            this.shortcutPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupRegs.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.AutoSize = true;
            this.btnA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnA.Location = new System.Drawing.Point(4, 4);
            this.btnA.Margin = new System.Windows.Forms.Padding(0);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(45, 46);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.controlPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.controlPanel.ColumnCount = 2;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlPanel.Controls.Add(this.btnGo, 1, 3);
            this.controlPanel.Controls.Add(this.btnClr, 1, 2);
            this.controlPanel.Controls.Add(this.btnL, 2, 1);
            this.controlPanel.Controls.Add(this.btnH, 1, 0);
            this.controlPanel.Controls.Add(this.btnA, 0, 0);
            this.controlPanel.Controls.Add(this.btnC, 0, 2);
            this.controlPanel.Controls.Add(this.btnD, 0, 3);
            this.controlPanel.Controls.Add(this.btnB, 0, 1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(5, 5);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(2);
            this.controlPanel.RowCount = 4;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.controlPanel.Size = new System.Drawing.Size(100, 200);
            this.controlPanel.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.AutoSize = true;
            this.btnGo.BackColor = System.Drawing.Color.Coral;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGo.Location = new System.Drawing.Point(51, 148);
            this.btnGo.Margin = new System.Windows.Forms.Padding(0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(45, 48);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // btnClr
            // 
            this.btnClr.AutoSize = true;
            this.btnClr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClr.Location = new System.Drawing.Point(51, 100);
            this.btnClr.Margin = new System.Windows.Forms.Padding(0);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(45, 46);
            this.btnClr.TabIndex = 4;
            this.btnClr.Text = "Clr";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // btnL
            // 
            this.btnL.AutoSize = true;
            this.btnL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnL.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnL.Location = new System.Drawing.Point(51, 52);
            this.btnL.Margin = new System.Windows.Forms.Padding(0);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(45, 46);
            this.btnL.TabIndex = 3;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnHL_Click);
            // 
            // btnH
            // 
            this.btnH.AutoSize = true;
            this.btnH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnH.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnH.Location = new System.Drawing.Point(51, 4);
            this.btnH.Margin = new System.Windows.Forms.Padding(0);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(45, 46);
            this.btnH.TabIndex = 2;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnHL_Click);
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Location = new System.Drawing.Point(4, 100);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(45, 46);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnD
            // 
            this.btnD.AutoSize = true;
            this.btnD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnD.Location = new System.Drawing.Point(4, 148);
            this.btnD.Margin = new System.Windows.Forms.Padding(0);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(45, 48);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnB
            // 
            this.btnB.AutoSize = true;
            this.btnB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnB.Location = new System.Drawing.Point(4, 52);
            this.btnB.Margin = new System.Windows.Forms.Padding(0);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(45, 46);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnMov
            // 
            this.btnMov.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMov.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMov.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMov.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMov.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnMov.Location = new System.Drawing.Point(62, 15);
            this.btnMov.Margin = new System.Windows.Forms.Padding(0);
            this.btnMov.Name = "btnMov";
            this.btnMov.Size = new System.Drawing.Size(60, 21);
            this.btnMov.TabIndex = 3;
            this.btnMov.Text = "MOV";
            this.btnMov.UseVisualStyleBackColor = false;
            this.btnMov.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // groupCommands
            // 
            this.groupCommands.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupCommands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupCommands.Controls.Add(this.btnSub);
            this.groupCommands.Controls.Add(this.btnMov);
            this.groupCommands.Controls.Add(this.btnAdd);
            this.groupCommands.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupCommands.Location = new System.Drawing.Point(6, 3);
            this.groupCommands.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupCommands.Name = "groupCommands";
            this.groupCommands.Padding = new System.Windows.Forms.Padding(2);
            this.groupCommands.Size = new System.Drawing.Size(184, 38);
            this.groupCommands.TabIndex = 3;
            this.groupCommands.TabStop = false;
            this.groupCommands.Text = "Komendy";
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSub.Location = new System.Drawing.Point(122, 15);
            this.btnSub.Margin = new System.Windows.Forms.Padding(0);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(60, 21);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "SUB";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(2, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 21);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // inputBox
            // 
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Margin = new System.Windows.Forms.Padding(0);
            this.inputBox.MaxLength = 8;
            this.inputBox.Name = "inputBox";
            this.inputBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputBox.Size = new System.Drawing.Size(130, 38);
            this.inputBox.TabIndex = 4;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // shortcutPanel
            // 
            this.shortcutPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.shortcutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.shortcutPanel.ColumnCount = 2;
            this.shortcutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shortcutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shortcutPanel.Controls.Add(this.btnSh8, 1, 3);
            this.shortcutPanel.Controls.Add(this.btnSh7, 1, 2);
            this.shortcutPanel.Controls.Add(this.btnSh6, 2, 1);
            this.shortcutPanel.Controls.Add(this.btnSh5, 1, 0);
            this.shortcutPanel.Controls.Add(this.btnSh1, 0, 0);
            this.shortcutPanel.Controls.Add(this.btnSh2, 0, 1);
            this.shortcutPanel.Controls.Add(this.btnSh3, 0, 2);
            this.shortcutPanel.Controls.Add(this.btnSh4, 0, 3);
            this.shortcutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.shortcutPanel.Location = new System.Drawing.Point(525, 5);
            this.shortcutPanel.Name = "shortcutPanel";
            this.shortcutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.shortcutPanel.RowCount = 4;
            this.shortcutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shortcutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shortcutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shortcutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shortcutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.shortcutPanel.Size = new System.Drawing.Size(100, 200);
            this.shortcutPanel.TabIndex = 5;
            // 
            // btnSh8
            // 
            this.btnSh8.AutoSize = true;
            this.btnSh8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh8.Location = new System.Drawing.Point(51, 148);
            this.btnSh8.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh8.Name = "btnSh8";
            this.btnSh8.Size = new System.Drawing.Size(45, 48);
            this.btnSh8.TabIndex = 5;
            this.btnSh8.Text = "#8";
            this.btnSh8.UseVisualStyleBackColor = false;
            this.btnSh8.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnSh7
            // 
            this.btnSh7.AutoSize = true;
            this.btnSh7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh7.Location = new System.Drawing.Point(51, 100);
            this.btnSh7.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh7.Name = "btnSh7";
            this.btnSh7.Size = new System.Drawing.Size(45, 46);
            this.btnSh7.TabIndex = 4;
            this.btnSh7.Text = "#7";
            this.btnSh7.UseVisualStyleBackColor = false;
            this.btnSh7.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnSh6
            // 
            this.btnSh6.AutoSize = true;
            this.btnSh6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh6.Location = new System.Drawing.Point(51, 52);
            this.btnSh6.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh6.Name = "btnSh6";
            this.btnSh6.Size = new System.Drawing.Size(45, 46);
            this.btnSh6.TabIndex = 3;
            this.btnSh6.Text = "#6";
            this.btnSh6.UseVisualStyleBackColor = false;
            this.btnSh6.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnSh5
            // 
            this.btnSh5.AutoSize = true;
            this.btnSh5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh5.Location = new System.Drawing.Point(51, 4);
            this.btnSh5.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh5.Name = "btnSh5";
            this.btnSh5.Size = new System.Drawing.Size(45, 46);
            this.btnSh5.TabIndex = 2;
            this.btnSh5.Text = "#5";
            this.btnSh5.UseVisualStyleBackColor = false;
            this.btnSh5.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnSh1
            // 
            this.btnSh1.AutoSize = true;
            this.btnSh1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh1.Location = new System.Drawing.Point(4, 4);
            this.btnSh1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh1.Name = "btnSh1";
            this.btnSh1.Size = new System.Drawing.Size(45, 46);
            this.btnSh1.TabIndex = 0;
            this.btnSh1.Text = "#1";
            this.btnSh1.UseVisualStyleBackColor = false;
            this.btnSh1.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnSh2
            // 
            this.btnSh2.AutoSize = true;
            this.btnSh2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh2.Location = new System.Drawing.Point(4, 52);
            this.btnSh2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh2.Name = "btnSh2";
            this.btnSh2.Size = new System.Drawing.Size(45, 46);
            this.btnSh2.TabIndex = 1;
            this.btnSh2.Text = "#2";
            this.btnSh2.UseVisualStyleBackColor = false;
            this.btnSh2.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnSh3
            // 
            this.btnSh3.AutoSize = true;
            this.btnSh3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh3.Location = new System.Drawing.Point(4, 100);
            this.btnSh3.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh3.Name = "btnSh3";
            this.btnSh3.Size = new System.Drawing.Size(45, 46);
            this.btnSh3.TabIndex = 1;
            this.btnSh3.Text = "#3";
            this.btnSh3.UseVisualStyleBackColor = false;
            this.btnSh3.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnSh4
            // 
            this.btnSh4.AutoSize = true;
            this.btnSh4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSh4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSh4.Location = new System.Drawing.Point(4, 148);
            this.btnSh4.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh4.Name = "btnSh4";
            this.btnSh4.Size = new System.Drawing.Size(45, 48);
            this.btnSh4.TabIndex = 1;
            this.btnSh4.Text = "#4";
            this.btnSh4.UseVisualStyleBackColor = false;
            this.btnSh4.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // resulltBox
            // 
            this.resulltBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resulltBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.resulltBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulltBox.Location = new System.Drawing.Point(361, 3);
            this.resulltBox.Margin = new System.Windows.Forms.Padding(0);
            this.resulltBox.Multiline = true;
            this.resulltBox.Name = "resulltBox";
            this.resulltBox.ReadOnly = true;
            this.resulltBox.Size = new System.Drawing.Size(266, 38);
            this.resulltBox.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirm.Location = new System.Drawing.Point(130, 0);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(38, 38);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "➤";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.groupRegs);
            this.panelTop.Controls.Add(this.shortcutPanel);
            this.panelTop.Controls.Add(this.controlPanel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(5, 29);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop.Size = new System.Drawing.Size(630, 210);
            this.panelTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentQueue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(376, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.groupBox1.Size = new System.Drawing.Size(149, 205);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktualna kolejka";
            // 
            // currentQueue
            // 
            this.currentQueue.BackColor = System.Drawing.SystemColors.Window;
            this.currentQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentQueue.Location = new System.Drawing.Point(3, 16);
            this.currentQueue.Multiline = true;
            this.currentQueue.Name = "currentQueue";
            this.currentQueue.ReadOnly = true;
            this.currentQueue.Size = new System.Drawing.Size(143, 181);
            this.currentQueue.TabIndex = 0;
            // 
            // groupRegs
            // 
            this.groupRegs.Controls.Add(this.valuesRegs);
            this.groupRegs.Controls.Add(this.textBox2);
            this.groupRegs.Controls.Add(this.tableLayoutPanel2);
            this.groupRegs.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupRegs.Location = new System.Drawing.Point(105, 5);
            this.groupRegs.Name = "groupRegs";
            this.groupRegs.Size = new System.Drawing.Size(271, 200);
            this.groupRegs.TabIndex = 12;
            this.groupRegs.TabStop = false;
            this.groupRegs.Text = "Stan rejestrów:";
            // 
            // valuesRegs
            // 
            this.valuesRegs.BackColor = System.Drawing.SystemColors.Window;
            this.valuesRegs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuesRegs.Dock = System.Windows.Forms.DockStyle.Right;
            this.valuesRegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesRegs.HideSelection = false;
            this.valuesRegs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.valuesRegs.Location = new System.Drawing.Point(53, 16);
            this.valuesRegs.Multiline = true;
            this.valuesRegs.Name = "valuesRegs";
            this.valuesRegs.ReadOnly = true;
            this.valuesRegs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.valuesRegs.Size = new System.Drawing.Size(215, 120);
            this.valuesRegs.TabIndex = 11;
            this.valuesRegs.Text = "0000000000000000\r\n0000000000000000\r\n0000000000000000\r\n0000000000000000";
            this.valuesRegs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valuesRegs.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.HideSelection = false;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2.Location = new System.Drawing.Point(3, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(50, 120);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "AX:\r\nBX:\r\nCX:\r\nDX:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.WordWrap = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.labelDX, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelAX, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCX, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBX, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 61);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // labelDX
            // 
            this.labelDX.AutoSize = true;
            this.labelDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDX.Location = new System.Drawing.Point(202, 1);
            this.labelDX.Name = "labelDX";
            this.labelDX.Size = new System.Drawing.Size(59, 29);
            this.labelDX.TabIndex = 14;
            this.labelDX.Text = "DX";
            this.labelDX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAX
            // 
            this.labelAX.AutoSize = true;
            this.labelAX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAX.Location = new System.Drawing.Point(4, 1);
            this.labelAX.Name = "labelAX";
            this.labelAX.Size = new System.Drawing.Size(59, 29);
            this.labelAX.TabIndex = 14;
            this.labelAX.Text = "AX";
            this.labelAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCX
            // 
            this.labelCX.AutoSize = true;
            this.labelCX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCX.Location = new System.Drawing.Point(136, 1);
            this.labelCX.Name = "labelCX";
            this.labelCX.Size = new System.Drawing.Size(59, 29);
            this.labelCX.TabIndex = 14;
            this.labelCX.Text = "CX";
            this.labelCX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBX
            // 
            this.labelBX.AutoSize = true;
            this.labelBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBX.Location = new System.Drawing.Point(70, 1);
            this.labelBX.Name = "labelBX";
            this.labelBX.Size = new System.Drawing.Size(59, 29);
            this.labelBX.TabIndex = 14;
            this.labelBX.Text = "BX";
            this.labelBX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMiddle
            // 
            this.panelMiddle.ColumnCount = 3;
            this.panelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMiddle.Controls.Add(this.resulltBox, 2, 0);
            this.panelMiddle.Controls.Add(this.groupCommands, 0, 0);
            this.panelMiddle.Controls.Add(this.panel2, 1, 0);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMiddle.Location = new System.Drawing.Point(5, 239);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Padding = new System.Windows.Forms.Padding(3);
            this.panelMiddle.RowCount = 1;
            this.panelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMiddle.Size = new System.Drawing.Size(630, 44);
            this.panelMiddle.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.inputBox);
            this.panel2.Location = new System.Drawing.Point(193, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 38);
            this.panel2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnQueueClr, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMakro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEnqueue, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(530, 289);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 150);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnQueueClr
            // 
            this.btnQueueClr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQueueClr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQueueClr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQueueClr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQueueClr.Location = new System.Drawing.Point(4, 112);
            this.btnQueueClr.Margin = new System.Windows.Forms.Padding(1);
            this.btnQueueClr.Name = "btnQueueClr";
            this.btnQueueClr.Size = new System.Drawing.Size(92, 34);
            this.btnQueueClr.TabIndex = 14;
            this.btnQueueClr.Text = "Wyczyść kolejkę";
            this.btnQueueClr.UseVisualStyleBackColor = false;
            this.btnQueueClr.Click += new System.EventHandler(this.btnQueueClr_Click);
            // 
            // btnMakro
            // 
            this.btnMakro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMakro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMakro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMakro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakro.Location = new System.Drawing.Point(4, 40);
            this.btnMakro.Margin = new System.Windows.Forms.Padding(1);
            this.btnMakro.Name = "btnMakro";
            this.btnMakro.Size = new System.Drawing.Size(92, 31);
            this.btnMakro.TabIndex = 12;
            this.btnMakro.Text = "Makro";
            this.btnMakro.UseVisualStyleBackColor = false;
            this.btnMakro.Click += new System.EventHandler(this.btnMakro_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnqueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnqueue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnqueue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnqueue.Location = new System.Drawing.Point(4, 4);
            this.btnEnqueue.Margin = new System.Windows.Forms.Padding(1);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(92, 31);
            this.btnEnqueue.TabIndex = 12;
            this.btnEnqueue.Text = "Zakolejkuj";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // macro
            // 
            this.macro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.macro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.macro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macro.Location = new System.Drawing.Point(113, 293);
            this.macro.Name = "macro";
            this.macro.Size = new System.Drawing.Size(411, 31);
            this.macro.TabIndex = 13;
            this.macro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyBox
            // 
            this.historyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.historyBox.FormattingEnabled = true;
            this.historyBox.Location = new System.Drawing.Point(324, 365);
            this.historyBox.MaxDropDownItems = 16;
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(200, 21);
            this.historyBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Historia komend";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnqueueAg
            // 
            this.btnEnqueueAg.Location = new System.Drawing.Point(324, 401);
            this.btnEnqueueAg.Name = "btnEnqueueAg";
            this.btnEnqueueAg.Size = new System.Drawing.Size(92, 34);
            this.btnEnqueueAg.TabIndex = 16;
            this.btnEnqueueAg.Text = "Zakolejkuj ponownie";
            this.btnEnqueueAg.UseVisualStyleBackColor = true;
            this.btnEnqueueAg.Click += new System.EventHandler(this.btnEnqueueAg_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShortcut});
            this.menuStrip.Location = new System.Drawing.Point(5, 5);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(630, 24);
            this.menuStrip.TabIndex = 10;
            // 
            // addShortcut
            // 
            this.addShortcut.Name = "addShortcut";
            this.addShortcut.Size = new System.Drawing.Size(79, 20);
            this.addShortcut.Text = "Dodaj skrót";
            this.addShortcut.Click += new System.EventHandler(this.addShortcut_Click);
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMode.Location = new System.Drawing.Point(4, 76);
            this.btnMode.Margin = new System.Windows.Forms.Padding(1);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(53, 31);
            this.btnMode.TabIndex = 13;
            this.btnMode.Text = "Tryb";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openMacro
            // 
            this.openMacro.FileName = "openFileDialog1";
            this.openMacro.RestoreDirectory = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btnEnqueueAg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.macro);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "CPU Sim";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.groupCommands.ResumeLayout(false);
            this.shortcutPanel.ResumeLayout(false);
            this.shortcutPanel.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupRegs.ResumeLayout(false);
            this.groupRegs.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnMov;
        private System.Windows.Forms.GroupBox groupCommands;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TableLayoutPanel shortcutPanel;
        private System.Windows.Forms.Button btnSh8;
        private System.Windows.Forms.Button btnSh7;
        private System.Windows.Forms.Button btnSh6;
        private System.Windows.Forms.Button btnSh5;
        private System.Windows.Forms.Button btnSh1;
        private System.Windows.Forms.Button btnSh2;
        private System.Windows.Forms.Button btnSh3;
        private System.Windows.Forms.Button btnSh4;
        private System.Windows.Forms.TextBox resulltBox;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel panelMiddle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox valuesRegs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMakro;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupRegs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelDX;
        private System.Windows.Forms.Label labelAX;
        private System.Windows.Forms.Label labelCX;
        private System.Windows.Forms.Label labelBX;
        private System.Windows.Forms.TextBox currentQueue;
        private System.Windows.Forms.Label macro;
        private System.Windows.Forms.Button btnQueueClr;
        private System.Windows.Forms.ComboBox historyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnqueueAg;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addShortcut;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openMacro;
    }
}

