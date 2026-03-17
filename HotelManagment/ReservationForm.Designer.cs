namespace HotelManagment
{
    partial class ReservationForm
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
            Reserve = new TabControl();
            tabReservation = new TabPage();
            button6 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            menuStrip2 = new MenuStrip();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            maToolStripMenuItem = new ToolStripMenuItem();
            loadAllReservationsToolStripMenuItem = new ToolStripMenuItem();
            loadReservationToolStripMenuItem = new ToolStripMenuItem();
            loadGuestsToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            cmbGender = new ComboBox();
            dtpBirth = new DateTimePicker();
            txtPhone = new TextBox();
            txtName = new TextBox();
            lstGuests = new ListBox();
            button7 = new Button();
            Reserve.SuspendLayout();
            tabReservation.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // Reserve
            // 
            Reserve.Controls.Add(tabReservation);
            Reserve.Controls.Add(tabPage2);
            Reserve.Controls.Add(tabPage1);
            Reserve.Dock = DockStyle.Fill;
            Reserve.Location = new Point(0, 0);
            Reserve.Name = "Reserve";
            Reserve.SelectedIndex = 0;
            Reserve.Size = new Size(800, 450);
            Reserve.TabIndex = 0;
            // 
            // tabReservation
            // 
            tabReservation.Controls.Add(button7);
            tabReservation.Controls.Add(button6);
            tabReservation.Controls.Add(button5);
            tabReservation.Controls.Add(listBox1);
            tabReservation.Controls.Add(checkBox1);
            tabReservation.Controls.Add(button1);
            tabReservation.Controls.Add(label4);
            tabReservation.Controls.Add(label3);
            tabReservation.Controls.Add(label2);
            tabReservation.Controls.Add(label1);
            tabReservation.Controls.Add(dateTimePicker2);
            tabReservation.Controls.Add(dateTimePicker1);
            tabReservation.Controls.Add(comboBox2);
            tabReservation.Controls.Add(comboBox1);
            tabReservation.Controls.Add(menuStrip2);
            tabReservation.Location = new Point(4, 29);
            tabReservation.Name = "tabReservation";
            tabReservation.Padding = new Padding(3);
            tabReservation.Size = new Size(792, 417);
            tabReservation.TabIndex = 0;
            tabReservation.Text = "Reservation";
            tabReservation.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(374, 225);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(201, 225);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 8;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(600, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 244);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(271, 180);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Has Food?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(50, 225);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 100);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Check out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 100);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Check in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 18);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Guest";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(310, 123);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(-4, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(310, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(786, 24);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(menuStrip1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "All Reservations";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { maToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(786, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // maToolStripMenuItem
            // 
            maToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadAllReservationsToolStripMenuItem, loadReservationToolStripMenuItem, loadGuestsToolStripMenuItem });
            maToolStripMenuItem.Name = "maToolStripMenuItem";
            maToolStripMenuItem.Size = new Size(77, 24);
            maToolStripMenuItem.Text = "Manage";
            // 
            // loadAllReservationsToolStripMenuItem
            // 
            loadAllReservationsToolStripMenuItem.Name = "loadAllReservationsToolStripMenuItem";
            loadAllReservationsToolStripMenuItem.Size = new Size(226, 26);
            loadAllReservationsToolStripMenuItem.Text = "LoadAllReservations";
            loadAllReservationsToolStripMenuItem.Click += loadAllReservationsToolStripMenuItem_Click;
            // 
            // loadReservationToolStripMenuItem
            // 
            loadReservationToolStripMenuItem.Name = "loadReservationToolStripMenuItem";
            loadReservationToolStripMenuItem.Size = new Size(226, 26);
            loadReservationToolStripMenuItem.Text = "LoadReservation";
            loadReservationToolStripMenuItem.Click += loadReservationToolStripMenuItem_Click;
            // 
            // loadGuestsToolStripMenuItem
            // 
            loadGuestsToolStripMenuItem.Name = "loadGuestsToolStripMenuItem";
            loadGuestsToolStripMenuItem.Size = new Size(226, 26);
            loadGuestsToolStripMenuItem.Text = "LoadGuests";
            loadGuestsToolStripMenuItem.Click += loadGuestsToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(cmbGender);
            tabPage1.Controls.Add(dtpBirth);
            tabPage1.Controls.Add(txtPhone);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(lstGuests);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Guest";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(311, 230);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(178, 230);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 230);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(87, 122);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 3;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(261, 122);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(252, 27);
            dtpBirth.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(261, 43);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // lstGuests
            // 
            lstGuests.FormattingEnabled = true;
            lstGuests.Location = new Point(587, 42);
            lstGuests.Name = "lstGuests";
            lstGuests.Size = new Size(150, 264);
            lstGuests.TabIndex = 0;
            lstGuests.SelectedIndexChanged += lstGuests_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Location = new Point(214, 302);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 9;
            button7.Text = "Show Bill";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reserve);
            MainMenuStrip = menuStrip1;
            Name = "ReservationForm";
            Text = "ReservationForm";
            Load += ReservationForm_Load;
            Reserve.ResumeLayout(false);
            tabReservation.ResumeLayout(false);
            tabReservation.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Reserve;
        private TabPage tabReservation;
        private TabPage tabPage2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem maToolStripMenuItem;
        private ToolStripMenuItem loadAllReservationsToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem loadReservationToolStripMenuItem;
        private ToolStripMenuItem loadGuestsToolStripMenuItem;
        private CheckBox checkBox1;
        private TabPage tabPage1;
        private TextBox txtPhone;
        private TextBox txtName;
        private ListBox lstGuests;
        private Button button4;
        private Button button3;
        private Button button2;
        private ComboBox cmbGender;
        private DateTimePicker dtpBirth;
        private ListBox listBox1;
        private Button button6;
        private Button button5;
        private Button button7;
    }
}