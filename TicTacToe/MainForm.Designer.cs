namespace TicTacToe
{
    partial class MainForm
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.btnChooseO = new System.Windows.Forms.Button();
            this.btnChooseX = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.groupBoxOpponent = new System.Windows.Forms.GroupBox();
            this.comboBoxOpponent = new System.Windows.Forms.ComboBox();
            this.labelTurn = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.groupBoxChoose.SuspendLayout();
            this.groupBoxDifficulty.SuspendLayout();
            this.groupBoxOpponent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelGame.Controls.Add(this.panelMenu);
            this.panelGame.Controls.Add(this.labelTurn);
            this.panelGame.Controls.Add(this.btnBack);
            this.panelGame.Controls.Add(this.panel1);
            this.panelGame.Controls.Add(this.btnRefresh);
            this.panelGame.Location = new System.Drawing.Point(-4, -1);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(637, 604);
            this.panelGame.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.groupBoxChoose);
            this.panelMenu.Controls.Add(this.btnConfirm);
            this.panelMenu.Controls.Add(this.groupBoxDifficulty);
            this.panelMenu.Controls.Add(this.groupBoxOpponent);
            this.panelMenu.Location = new System.Drawing.Point(9, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(628, 604);
            this.panelMenu.TabIndex = 4;
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.Controls.Add(this.btnChooseO);
            this.groupBoxChoose.Controls.Add(this.btnChooseX);
            this.groupBoxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChoose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxChoose.Location = new System.Drawing.Point(10, 243);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Size = new System.Drawing.Size(608, 171);
            this.groupBoxChoose.TabIndex = 4;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Choose";
            // 
            // btnChooseO
            // 
            this.btnChooseO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChooseO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseO.Location = new System.Drawing.Point(317, 39);
            this.btnChooseO.Name = "btnChooseO";
            this.btnChooseO.Size = new System.Drawing.Size(283, 121);
            this.btnChooseO.TabIndex = 1;
            this.btnChooseO.TabStop = false;
            this.btnChooseO.Text = "O";
            this.btnChooseO.UseVisualStyleBackColor = false;
            // 
            // btnChooseX
            // 
            this.btnChooseX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChooseX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseX.Location = new System.Drawing.Point(6, 39);
            this.btnChooseX.Name = "btnChooseX";
            this.btnChooseX.Size = new System.Drawing.Size(285, 121);
            this.btnChooseX.TabIndex = 0;
            this.btnChooseX.TabStop = false;
            this.btnChooseX.Text = "X";
            this.btnChooseX.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(10, 433);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(608, 154);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.comboBoxDifficulty);
            this.groupBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDifficulty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxDifficulty.Location = new System.Drawing.Point(327, 22);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(289, 215);
            this.groupBoxDifficulty.TabIndex = 2;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Difficulty";
            this.groupBoxDifficulty.Visible = false;
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(6, 37);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(277, 39);
            this.comboBoxDifficulty.TabIndex = 1;
            this.comboBoxDifficulty.TabStop = false;
            // 
            // groupBoxOpponent
            // 
            this.groupBoxOpponent.Controls.Add(this.comboBoxOpponent);
            this.groupBoxOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOpponent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxOpponent.Location = new System.Drawing.Point(10, 22);
            this.groupBoxOpponent.Name = "groupBoxOpponent";
            this.groupBoxOpponent.Size = new System.Drawing.Size(291, 215);
            this.groupBoxOpponent.TabIndex = 0;
            this.groupBoxOpponent.TabStop = false;
            this.groupBoxOpponent.Text = "Opponent";
            // 
            // comboBoxOpponent
            // 
            this.comboBoxOpponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOpponent.FormattingEnabled = true;
            this.comboBoxOpponent.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxOpponent.Location = new System.Drawing.Point(6, 37);
            this.comboBoxOpponent.Name = "comboBoxOpponent";
            this.comboBoxOpponent.Size = new System.Drawing.Size(279, 39);
            this.comboBoxOpponent.TabIndex = 2;
            this.comboBoxOpponent.TabStop = false;
            // 
            // labelTurn
            // 
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTurn.Location = new System.Drawing.Point(153, 10);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(331, 73);
            this.labelTurn.TabIndex = 5;
            this.labelTurn.Text = "X moves";
            this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(16, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 60);
            this.btnBack.TabIndex = 11;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btn00);
            this.panel1.Controls.Add(this.btn01);
            this.panel1.Controls.Add(this.btn22);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn21);
            this.panel1.Controls.Add(this.btn20);
            this.panel1.Controls.Add(this.btn02);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Location = new System.Drawing.Point(60, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 499);
            this.panel1.TabIndex = 9;
            // 
            // btn00
            // 
            this.btn00.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn00.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn00.Location = new System.Drawing.Point(3, 2);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(150, 150);
            this.btn00.TabIndex = 0;
            this.btn00.TabStop = false;
            this.btn00.UseVisualStyleBackColor = false;
            // 
            // btn01
            // 
            this.btn01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn01.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn01.Location = new System.Drawing.Point(181, 0);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(150, 150);
            this.btn01.TabIndex = 1;
            this.btn01.TabStop = false;
            this.btn01.UseVisualStyleBackColor = false;
            // 
            // btn22
            // 
            this.btn22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn22.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn22.Location = new System.Drawing.Point(359, 350);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(150, 150);
            this.btn22.TabIndex = 8;
            this.btn22.TabStop = false;
            this.btn22.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn10.Location = new System.Drawing.Point(3, 173);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(150, 150);
            this.btn10.TabIndex = 3;
            this.btn10.TabStop = false;
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn12.Location = new System.Drawing.Point(359, 173);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(150, 150);
            this.btn12.TabIndex = 5;
            this.btn12.TabStop = false;
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn21
            // 
            this.btn21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn21.Location = new System.Drawing.Point(181, 349);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(150, 150);
            this.btn21.TabIndex = 7;
            this.btn21.TabStop = false;
            this.btn21.UseVisualStyleBackColor = false;
            // 
            // btn20
            // 
            this.btn20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn20.Location = new System.Drawing.Point(3, 349);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(150, 150);
            this.btn20.TabIndex = 6;
            this.btn20.TabStop = false;
            this.btn20.UseVisualStyleBackColor = false;
            // 
            // btn02
            // 
            this.btn02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn02.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn02.Location = new System.Drawing.Point(359, 3);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(150, 150);
            this.btn02.TabIndex = 2;
            this.btn02.TabStop = false;
            this.btn02.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn11.Location = new System.Drawing.Point(181, 173);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(150, 150);
            this.btn11.TabIndex = 4;
            this.btn11.TabStop = false;
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(500, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 60);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 601);
            this.Controls.Add(this.panelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "TicTacToe";
            this.panelGame.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxOpponent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.GroupBox groupBoxOpponent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxOpponent;
        private System.Windows.Forms.Button btnChooseO;
        private System.Windows.Forms.Button btnChooseX;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Button btnRefresh;
    }
}

