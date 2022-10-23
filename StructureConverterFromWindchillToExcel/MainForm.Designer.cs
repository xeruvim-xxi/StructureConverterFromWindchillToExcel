namespace StructureConverterFromWindchillToExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathFileStructureWindchill = new System.Windows.Forms.TextBox();
            this.bDialogSelectPathFileStructureWindchill = new System.Windows.Forms.Button();
            this.oFDPathFile = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathFilePickingList = new System.Windows.Forms.TextBox();
            this.bDialogSelectPathFilePickingList = new System.Windows.Forms.Button();
            this.bConvert = new System.Windows.Forms.Button();
            this.lblEx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл структуры из Windchill (*.xlsx):";
            // 
            // txtPathFileStructureWindchill
            // 
            this.txtPathFileStructureWindchill.Location = new System.Drawing.Point(502, 211);
            this.txtPathFileStructureWindchill.Name = "txtPathFileStructureWindchill";
            this.txtPathFileStructureWindchill.ReadOnly = true;
            this.txtPathFileStructureWindchill.Size = new System.Drawing.Size(400, 20);
            this.txtPathFileStructureWindchill.TabIndex = 1;
            // 
            // bDialogSelectPathFileStructureWindchill
            // 
            this.bDialogSelectPathFileStructureWindchill.Location = new System.Drawing.Point(912, 209);
            this.bDialogSelectPathFileStructureWindchill.Name = "bDialogSelectPathFileStructureWindchill";
            this.bDialogSelectPathFileStructureWindchill.Size = new System.Drawing.Size(100, 24);
            this.bDialogSelectPathFileStructureWindchill.TabIndex = 2;
            this.bDialogSelectPathFileStructureWindchill.Text = "Выбрать...";
            this.bDialogSelectPathFileStructureWindchill.UseVisualStyleBackColor = true;
            this.bDialogSelectPathFileStructureWindchill.Click += new System.EventHandler(this.bDialogSelectPathFileStructureWindchill_Click);
            // 
            // oFDPathFile
            // 
            this.oFDPathFile.Filter = "Exel файлы|*.xlsx|*.xls|";
            this.oFDPathFile.Title = "Выбор файла структуры из Windchill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите файл комплектовочной ведомости (*.xlsx):";
            // 
            // txtPathFilePickingList
            // 
            this.txtPathFilePickingList.Location = new System.Drawing.Point(502, 271);
            this.txtPathFilePickingList.Name = "txtPathFilePickingList";
            this.txtPathFilePickingList.ReadOnly = true;
            this.txtPathFilePickingList.Size = new System.Drawing.Size(400, 20);
            this.txtPathFilePickingList.TabIndex = 4;
            // 
            // bDialogSelectPathFilePickingList
            // 
            this.bDialogSelectPathFilePickingList.Location = new System.Drawing.Point(912, 269);
            this.bDialogSelectPathFilePickingList.Name = "bDialogSelectPathFilePickingList";
            this.bDialogSelectPathFilePickingList.Size = new System.Drawing.Size(100, 24);
            this.bDialogSelectPathFilePickingList.TabIndex = 5;
            this.bDialogSelectPathFilePickingList.Text = "Выбрать...";
            this.bDialogSelectPathFilePickingList.UseVisualStyleBackColor = true;
            this.bDialogSelectPathFilePickingList.Click += new System.EventHandler(this.bDialogSelectPathFilePickingList_Click);
            // 
            // bConvert
            // 
            this.bConvert.Location = new System.Drawing.Point(692, 351);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(160, 40);
            this.bConvert.TabIndex = 6;
            this.bConvert.Text = "Конвертировать";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(502, 421);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(0, 13);
            this.lblEx.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 528);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.bDialogSelectPathFilePickingList);
            this.Controls.Add(this.txtPathFilePickingList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bDialogSelectPathFileStructureWindchill);
            this.Controls.Add(this.txtPathFileStructureWindchill);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Конвертер структуры из Windchill в Exel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathFileStructureWindchill;
        private System.Windows.Forms.Button bDialogSelectPathFileStructureWindchill;
        private System.Windows.Forms.OpenFileDialog oFDPathFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathFilePickingList;
        private System.Windows.Forms.Button bDialogSelectPathFilePickingList;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.Label lblEx;
    }
}

