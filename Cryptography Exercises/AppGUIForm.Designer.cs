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
            this.groupBoxMethods.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMethods.Name = "groupBoxMethods";
            this.groupBoxMethods.Size = new System.Drawing.Size(785, 81);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonMatrixSub
            // 
            this.radioButtonMatrixSub.AutoSize = true;
            this.radioButtonMatrixSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMatrixSub.Location = new System.Drawing.Point(585, 3);
            this.radioButtonMatrixSub.Name = "radioButtonMatrixSub";
            this.radioButtonMatrixSub.Size = new System.Drawing.Size(191, 49);
            this.radioButtonMatrixSub.TabIndex = 3;
            this.radioButtonMatrixSub.Text = "Матрично заместване";
            this.radioButtonMatrixSub.UseVisualStyleBackColor = true;
            this.radioButtonMatrixSub.CheckedChanged += new System.EventHandler(this.radioButtonMatrixSub_CheckedChanged);
            // 
            // radioButtonPolySub
            // 
            this.radioButtonPolySub.AutoSize = true;
            this.radioButtonPolySub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPolySub.Location = new System.Drawing.Point(391, 3);
            this.radioButtonPolySub.Name = "radioButtonPolySub";
            this.radioButtonPolySub.Size = new System.Drawing.Size(188, 49);
            this.radioButtonPolySub.TabIndex = 2;
            this.radioButtonPolySub.Text = "Многоазбучно заместване";
            this.radioButtonPolySub.UseVisualStyleBackColor = true;
            this.radioButtonPolySub.CheckedChanged += new System.EventHandler(this.radioButtonPolySub_CheckedChanged);
            // 
            // radioButtonDirectSubs
            // 
            this.radioButtonDirectSubs.AutoSize = true;
            this.radioButtonDirectSubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonDirectSubs.Location = new System.Drawing.Point(197, 3);
            this.radioButtonDirectSubs.Name = "radioButtonDirectSubs";
            this.radioButtonDirectSubs.Size = new System.Drawing.Size(188, 49);
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
            this.radioButtonCaesar.Location = new System.Drawing.Point(3, 3);
            this.radioButtonCaesar.Name = "radioButtonCaesar";
            this.radioButtonCaesar.Size = new System.Drawing.Size(188, 49);
            this.radioButtonCaesar.TabIndex = 0;
            this.radioButtonCaesar.TabStop = true;
            this.radioButtonCaesar.Text = "Шифър\r\nна Цезар";
            this.radioButtonCaesar.UseVisualStyleBackColor = true;
            this.radioButtonCaesar.CheckedChanged += new System.EventHandler(this.radioButtonCaesar_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxMethods);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxOperation);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxSet);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxInput);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxResult);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOperation.Location = new System.Drawing.Point(3, 90);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(785, 81);
            this.groupBoxOperation.TabIndex = 1;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Тип операция";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonDecrypt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonEncrypt, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(779, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonDecrypt.Location = new System.Drawing.Point(197, 3);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(188, 49);
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
            this.radioButtonEncrypt.Location = new System.Drawing.Point(3, 3);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(188, 49);
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
            this.groupBoxSet.Location = new System.Drawing.Point(3, 177);
            this.groupBoxSet.Name = "groupBoxSet";
            this.groupBoxSet.Size = new System.Drawing.Size(785, 81);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(779, 55);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Location = new System.Drawing.Point(605, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 42);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Ресет";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBoxM
            // 
            this.textBoxM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxM, 3);
            this.textBoxM.Location = new System.Drawing.Point(31, 14);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(519, 27);
            this.textBoxM.TabIndex = 1;
            this.textBoxM.Leave += new System.EventHandler(this.textBoxM_Leave);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput.Location = new System.Drawing.Point(3, 264);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(785, 81);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(779, 55);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAction.Location = new System.Drawing.Point(605, 6);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(150, 42);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "КРИПТИРАЙ";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.SetColumnSpan(this.textBoxInput, 3);
            this.textBoxInput.Location = new System.Drawing.Point(31, 14);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(519, 27);
            this.textBoxInput.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult.Location = new System.Drawing.Point(3, 351);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(785, 81);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(779, 55);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(605, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.SetColumnSpan(this.textBoxResult, 3);
            this.textBoxResult.Location = new System.Drawing.Point(31, 14);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(519, 27);
            this.textBoxResult.TabIndex = 1;
            // 
            // CryptoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CryptoTest";
            this.Text = "CryptoTest";
            this.Load += new System.EventHandler(this.AppGUIForm_Load);
            this.groupBoxMethods.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
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
    }
}