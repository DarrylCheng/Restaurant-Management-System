namespace RestaurantMS_Definitive
{
    partial class orderMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderMaster));
            this.orderGroup = new System.Windows.Forms.GroupBox();
            this.currentOrderView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.paymentWindow = new System.Windows.Forms.GroupBox();
            this.paymentStatus = new MaterialSkin.Controls.MaterialLabel();
            this.paymentButton = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.TextBox();
            this.amountPaid = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.printButton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insertOrderButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.foodCategory = new System.Windows.Forms.Button();
            this.beverageCategory = new System.Windows.Forms.Button();
            this.itemIDText = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dineInOrders = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.takeAwayOrders = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.backButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.orderGroup.SuspendLayout();
            this.paymentWindow.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGroup
            // 
            this.orderGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderGroup.Controls.Add(this.currentOrderView);
            this.orderGroup.Controls.Add(this.deleteButton);
            this.orderGroup.Controls.Add(this.paymentWindow);
            this.orderGroup.Controls.Add(this.printButton);
            this.orderGroup.Controls.Add(this.priceBox);
            this.orderGroup.Controls.Add(this.groupBox2);
            this.orderGroup.Controls.Add(this.materialLabel2);
            this.orderGroup.Location = new System.Drawing.Point(222, 72);
            this.orderGroup.Name = "orderGroup";
            this.orderGroup.Size = new System.Drawing.Size(996, 527);
            this.orderGroup.TabIndex = 18;
            this.orderGroup.TabStop = false;
            this.orderGroup.Text = "Order Details";
            // 
            // currentOrderView
            // 
            this.currentOrderView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.currentOrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader11});
            this.currentOrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOrderView.FullRowSelect = true;
            this.currentOrderView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.currentOrderView.HideSelection = false;
            this.currentOrderView.Location = new System.Drawing.Point(9, 19);
            this.currentOrderView.MultiSelect = false;
            this.currentOrderView.Name = "currentOrderView";
            this.currentOrderView.Size = new System.Drawing.Size(456, 319);
            this.currentOrderView.TabIndex = 24;
            this.currentOrderView.UseCompatibleStateImageBehavior = false;
            this.currentOrderView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 209;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Price (RM)";
            this.columnHeader11.Width = 88;
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
            this.deleteButton.Location = new System.Drawing.Point(6, 344);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 54);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Remove";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // paymentWindow
            // 
            this.paymentWindow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paymentWindow.Controls.Add(this.paymentStatus);
            this.paymentWindow.Controls.Add(this.paymentButton);
            this.paymentWindow.Controls.Add(this.change);
            this.paymentWindow.Controls.Add(this.amountPaid);
            this.paymentWindow.Controls.Add(this.materialLabel5);
            this.paymentWindow.Controls.Add(this.materialLabel6);
            this.paymentWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentWindow.Location = new System.Drawing.Point(9, 404);
            this.paymentWindow.Name = "paymentWindow";
            this.paymentWindow.Size = new System.Drawing.Size(462, 114);
            this.paymentWindow.TabIndex = 21;
            this.paymentWindow.TabStop = false;
            this.paymentWindow.Text = "Make Payment";
            // 
            // paymentStatus
            // 
            this.paymentStatus.AutoSize = true;
            this.paymentStatus.Depth = 0;
            this.paymentStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.paymentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paymentStatus.Location = new System.Drawing.Point(11, 89);
            this.paymentStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.paymentStatus.Name = "paymentStatus";
            this.paymentStatus.Size = new System.Drawing.Size(112, 19);
            this.paymentStatus.TabIndex = 15;
            this.paymentStatus.Text = "payment status";
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.paymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.paymentButton.Image = global::RestaurantMS_Definitive.Properties.Resources.ic_monetization_on_white_48dp_1x;
            this.paymentButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.paymentButton.Location = new System.Drawing.Point(245, 51);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(211, 57);
            this.paymentButton.TabIndex = 14;
            this.paymentButton.Text = "Complete Payment and Print Receipt";
            this.paymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(107, 49);
            this.change.Name = "change";
            this.change.ReadOnly = true;
            this.change.Size = new System.Drawing.Size(100, 26);
            this.change.TabIndex = 13;
            // 
            // amountPaid
            // 
            this.amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaid.Location = new System.Drawing.Point(107, 17);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(100, 26);
            this.amountPaid.TabIndex = 12;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 24);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(95, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Amount Paid";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(42, 53);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(59, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Change";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.Control;
            this.printButton.Image = global::RestaurantMS_Definitive.Properties.Resources.printer;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printButton.Location = new System.Drawing.Point(138, 344);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(133, 54);
            this.printButton.TabIndex = 20;
            this.printButton.Text = "Print Invoice";
            this.printButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(340, 344);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(131, 29);
            this.priceBox.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.menuView);
            this.groupBox2.Controls.Add(this.insertOrderButton);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.itemIDText);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Location = new System.Drawing.Point(477, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 499);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Menu";
            // 
            // menuView
            // 
            this.menuView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.menuView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9});
            this.menuView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuView.FullRowSelect = true;
            this.menuView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.menuView.HideSelection = false;
            this.menuView.Location = new System.Drawing.Point(16, 117);
            this.menuView.MultiSelect = false;
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(480, 294);
            this.menuView.TabIndex = 17;
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
            this.columnHeader5.Width = 283;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price (RM)";
            this.columnHeader9.Width = 104;
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
            this.insertOrderButton.Location = new System.Drawing.Point(354, 427);
            this.insertOrderButton.Name = "insertOrderButton";
            this.insertOrderButton.Size = new System.Drawing.Size(152, 56);
            this.insertOrderButton.TabIndex = 16;
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
            this.groupBox4.Size = new System.Drawing.Size(480, 92);
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
            this.itemIDText.Location = new System.Drawing.Point(131, 427);
            this.itemIDText.Name = "itemIDText";
            this.itemIDText.Size = new System.Drawing.Size(117, 20);
            this.itemIDText.TabIndex = 12;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 426);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Search Item ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(290, 348);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Total";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.dineInOrders);
            this.groupBox3.Controls.Add(this.takeAwayOrders);
            this.groupBox3.Controls.Add(this.materialLabel4);
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Location = new System.Drawing.Point(12, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 406);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Order";
            // 
            // dineInOrders
            // 
            this.dineInOrders.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.dineInOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.dineInOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineInOrders.FullRowSelect = true;
            this.dineInOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dineInOrders.HideSelection = false;
            this.dineInOrders.Location = new System.Drawing.Point(6, 38);
            this.dineInOrders.MultiSelect = false;
            this.dineInOrders.Name = "dineInOrders";
            this.dineInOrders.Size = new System.Drawing.Size(188, 164);
            this.dineInOrders.TabIndex = 4;
            this.dineInOrders.UseCompatibleStateImageBehavior = false;
            this.dineInOrders.View = System.Windows.Forms.View.Details;
            this.dineInOrders.Click += new System.EventHandler(this.dineInOrders_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order ID";
            this.columnHeader6.Width = 97;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Table ID";
            this.columnHeader7.Width = 87;
            // 
            // takeAwayOrders
            // 
            this.takeAwayOrders.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.takeAwayOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader10});
            this.takeAwayOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeAwayOrders.FullRowSelect = true;
            this.takeAwayOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.takeAwayOrders.HideSelection = false;
            this.takeAwayOrders.Location = new System.Drawing.Point(6, 225);
            this.takeAwayOrders.MultiSelect = false;
            this.takeAwayOrders.Name = "takeAwayOrders";
            this.takeAwayOrders.Size = new System.Drawing.Size(188, 168);
            this.takeAwayOrders.TabIndex = 3;
            this.takeAwayOrders.UseCompatibleStateImageBehavior = false;
            this.takeAwayOrders.View = System.Windows.Forms.View.Details;
            this.takeAwayOrders.Click += new System.EventHandler(this.takeAwayOrders_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Order ID";
            this.columnHeader8.Width = 83;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "TakeAway ID";
            this.columnHeader10.Width = 101;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 203);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(130, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Take Away Orders";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 16);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(103, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Dine In Orders";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Image = global::RestaurantMS_Definitive.Properties.Resources.undo;
            this.backButton.Location = new System.Drawing.Point(12, 545);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 49);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back to Main Menu";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 602);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1223, 22);
            this.status.TabIndex = 23;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // orderMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 624);
            this.Controls.Add(this.status);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.orderGroup);
            this.MaximizeBox = false;
            this.Name = "orderMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Information";
            this.Load += new System.EventHandler(this.orderMaster_Load);
            this.orderGroup.ResumeLayout(false);
            this.orderGroup.PerformLayout();
            this.paymentWindow.ResumeLayout(false);
            this.paymentWindow.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox orderGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button foodCategory;
        private System.Windows.Forms.Button beverageCategory;
        private System.Windows.Forms.TextBox itemIDText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox priceBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView takeAwayOrders;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ListView dineInOrders;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox paymentWindow;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.TextBox change;
        private System.Windows.Forms.TextBox amountPaid;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button insertOrderButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private MaterialSkin.Controls.MaterialLabel paymentStatus;
        private System.Windows.Forms.ListView menuView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView currentOrderView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}