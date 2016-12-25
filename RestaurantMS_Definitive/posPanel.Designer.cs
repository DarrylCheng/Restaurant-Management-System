namespace RestaurantMS_Definitive
{
    partial class posPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(posPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentOrderView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableID = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.takeAwayButton = new System.Windows.Forms.Button();
            this.eatingHereButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insertOrderButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.foodCategory = new System.Windows.Forms.Button();
            this.beverageCategory = new System.Windows.Forms.Button();
            this.itemIDText = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.modifyButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingButton)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentOrderView);
            this.groupBox1.Controls.Add(this.tableID);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Order";
            // 
            // currentOrderView
            // 
            this.currentOrderView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.currentOrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.currentOrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOrderView.FullRowSelect = true;
            this.currentOrderView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.currentOrderView.HideSelection = false;
            this.currentOrderView.Location = new System.Drawing.Point(11, 17);
            this.currentOrderView.MultiSelect = false;
            this.currentOrderView.Name = "currentOrderView";
            this.currentOrderView.Size = new System.Drawing.Size(505, 313);
            this.currentOrderView.TabIndex = 10;
            this.currentOrderView.UseCompatibleStateImageBehavior = false;
            this.currentOrderView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Item ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 283;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price (RM)";
            this.columnHeader3.Width = 79;
            // 
            // tableID
            // 
            this.tableID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableID.FormattingEnabled = true;
            this.tableID.Location = new System.Drawing.Point(315, 336);
            this.tableID.Name = "tableID";
            this.tableID.Size = new System.Drawing.Size(196, 21);
            this.tableID.Sorted = true;
            this.tableID.TabIndex = 9;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(44, 336);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(265, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Table ID (Ignore for take away orders):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.takeAwayButton);
            this.groupBox2.Controls.Add(this.eatingHereButton);
            this.groupBox2.Location = new System.Drawing.Point(245, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Order";
            // 
            // takeAwayButton
            // 
            this.takeAwayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.takeAwayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeAwayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeAwayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeAwayButton.ForeColor = System.Drawing.SystemColors.Control;
            this.takeAwayButton.Image = global::RestaurantMS_Definitive.Properties.Resources.ic_airport_shuttle_white_48dp_1x;
            this.takeAwayButton.Location = new System.Drawing.Point(6, 19);
            this.takeAwayButton.Name = "takeAwayButton";
            this.takeAwayButton.Size = new System.Drawing.Size(127, 64);
            this.takeAwayButton.TabIndex = 5;
            this.takeAwayButton.Text = "Take Away";
            this.takeAwayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.takeAwayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.takeAwayButton.UseVisualStyleBackColor = false;
            this.takeAwayButton.Click += new System.EventHandler(this.takeAwayButton_Click);
            // 
            // eatingHereButton
            // 
            this.eatingHereButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.eatingHereButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eatingHereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eatingHereButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatingHereButton.ForeColor = System.Drawing.SystemColors.Control;
            this.eatingHereButton.Image = global::RestaurantMS_Definitive.Properties.Resources.food_fork_drink__1_;
            this.eatingHereButton.Location = new System.Drawing.Point(139, 19);
            this.eatingHereButton.Name = "eatingHereButton";
            this.eatingHereButton.Size = new System.Drawing.Size(127, 64);
            this.eatingHereButton.TabIndex = 4;
            this.eatingHereButton.Text = "Dine In";
            this.eatingHereButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eatingHereButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eatingHereButton.UseVisualStyleBackColor = false;
            this.eatingHereButton.Click += new System.EventHandler(this.eatingHereButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Image = global::RestaurantMS_Definitive.Properties.Resources.ic_clear_white_48dp_1x;
            this.clearButton.Location = new System.Drawing.Point(6, 377);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 64);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(118, 377);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 64);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Remove";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.menuView);
            this.groupBox3.Controls.Add(this.insertOrderButton);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.itemIDText);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Location = new System.Drawing.Point(540, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 516);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Food Menu";
            // 
            // menuView
            // 
            this.menuView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.menuView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.menuView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuView.FullRowSelect = true;
            this.menuView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.menuView.HideSelection = false;
            this.menuView.Location = new System.Drawing.Point(16, 121);
            this.menuView.MultiSelect = false;
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(474, 294);
            this.menuView.TabIndex = 15;
            this.menuView.UseCompatibleStateImageBehavior = false;
            this.menuView.View = System.Windows.Forms.View.Details;
            this.menuView.SelectedIndexChanged += new System.EventHandler(this.menuView_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item ID";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Name";
            this.columnHeader5.Width = 278;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price (RM)";
            this.columnHeader7.Width = 104;
            // 
            // insertOrderButton
            // 
            this.insertOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.insertOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertOrderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.insertOrderButton.Image = global::RestaurantMS_Definitive.Properties.Resources.ic_keyboard_return_white_48dp_1x;
            this.insertOrderButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertOrderButton.Location = new System.Drawing.Point(338, 433);
            this.insertOrderButton.Name = "insertOrderButton";
            this.insertOrderButton.Size = new System.Drawing.Size(152, 56);
            this.insertOrderButton.TabIndex = 13;
            this.insertOrderButton.Text = "Insert into Order";
            this.insertOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insertOrderButton.UseVisualStyleBackColor = false;
            this.insertOrderButton.Click += new System.EventHandler(this.insertOrderButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.foodCategory);
            this.groupBox4.Controls.Add(this.beverageCategory);
            this.groupBox4.Location = new System.Drawing.Point(16, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 96);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category";
            // 
            // foodCategory
            // 
            this.foodCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.foodCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.foodCategory.Image = global::RestaurantMS_Definitive.Properties.Resources.hamburger;
            this.foodCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.foodCategory.Location = new System.Drawing.Point(6, 22);
            this.foodCategory.Name = "foodCategory";
            this.foodCategory.Size = new System.Drawing.Size(138, 64);
            this.foodCategory.TabIndex = 6;
            this.foodCategory.Text = "Food";
            this.foodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.foodCategory.UseVisualStyleBackColor = false;
            this.foodCategory.Click += new System.EventHandler(this.foodCategory_Click);
            // 
            // beverageCategory
            // 
            this.beverageCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.beverageCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beverageCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beverageCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverageCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.beverageCategory.Image = global::RestaurantMS_Definitive.Properties.Resources.cup_water;
            this.beverageCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.beverageCategory.Location = new System.Drawing.Point(150, 22);
            this.beverageCategory.Name = "beverageCategory";
            this.beverageCategory.Size = new System.Drawing.Size(145, 64);
            this.beverageCategory.TabIndex = 7;
            this.beverageCategory.Text = "Beverages";
            this.beverageCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beverageCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.beverageCategory.UseVisualStyleBackColor = false;
            this.beverageCategory.Click += new System.EventHandler(this.beverageCategory_Click);
            // 
            // itemIDText
            // 
            this.itemIDText.Location = new System.Drawing.Point(82, 436);
            this.itemIDText.Name = "itemIDText";
            this.itemIDText.Size = new System.Drawing.Size(165, 20);
            this.itemIDText.TabIndex = 12;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 435);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Item ID";
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.modifyButton.Image = global::RestaurantMS_Definitive.Properties.Resources.ic_edit_white_48dp_1x;
            this.modifyButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modifyButton.Location = new System.Drawing.Point(18, 536);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(132, 57);
            this.modifyButton.TabIndex = 8;
            this.modifyButton.Text = "Modify Order";
            this.modifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.paymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.paymentButton.Image = global::RestaurantMS_Definitive.Properties.Resources.ic_monetization_on_white_48dp_1x;
            this.paymentButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paymentButton.Location = new System.Drawing.Point(391, 536);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(132, 57);
            this.paymentButton.TabIndex = 6;
            this.paymentButton.Text = "Make Payment";
            this.paymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Transparent;
            this.settingButton.Image = global::RestaurantMS_Definitive.Properties.Resources.settings;
            this.settingButton.Location = new System.Drawing.Point(1019, 30);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(27, 24);
            this.settingButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingButton.TabIndex = 3;
            this.settingButton.TabStop = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // posPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 605);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "posPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restaurant POS System";
            this.Load += new System.EventHandler(this.posPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox settingButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button eatingHereButton;
        private System.Windows.Forms.Button takeAwayButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button foodCategory;
        private System.Windows.Forms.Button beverageCategory;
        private System.Windows.Forms.Button insertOrderButton;
        private System.Windows.Forms.TextBox itemIDText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox tableID;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListView currentOrderView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView menuView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}