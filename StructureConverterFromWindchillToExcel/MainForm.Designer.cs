namespace StructureConverterFromWindchillToExcel
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.TS1_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_CreateProject_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_OpenProject_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Quit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.TreeProduct = new System.Windows.Forms.TreeView();
            this.LV_Product = new System.Windows.Forms.ListView();
            this.CH_Section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Design = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS1_MenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1604, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // TS1_MenuItem
            // 
            this.TS1_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_CreateProject_MenuItem,
            this.TS_OpenProject_MenuItem,
            this.toolStripSeparator1,
            this.TS_Quit_MenuItem});
            this.TS1_MenuItem.Name = "TS1_MenuItem";
            this.TS1_MenuItem.Size = new System.Drawing.Size(63, 20);
            this.TS1_MenuItem.Text = "Главная";
            // 
            // TS_CreateProject_MenuItem
            // 
            this.TS_CreateProject_MenuItem.Name = "TS_CreateProject_MenuItem";
            this.TS_CreateProject_MenuItem.Size = new System.Drawing.Size(162, 22);
            this.TS_CreateProject_MenuItem.Text = "Создать проект";
            // 
            // TS_OpenProject_MenuItem
            // 
            this.TS_OpenProject_MenuItem.Name = "TS_OpenProject_MenuItem";
            this.TS_OpenProject_MenuItem.Size = new System.Drawing.Size(162, 22);
            this.TS_OpenProject_MenuItem.Text = "Открыть проект";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // TS_Quit_MenuItem
            // 
            this.TS_Quit_MenuItem.Name = "TS_Quit_MenuItem";
            this.TS_Quit_MenuItem.Size = new System.Drawing.Size(162, 22);
            this.TS_Quit_MenuItem.Text = "Выход";
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 24);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.TreeProduct);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.LV_Product);
            this.MainContainer.Size = new System.Drawing.Size(1604, 857);
            this.MainContainer.SplitterDistance = 304;
            this.MainContainer.TabIndex = 1;
            // 
            // TreeProduct
            // 
            this.TreeProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeProduct.Location = new System.Drawing.Point(0, 0);
            this.TreeProduct.Name = "TreeProduct";
            this.TreeProduct.Size = new System.Drawing.Size(304, 857);
            this.TreeProduct.TabIndex = 0;
            // 
            // LV_Product
            // 
            this.LV_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Section,
            this.CH_Position,
            this.CH_Design,
            this.CH_Name,
            this.CH_Quantity,
            this.CH_Note});
            this.LV_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Product.GridLines = true;
            this.LV_Product.HideSelection = false;
            this.LV_Product.Location = new System.Drawing.Point(0, 0);
            this.LV_Product.Name = "LV_Product";
            this.LV_Product.Size = new System.Drawing.Size(1296, 857);
            this.LV_Product.TabIndex = 0;
            this.LV_Product.UseCompatibleStateImageBehavior = false;
            this.LV_Product.View = System.Windows.Forms.View.Details;
            // 
            // CH_Section
            // 
            this.CH_Section.Text = "Раздел";
            this.CH_Section.Width = 130;
            // 
            // CH_Position
            // 
            this.CH_Position.Text = "Поз.";
            this.CH_Position.Width = 67;
            // 
            // CH_Design
            // 
            this.CH_Design.Text = "Обозначение";
            this.CH_Design.Width = 188;
            // 
            // CH_Name
            // 
            this.CH_Name.Text = "Наименование";
            this.CH_Name.Width = 163;
            // 
            // CH_Quantity
            // 
            this.CH_Quantity.Text = "Кол-во";
            this.CH_Quantity.Width = 82;
            // 
            // CH_Note
            // 
            this.CH_Note.Text = "Примечание";
            this.CH_Note.Width = 124;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem TS1_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_CreateProject_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_OpenProject_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TS_Quit_MenuItem;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.TreeView TreeProduct;
        private System.Windows.Forms.ListView LV_Product;
        private System.Windows.Forms.ColumnHeader CH_Position;
        private System.Windows.Forms.ColumnHeader CH_Design;
        private System.Windows.Forms.ColumnHeader CH_Section;
        private System.Windows.Forms.ColumnHeader CH_Name;
        private System.Windows.Forms.ColumnHeader CH_Quantity;
        private System.Windows.Forms.ColumnHeader CH_Note;
    }
}