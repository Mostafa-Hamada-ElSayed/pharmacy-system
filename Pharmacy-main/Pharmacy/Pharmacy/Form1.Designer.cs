using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    partial class pharmacy
    {

        private void InitializeComponent()
        {
            Id = new Label();
            Id.Size = new System.Drawing.Size(50, 70);
            Id.Text = "ID";
            Id.Location = new System.Drawing.Point(70, 290);
            Id.BackColor = Color.Transparent;
            Controls.Add(Id);

            Price = new Label();
            Price.Size = new System.Drawing.Size(50, 70);
            Price.Text = "Price";
            Price.Location = new System.Drawing.Point(70, 190);
            Price.BackColor = Color.Transparent;
            Controls.Add(Price);


            DrugName = new Label();
            DrugName.Size = new System.Drawing.Size(50, 70);
            DrugName.Text = "Drug Name";
            DrugName.BackColor = Color.Transparent;
            DrugName.Location = new System.Drawing.Point(400, 190);

            Controls.Add(DrugName);

            Count = new Label();
            Count.Size = new System.Drawing.Size(50, 70);
            Count.Text = "Count";
            Count.Location = new System.Drawing.Point(400, 290);
            Count.BackColor = Color.Transparent;
            Controls.Add(Count);

            TId = new TextBox();
            TId.Size = new Size(150, 25);
            TId.Location = new System.Drawing.Point(120, 290);
            Controls.Add(TId);

            TPrice = new TextBox();
            TPrice.Size = new Size(150, 25);
            TPrice.Location = new System.Drawing.Point(120, 190);
            Controls.Add(TPrice);

            TDrugName = new TextBox();
            TDrugName.Size = new Size(150, 25);
            TDrugName.Location = new System.Drawing.Point(460, 190);
            Controls.Add(TDrugName);

            TCount = new TextBox();
            TCount.Size = new Size(150, 25);
            TCount.Location = new System.Drawing.Point(460, 290);
            Controls.Add(TCount);

            TDisplayItems = new TextBox();
            TDisplayItems.Size = new Size(200, 150);
            TDisplayItems.Location = new System.Drawing.Point(750, 20);
            TDisplayItems.ReadOnly = true;
            TDisplayItems.Multiline = true;
            Controls.Add(TDisplayItems);

            TDisplayPrice = new TextBox();
            TDisplayPrice.Size = new Size(200, 150);
            TDisplayPrice.Location = new System.Drawing.Point(750, 260);
            TDisplayPrice.Multiline = true;
            TDisplayPrice.ReadOnly = true;
            Controls.Add(TDisplayPrice);

            AddDrug = new Button();
            AddDrug.Size = new Size(150, 30);
            AddDrug.Location = new System.Drawing.Point(275, 360);
            AddDrug.Text = "Add Drug";
            AddDrug.Click += AddDrug_Click;
            Controls.Add(AddDrug);

            DisplayItems = new Button();
            DisplayItems.Size = new Size(150, 50);
            DisplayItems.Location = new System.Drawing.Point(775, 180);
            DisplayItems.Text = "Display less than 10 Items";
            DisplayItems.Click += DisplayItems_Click;
            Controls.Add(DisplayItems);

            DisplayPrice = new Button();
            DisplayPrice.Size = new Size(150, 50);
            DisplayPrice.Location = new System.Drawing.Point(775, 420);
            DisplayPrice.Text = "Display Drugs Price > 1000";
            DisplayPrice.Click += DisplayPrice_Click;
            Controls.Add(DisplayPrice);

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Pharmacy management system";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = Pharmacy.Properties.Resources.background;
            this.Icon = Pharmacy.Properties.Resources.icon;
            this.ResumeLayout(false);



        }

        private Label Id;
        private Label Price;
        private Label Count;
        private Label DrugName;


        private Button AddDrug;
        private Button DisplayItems;
        private Button DisplayPrice;


        private TextBox TPrice;
        private TextBox TId;
        private TextBox TCount;
        private TextBox TDrugName;
        private TextBox TDisplayItems;
        private TextBox TDisplayPrice;



    }
}

