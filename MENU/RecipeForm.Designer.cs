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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.chkCanBeFrozen = new System.Windows.Forms.CheckBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBreadUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnRemoveIngredient = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblTotalBreadUnits = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(120, 8);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 30);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProduct.Location = new System.Drawing.Point(450, 10);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(83, 23);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Продукт :";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInstruction.Location = new System.Drawing.Point(10, 220);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(112, 23);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Инструкция :";
            // 
            // chkCanBeFrozen
            // 
            this.chkCanBeFrozen.AutoSize = true;
            this.chkCanBeFrozen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCanBeFrozen.Location = new System.Drawing.Point(120, 350);
            this.chkCanBeFrozen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCanBeFrozen.Name = "chkCanBeFrozen";
            this.chkCanBeFrozen.Size = new System.Drawing.Size(210, 27);
            this.chkCanBeFrozen.TabIndex = 4;
            this.chkCanBeFrozen.Text = "Можно замораживать";
            this.chkCanBeFrozen.UseVisualStyleBackColor = true;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImagePath.Location = new System.Drawing.Point(10, 50);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(58, 23);
            this.lblImagePath.TabIndex = 6;
            this.lblImagePath.Text = "Фото :";
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.AutoSize = true;
            this.btnChoosePhoto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoosePhoto.Location = new System.Drawing.Point(280, 45);
            this.btnChoosePhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(140, 33);
            this.btnChoosePhoto.TabIndex = 7;
            this.btnChoosePhoto.Text = "Выбрать фото";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            // 
            // txtVideo
            // 
            this.txtVideo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVideo.Location = new System.Drawing.Point(120, 178);
            this.txtVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(300, 30);
            this.txtVideo.TabIndex = 8;
            this.txtVideo.TextChanged += new System.EventHandler(this.txtVideo_TextChanged);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVideo.Location = new System.Drawing.Point(10, 180);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(67, 23);
            this.lblVideo.TabIndex = 9;
            this.lblVideo.Text = "Видео :";
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
            this.colBreadUnits,
            this.colPrice,
            this.colStore});
            this.dgvIngredients.Location = new System.Drawing.Point(10, 390);
            this.dgvIngredients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.RowHeadersWidth = 51;
            this.dgvIngredients.RowTemplate.Height = 24;
            this.dgvIngredients.Size = new System.Drawing.Size(860, 250);
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
            // colBreadUnits
            // 
            this.colBreadUnits.HeaderText = "Хе/ед";
            this.colBreadUnits.MinimumWidth = 6;
            this.colBreadUnits.Name = "colBreadUnits";
            this.colBreadUnits.ReadOnly = true;
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
            this.cmbStore.Location = new System.Drawing.Point(740, 88);
            this.cmbStore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(120, 31);
            this.cmbStore.TabIndex = 11;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.AutoSize = true;
            this.btnAddIngredient.Location = new System.Drawing.Point(450, 130);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(200, 33);
            this.btnAddIngredient.TabIndex = 12;
            this.btnAddIngredient.Text = "Добавить ингредиент";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.AutoSize = true;
            this.btnRemoveIngredient.Location = new System.Drawing.Point(670, 130);
            this.btnRemoveIngredient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(200, 33);
            this.btnRemoveIngredient.TabIndex = 13;
            this.btnRemoveIngredient.Text = "Удалить выбранный";
            this.btnRemoveIngredient.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 650);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить рецепт";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbProductName
            // 
            this.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(560, 8);
            this.cmbProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(300, 31);
            this.cmbProductName.TabIndex = 16;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.DecimalPlaces = 2;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudQuantity.Location = new System.Drawing.Point(560, 48);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(90, 30);
            this.nudQuantity.TabIndex = 17;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.Location = new System.Drawing.Point(450, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(111, 23);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Количество :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(450, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 23);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Цена/ед :  ";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(650, 90);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(87, 23);
            this.lblStore.TabIndex = 20;
            this.lblStore.Text = "Магазин :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(560, 88);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(80, 30);
            this.txtPrice.TabIndex = 21;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnit.Location = new System.Drawing.Point(650, 50);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(70, 23);
            this.lblUnit.TabIndex = 22;
            this.lblUnit.Text = "Ед.изм.:";
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUnit.Location = new System.Drawing.Point(740, 48);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(80, 30);
            this.txtUnit.TabIndex = 23;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecipeName.Location = new System.Drawing.Point(10, 10);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(95, 23);
            this.lblRecipeName.TabIndex = 24;
            this.lblRecipeName.Text = "Название :";
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(120, 45);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(150, 120);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 25;
            this.picPhoto.TabStop = false;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInstruction.Location = new System.Drawing.Point(120, 220);
            this.txtInstruction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstruction.Size = new System.Drawing.Size(300, 120);
            this.txtInstruction.TabIndex = 26;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(446, 317);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(186, 23);
            this.lblTotalCalories.TabIndex = 27;
            this.lblTotalCalories.Text = "Калорийность : 0 кКал";
            this.lblTotalCalories.Click += new System.EventHandler(this.lblTotalCalories_Click);
            // 
            // lblTotalBreadUnits
            // 
            this.lblTotalBreadUnits.AutoSize = true;
            this.lblTotalBreadUnits.Location = new System.Drawing.Point(679, 317);
            this.lblTotalBreadUnits.Name = "lblTotalBreadUnits";
            this.lblTotalBreadUnits.Size = new System.Drawing.Size(84, 23);
            this.lblTotalBreadUnits.TabIndex = 28;
            this.lblTotalBreadUnits.Text = "ХЕ :  0 ед.";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(450, 354);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(154, 23);
            this.lblTotalPrice.TabIndex = 29;
            this.lblTotalPrice.Text = "Стоимость : 0 руб.";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(560, 178);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(188, 31);
            this.cmbCategory.TabIndex = 30;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(450, 181);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 23);
            this.lblCategory.TabIndex = 31;
            this.lblCategory.Text = "Категория";
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 963);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalBreadUnits);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.btnChoosePhoto);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.chkCanBeFrozen);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecipeForm";
            this.Text = "RecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.CheckBox chkCanBeFrozen;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnRemoveIngredient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBreadUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStore;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblTotalBreadUnits;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;


    }
}