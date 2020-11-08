namespace Cryptography_Exercises
{
    partial class CryptoTest
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
            this.groupBoxMethods = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonMatrixSub = new System.Windows.Forms.RadioButton();
            this.radioButtonPolySub = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectSubs = new System.Windows.Forms.RadioButton();
            this.radioButtonCaesar = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxKey = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRandomKey = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.groupBoxSet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAction = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxMethods.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxKey.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBoxOperation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxSet.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMethods
            // 
            this.groupBoxMethods.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMethods.Location = new System.Drawing.Point(2, 2);
            this.groupBoxMethods.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMethods.Name = "groupBoxMethods";
            this.groupBoxMethods.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMethods.Size = new System.Drawing.Size(589, 66);
            this.groupBoxMethods.TabIndex = 0;
            this.groupBoxMethods.TabStop = false;
            this.groupBoxMethods.Text = "Метод за шифроване";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMatrixSub, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonPolySub, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonDirectSubs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCaesar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonMatrixSub
            // 
            this.radioButtonMatrixSub.AutoSize = true;
            this.radioButtonMatrixSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMatrixSub.Location = new System.Drawing.Point(440, 2);
            this.radioButtonMatrixSub.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMatrixSub.Name = "radioButtonMatrixSub";
            this.radioButtonMatrixSub.Size = new System.Drawing.Size(143, 42);
            this.radioButtonMatrixSub.TabIndex = 3;
            this.radioButtonMatrixSub.Text = "Матрично заместване";
            this.radioButtonMatrixSub.UseVisualStyleBackColor = true;
            this.radioButtonMatrixSub.CheckedChanged += new System.EventHandler(this.radioButtonMatrixSub_CheckedChanged);
            // 
            // radioButtonPolySub
            // 
            this.radioButtonPolySub.AutoSize = true;
            this.radioButtonPolySub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPolySub.Location = new System.Drawing.Point(294, 2);
            this.radioButtonPolySub.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPolySub.Name = "radioButtonPolySub";
            this.radioButtonPolySub.Size = new System.Drawing.Size(142, 42);
            this.radioButtonPolySub.TabIndex = 2;
            this.radioButtonPolySub.Text = "Многоазбучно заместване";
            this.radioButtonPolySub.UseVisualStyleBackColor = true;
            this.radioButtonPolySub.CheckedChanged += new System.EventHandler(this.radioButtonPolySub_CheckedChanged);
            // 
            // radioButtonDirectSubs
            // 
            this.radioButtonDirectSubs.AutoSize = true;
            this.radioButtonDirectSubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonDirectSubs.Location = new System.Drawing.Point(148, 2);
            this.radioButtonDirectSubs.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDirectSubs.Name = "radioButtonDirectSubs";
            this.radioButtonDirectSubs.Size = new System.Drawing.Size(142, 42);
            this.radioButtonDirectSubs.TabIndex = 1;
            this.radioButtonDirectSubs.Text = "Директно заместване";
            this.radioButtonDirectSubs.UseVisualStyleBackColor = true;
            this.radioButtonDirectSubs.CheckedChanged += new System.EventHandler(this.radioButtonDirectSubs_CheckedChanged);
            // 
            // radioButtonCaesar
            // 
            this.radioButtonCaesar.AutoSize = true;
            this.radioButtonCaesar.Checked = true;
            this.radioButtonCaesar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCaesar.Location = new System.Drawing.Point(2, 2);
            this.radioButtonCaesar.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCaesar.Name = "radioButtonCaesar";
            this.radioButtonCaesar.Size = new System.Drawing.Size(142, 42);
            this.radioButtonCaesar.TabIndex = 0;
            this.radioButtonCaesar.TabStop = true;
            this.radioButtonCaesar.Text = "Шифър\r\nна Цезар";
            this.radioButtonCaesar.UseVisualStyleBackColor = true;
            this.radioButtonCaesar.CheckedChanged += new System.EventHandler(this.radioButtonCaesar_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxMethods);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxSet);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxInput);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxResult);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.groupBoxKey, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBoxOperation, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 72);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(598, 59);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // groupBoxKey
            // 
            this.groupBoxKey.Controls.Add(this.tableLayoutPanel7);
            this.groupBoxKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKey.Enabled = false;
            this.groupBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxKey.Location = new System.Drawing.Point(301, 2);
            this.groupBoxKey.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxKey.Name = "groupBoxKey";
            this.groupBoxKey.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxKey.Size = new System.Drawing.Size(295, 55);
            this.groupBoxKey.TabIndex = 2;
            this.groupBoxKey.TabStop = false;
            this.groupBoxKey.Text = "Ключ";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.btnRandomKey, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxKey, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(291, 35);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // btnRandomKey
            // 
            this.btnRandomKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRandomKey.Location = new System.Drawing.Point(162, 3);
            this.btnRandomKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandomKey.Name = "btnRandomKey";
            this.btnRandomKey.Size = new System.Drawing.Size(112, 29);
            this.btnRandomKey.TabIndex = 3;
            this.btnRandomKey.Text = "Случаен ключ";
            this.btnRandomKey.UseVisualStyleBackColor = true;
            this.btnRandomKey.Click += new System.EventHandler(this.btnRandomKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKey.Location = new System.Drawing.Point(2, 6);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(141, 23);
            this.textBoxKey.TabIndex = 2;
            this.textBoxKey.Enter += new System.EventHandler(this.textBoxKey_Enter);
            this.textBoxKey.Leave += new System.EventHandler(this.textBoxKey_Leave);
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOperation.Location = new System.Drawing.Point(2, 2);
            this.groupBoxOperation.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOperation.Size = new System.Drawing.Size(294, 54);
            this.groupBoxOperation.TabIndex = 1;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Тип операция";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonDecrypt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonEncrypt, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonDecrypt.Location = new System.Drawing.Point(147, 2);
            this.radioButtonDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(141, 30);
            this.radioButtonDecrypt.TabIndex = 1;
            this.radioButtonDecrypt.Text = "Декриптиране";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            this.radioButtonDecrypt.CheckedChanged += new System.EventHandler(this.radioButtonDecrypt_CheckedChanged);
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.Checked = true;
            this.radioButtonEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonEncrypt.Location = new System.Drawing.Point(2, 2);
            this.radioButtonEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(141, 30);
            this.radioButtonEncrypt.TabIndex = 0;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Криптиране";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            this.radioButtonEncrypt.CheckedChanged += new System.EventHandler(this.radioButtonEncrypt_CheckedChanged);
            // 
            // groupBoxSet
            // 
            this.groupBoxSet.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSet.Location = new System.Drawing.Point(2, 135);
            this.groupBoxSet.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSet.Name = "groupBoxSet";
            this.groupBoxSet.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSet.Size = new System.Drawing.Size(589, 66);
            this.groupBoxSet.TabIndex = 2;
            this.groupBoxSet.TabStop = false;
            this.groupBoxSet.Text = "Множество от разрешени символи";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxM, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(585, 46);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Location = new System.Drawing.Point(445, 6);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 34);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Ресет";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBoxM
            // 
            this.textBoxM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxM, 3);
            this.textBoxM.Location = new System.Drawing.Point(13, 11);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(412, 23);
            this.textBoxM.TabIndex = 1;
            this.textBoxM.Enter += new System.EventHandler(this.textBoxM_Enter);
            this.textBoxM.Validated += new System.EventHandler(this.textBoxM_Validated);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput.Location = new System.Drawing.Point(2, 205);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput.Size = new System.Drawing.Size(589, 66);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Явен текст";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnAction, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxInput, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(585, 46);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAction.Location = new System.Drawing.Point(445, 6);
            this.btnAction.Margin = new System.Windows.Forms.Padding(2);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(132, 34);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "КРИПТИРАЙ";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.SetColumnSpan(this.textBoxInput, 3);
            this.textBoxInput.Location = new System.Drawing.Point(13, 11);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(412, 23);
            this.textBoxInput.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult.Location = new System.Drawing.Point(2, 275);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Size = new System.Drawing.Size(589, 66);
            this.groupBoxResult.TabIndex = 4;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Резултат";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.btnExit, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxResult, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(585, 46);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(445, 6);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.SetColumnSpan(this.textBoxResult, 3);
            this.textBoxResult.Location = new System.Drawing.Point(13, 11);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(412, 23);
            this.textBoxResult.TabIndex = 1;
            // 
            // CryptoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CryptoTest";
            this.Text = "CryptoTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CryptoTest_FormClosing);
            this.Load += new System.EventHandler(this.AppGUIForm_Load);
            this.groupBoxMethods.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBoxKey.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBoxOperation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxSet.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMethods;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonMatrixSub;
        private System.Windows.Forms.RadioButton radioButtonPolySub;
        private System.Windows.Forms.RadioButton radioButtonDirectSubs;
        private System.Windows.Forms.RadioButton radioButtonCaesar;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonDecrypt;
        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.GroupBox groupBoxSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBoxKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button btnRandomKey;
    }
}