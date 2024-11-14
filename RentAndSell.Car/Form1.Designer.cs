using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RentAndSell.Car
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            cBoxYil = new ComboBox();
            btnSave = new Button();
            cBoxSanzimanTipi = new ComboBox();
            cBoxMotorTipi = new ComboBox();
            cBoxYakitTuru = new ComboBox();
            txtModel = new TextBox();
            txtMarka = new TextBox();
            nbrUpDownYil = new NumericUpDown();
            txtYili = new TextBox();
            dgvArabaList = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motorTipiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yakitTuruDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sanzimanTipiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yiliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            arabaViewModelBindingSource = new BindingSource(components);
            txtCarId = new TextBox();
            btnRead = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrUpDownYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArabaList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arabaViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRead);
            groupBox1.Controls.Add(txtCarId);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(cBoxYil);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cBoxSanzimanTipi);
            groupBox1.Controls.Add(cBoxMotorTipi);
            groupBox1.Controls.Add(cBoxYakitTuru);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMarka);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(321, 612);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "YENİ KAYIT";
            // 
            // txtId
            // 
            txtId.Location = new Point(23, 333);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Record ID";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 11;
            txtId.Visible = false;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(220, 295);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(95, 31);
            btnSil.TabIndex = 10;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(115, 295);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(99, 31);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // cBoxYil
            // 
            cBoxYil.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxYil.FormattingEnabled = true;
            cBoxYil.Location = new Point(23, 112);
            cBoxYil.Margin = new Padding(3, 4, 3, 4);
            cBoxYil.Name = "cBoxYil";
            cBoxYil.Size = new Size(270, 28);
            cBoxYil.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(23, 295);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cBoxSanzimanTipi
            // 
            cBoxSanzimanTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxSanzimanTipi.FormattingEnabled = true;
            cBoxSanzimanTipi.Location = new Point(24, 236);
            cBoxSanzimanTipi.Margin = new Padding(3, 4, 3, 4);
            cBoxSanzimanTipi.Name = "cBoxSanzimanTipi";
            cBoxSanzimanTipi.Size = new Size(270, 28);
            cBoxSanzimanTipi.TabIndex = 5;
            // 
            // cBoxMotorTipi
            // 
            cBoxMotorTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxMotorTipi.FormattingEnabled = true;
            cBoxMotorTipi.Location = new Point(24, 195);
            cBoxMotorTipi.Margin = new Padding(3, 4, 3, 4);
            cBoxMotorTipi.Name = "cBoxMotorTipi";
            cBoxMotorTipi.Size = new Size(270, 28);
            cBoxMotorTipi.TabIndex = 4;
            // 
            // cBoxYakitTuru
            // 
            cBoxYakitTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxYakitTuru.FormattingEnabled = true;
            cBoxYakitTuru.Location = new Point(23, 153);
            cBoxYakitTuru.Margin = new Padding(3, 4, 3, 4);
            cBoxYakitTuru.Name = "cBoxYakitTuru";
            cBoxYakitTuru.Size = new Size(270, 28);
            cBoxYakitTuru.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(23, 71);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "Model";
            txtModel.Size = new Size(270, 27);
            txtModel.TabIndex = 1;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(23, 29);
            txtMarka.Margin = new Padding(3, 4, 3, 4);
            txtMarka.Name = "txtMarka";
            txtMarka.PlaceholderText = "Marka";
            txtMarka.Size = new Size(270, 27);
            txtMarka.TabIndex = 0;
            // 
            // nbrUpDownYil
            // 
            nbrUpDownYil.Location = new Point(14, 695);
            nbrUpDownYil.Margin = new Padding(3, 4, 3, 4);
            nbrUpDownYil.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nbrUpDownYil.Minimum = new decimal(new int[] { 1940, 0, 0, 0 });
            nbrUpDownYil.Name = "nbrUpDownYil";
            nbrUpDownYil.Size = new Size(137, 27);
            nbrUpDownYil.TabIndex = 7;
            nbrUpDownYil.Value = new decimal(new int[] { 1940, 0, 0, 0 });
            nbrUpDownYil.Visible = false;
            // 
            // txtYili
            // 
            txtYili.Location = new Point(14, 656);
            txtYili.Margin = new Padding(3, 4, 3, 4);
            txtYili.Name = "txtYili";
            txtYili.PlaceholderText = "Yıl";
            txtYili.Size = new Size(138, 27);
            txtYili.TabIndex = 2;
            txtYili.Visible = false;
            // 
            // dgvArabaList
            // 
            dgvArabaList.AutoGenerateColumns = false;
            dgvArabaList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArabaList.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, markaDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, motorTipiDataGridViewTextBoxColumn, yakitTuruDataGridViewTextBoxColumn, sanzimanTipiDataGridViewTextBoxColumn, yiliDataGridViewTextBoxColumn });
            dgvArabaList.DataSource = arabaViewModelBindingSource;
            dgvArabaList.Location = new Point(341, 29);
            dgvArabaList.Margin = new Padding(3, 4, 3, 4);
            dgvArabaList.MultiSelect = false;
            dgvArabaList.Name = "dgvArabaList";
            dgvArabaList.RowHeadersWidth = 51;
            dgvArabaList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArabaList.Size = new Size(838, 599);
            dgvArabaList.TabIndex = 1;
            dgvArabaList.CellDoubleClick += dgvArabaList_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 51;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // motorTipiDataGridViewTextBoxColumn
            // 
            motorTipiDataGridViewTextBoxColumn.DataPropertyName = "MotorTipi";
            motorTipiDataGridViewTextBoxColumn.HeaderText = "MotorTipi";
            motorTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            motorTipiDataGridViewTextBoxColumn.Name = "motorTipiDataGridViewTextBoxColumn";
            motorTipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitTuruDataGridViewTextBoxColumn
            // 
            yakitTuruDataGridViewTextBoxColumn.DataPropertyName = "YakitTuru";
            yakitTuruDataGridViewTextBoxColumn.HeaderText = "YakitTuru";
            yakitTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            yakitTuruDataGridViewTextBoxColumn.Name = "yakitTuruDataGridViewTextBoxColumn";
            yakitTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // sanzimanTipiDataGridViewTextBoxColumn
            // 
            sanzimanTipiDataGridViewTextBoxColumn.DataPropertyName = "SanzimanTipi";
            sanzimanTipiDataGridViewTextBoxColumn.HeaderText = "SanzimanTipi";
            sanzimanTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            sanzimanTipiDataGridViewTextBoxColumn.Name = "sanzimanTipiDataGridViewTextBoxColumn";
            sanzimanTipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yiliDataGridViewTextBoxColumn
            // 
            yiliDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            yiliDataGridViewTextBoxColumn.DataPropertyName = "Yili";
            yiliDataGridViewTextBoxColumn.HeaderText = "Yili";
            yiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            yiliDataGridViewTextBoxColumn.Name = "yiliDataGridViewTextBoxColumn";
            yiliDataGridViewTextBoxColumn.Width = 58;
            // 
            // arabaViewModelBindingSource
            // 
            arabaViewModelBindingSource.DataSource = typeof(Models.ArabaViewModel);
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(23, 367);
            txtCarId.Name = "txtCarId";
            txtCarId.PlaceholderText = "Car ID";
            txtCarId.Size = new Size(114, 27);
            txtCarId.TabIndex = 12;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(156, 367);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 13;
            btnRead.Text = "OKU";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 740);
            Controls.Add(dgvArabaList);
            Controls.Add(nbrUpDownYil);
            Controls.Add(groupBox1);
            Controls.Add(txtYili);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbrUpDownYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArabaList).EndInit();
            ((System.ComponentModel.ISupportInitialize)arabaViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
            private DataGridView dgvArabaList;
            private ComboBox cBoxSanzimanTipi;
            private ComboBox cBoxMotorTipi;
            private ComboBox cBoxYakitTuru;
            private TextBox txtYili;
            private TextBox txtModel;
            private TextBox txtMarka;
            private Button btnSave;
            private NumericUpDown nbrUpDownYil;
            private ComboBox cBoxYil;
            private Button btnSil;
            private Button btnGuncelle;
            private BindingSource arabaViewModelBindingSource;
            private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
            private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
            private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
            private DataGridViewTextBoxColumn motorTipiDataGridViewTextBoxColumn;
            private DataGridViewTextBoxColumn yakitTuruDataGridViewTextBoxColumn;
            private DataGridViewTextBoxColumn sanzimanTipiDataGridViewTextBoxColumn;
            private DataGridViewTextBoxColumn yiliDataGridViewTextBoxColumn;
            private TextBox txtId;
        private TextBox txtCarId;
        private Button btnRead;
    }
    }