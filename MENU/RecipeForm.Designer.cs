namespace MENU
{
    partial class RecipeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInstructoins = new System.Windows.Forms.TextBox();
            this.chlFreezable = new System.Windows.Forms.CheckBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.lblVideoLink = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnRemoveIngredient = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 40);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(85, 16);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Инструкция";
            // 
            // txtInstructoins
            // 
            this.txtInstructoins.Location = new System.Drawing.Point(149, 37);
            this.txtInstructoins.Multiline = true;
            this.txtInstructoins.Name = "txtInstructoins";
            this.txtInstructoins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstructoins.Size = new System.Drawing.Size(320, 142);
            this.txtInstructoins.TabIndex = 3;
            this.txtInstructoins.TextChanged += new System.EventHandler(this.txtInstructoins_TextChanged);
            // 
            // chlFreezable
            // 
            this.chlFreezable.AutoSize = true;
            this.chlFreezable.Location = new System.Drawing.Point(501, 15);
            this.chlFreezable.Name = "chlFreezable";
            this.chlFreezable.Size = new System.Drawing.Size(172, 20);
            this.chlFreezable.TabIndex = 4;
            this.chlFreezable.Text = "Можно замораживать";
            this.chlFreezable.UseVisualStyleBackColor = true;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(149, 222);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(320, 22);
            this.txtImagePath.TabIndex = 5;
            this.txtImagePath.TextChanged += new System.EventHandler(this.txtImagePath_TextChanged);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(12, 197);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(41, 16);
            this.lblImagePath.TabIndex = 6;
            this.lblImagePath.Text = "Фото";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.AutoSize = true;
            this.btnBrowseImage.Location = new System.Drawing.Point(501, 195);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(110, 26);
            this.btnBrowseImage.TabIndex = 7;
            this.btnBrowseImage.Text = "Выбрать фото";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(149, 194);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(320, 22);
            this.txtVideoLink.TabIndex = 8;
            this.txtVideoLink.TextChanged += new System.EventHandler(this.txtVideoLink_TextChanged);
            // 
            // lblVideoLink
            // 
            this.lblVideoLink.AutoSize = true;
            this.lblVideoLink.Location = new System.Drawing.Point(12, 228);
            this.lblVideoLink.Name = "lblVideoLink";
            this.lblVideoLink.Size = new System.Drawing.Size(48, 16);
            this.lblVideoLink.TabIndex = 9;
            this.lblVideoLink.Text = "Видео";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colQty,
            this.colUnit,
            this.colCalories,
            this.colPrice,
            this.colStore});
            this.dgvIngredients.Location = new System.Drawing.Point(15, 298);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.RowHeadersWidth = 51;
            this.dgvIngredients.RowTemplate.Height = 24;
            this.dgvIngredients.Size = new System.Drawing.Size(550, 220);
            this.dgvIngredients.TabIndex = 10;
            // 
            // colName
            // 
            this.colName.HeaderText = "Название";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Кол-во";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Ед.изм.";
            this.colUnit.MinimumWidth = 6;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colCalories
            // 
            this.colCalories.HeaderText = "Кал/ед";
            this.colCalories.MinimumWidth = 6;
            this.colCalories.Name = "colCalories";
            this.colCalories.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Цена/ед.";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStore
            // 
            this.colStore.HeaderText = "Магазин";
            this.colStore.MinimumWidth = 6;
            this.colStore.Name = "colStore";
            this.colStore.ReadOnly = true;
            // 
            // cmbStore
            // 
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(379, 526);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(150, 24);
            this.cmbStore.TabIndex = 11;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.AutoSize = true;
            this.btnAddIngredient.Location = new System.Drawing.Point(26, 524);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(160, 26);
            this.btnAddIngredient.TabIndex = 12;
            this.btnAddIngredient.Text = "Добавить ингредиент";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.AutoSize = true;
            this.btnRemoveIngredient.Location = new System.Drawing.Point(192, 524);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(149, 26);
            this.btnRemoveIngredient.TabIndex = 13;
            this.btnRemoveIngredient.Text = "Удалить выбранный";
            this.btnRemoveIngredient.UseVisualStyleBackColor = true;
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить рецепт";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ингредиенты:";
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.lblVideoLink);
            this.Controls.Add(this.txtVideoLink);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.chlFreezable);
            this.Controls.Add(this.txtInstructoins);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "RecipeForm";
            this.Text = "RecipeForm";
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInstructoins;
        private System.Windows.Forms.CheckBox chlFreezable;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.Label lblVideoLink;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStore;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnRemoveIngredient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}