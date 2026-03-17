namespace HotelManagment
{
    partial class KitchenForm
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
            lstFoodReservations = new ListBox();
            btnMarkServed = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lstFoodReservations
            // 
            lstFoodReservations.FormattingEnabled = true;
            lstFoodReservations.Location = new Point(143, 49);
            lstFoodReservations.Name = "lstFoodReservations";
            lstFoodReservations.Size = new Size(432, 244);
            lstFoodReservations.TabIndex = 0;
            // 
            // btnMarkServed
            // 
            btnMarkServed.Location = new Point(282, 320);
            btnMarkServed.Name = "btnMarkServed";
            btnMarkServed.Size = new Size(173, 29);
            btnMarkServed.TabIndex = 1;
            btnMarkServed.Text = "MarkServed";
            btnMarkServed.UseVisualStyleBackColor = true;
            btnMarkServed.Click += btnMarkServed_Click;
            // 
            // button2
            // 
            button2.Location = new Point(282, 355);
            button2.Name = "button2";
            button2.Size = new Size(173, 29);
            button2.TabIndex = 1;
            button2.Text = "NewMeals";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // KitchenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnMarkServed);
            Controls.Add(lstFoodReservations);
            Name = "KitchenForm";
            Text = "KitchenForm";
            Load += KitchenForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstFoodReservations;
        private Button btnMarkServed;
        private Button button2;
    }
}