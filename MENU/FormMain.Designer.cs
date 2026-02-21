namespace MENU
{
    partial class FormMain
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnGenerateMenu = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalBreadUnits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMenu.Location = new System.Drawing.Point(0, 309);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(863, 300);
            this.dgvMenu.TabIndex = 0;
            // 
            // btnGenerateMenu
            // 
            this.btnGenerateMenu.AutoSize = true;
            this.btnGenerateMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateMenu.Location = new System.Drawing.Point(10, 46);
            this.btnGenerateMenu.Name = "btnGenerateMenu";
            this.btnGenerateMenu.Size = new System.Drawing.Size(189, 56);
            this.btnGenerateMenu.TabIndex = 1;
            this.btnGenerateMenu.Text = "Сформировать меню";
            this.btnGenerateMenu.UseVisualStyleBackColor = true;
            this.btnGenerateMenu.Click += new System.EventHandler(this.btnGenerateMenu_Click);
            // 
            // btnCart
            // 
            this.btnCart.AutoSize = true;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCart.Location = new System.Drawing.Point(751, 12);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(100, 56);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Корзина";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.AutoSize = true;
            this.btnAddRecipe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRecipe.Location = new System.Drawing.Point(10, 108);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(156, 56);
            this.btnAddRecipe.TabIndex = 3;
            this.btnAddRecipe.Text = "Добавить рецепт";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(10, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(277, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 56);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.AutoSize = true;
            this.btnEditRecipe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditRecipe.Location = new System.Drawing.Point(10, 170);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(199, 33);
            this.btnEditRecipe.TabIndex = 6;
            this.btnEditRecipe.Text = "Редактировать рецепт";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
            // 
            // lstRecipes
            // 
            this.lstRecipes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 23;
            this.lstRecipes.Location = new System.Drawing.Point(228, 170);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(268, 96);
            this.lstRecipes.TabIndex = 7;
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.AutoSize = true;
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteRecipe.Location = new System.Drawing.Point(10, 209);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(143, 33);
            this.btnDeleteRecipe.TabIndex = 8;
            this.btnDeleteRecipe.Text = "Удалить рецепт";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalCalories.Location = new System.Drawing.Point(513, 209);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(186, 23);
            this.lblTotalCalories.TabIndex = 9;
            this.lblTotalCalories.Text = "Калорийность : 0 кКал";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalPrice.Location = new System.Drawing.Point(513, 243);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(154, 23);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Стоимость : 0 руб.";
            // 
            // lblTotalBreadUnits
            // 
            this.lblTotalBreadUnits.AutoSize = true;
            this.lblTotalBreadUnits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalBreadUnits.Location = new System.Drawing.Point(731, 209);
            this.lblTotalBreadUnits.Name = "lblTotalBreadUnits";
            this.lblTotalBreadUnits.Size = new System.Drawing.Size(87, 23);
            this.lblTotalBreadUnits.TabIndex = 11;
            this.lblTotalBreadUnits.Text = "X.E. : 0 ед.";
            this.lblTotalBreadUnits.Click += new System.EventHandler(this.lblTotalBreadUnits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(392, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Категория";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Location = new System.Drawing.Point(517, 10);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(182, 31);
            this.cmbFilterCategory.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 609);
            this.Controls.Add(this.cmbFilterCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalBreadUnits);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnGenerateMenu);
            this.Controls.Add(this.dgvMenu);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnGenerateMenu;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalBreadUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
    }
}

