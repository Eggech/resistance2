
namespace resistance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculate = new System.Windows.Forms.Button();
            this.calcullink = new System.Windows.Forms.LinkLabel();
            this.descript = new System.Windows.Forms.TextBox();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.amperagelabel = new System.Windows.Forms.Label();
            this.addstring = new System.Windows.Forms.Button();
            this.voltagelabel = new System.Windows.Forms.Label();
            this.amperage = new System.Windows.Forms.TextBox();
            this.voltage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.AllowDrop = true;
            this.calculate.BackColor = System.Drawing.Color.SpringGreen;
            this.calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.calculate.FlatAppearance.BorderSize = 3;
            this.calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculate.Font = new System.Drawing.Font("Swis721 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.calculate.Location = new System.Drawing.Point(500, 155);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(180, 54);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // calcullink
            // 
            this.calcullink.AutoSize = true;
            this.calcullink.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.calcullink.Location = new System.Drawing.Point(323, 9);
            this.calcullink.Name = "calcullink";
            this.calcullink.Size = new System.Drawing.Size(261, 30);
            this.calcullink.TabIndex = 1;
            this.calcullink.TabStop = true;
            this.calcullink.Text = "Рассчёт сопротивления";
            this.calcullink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.calcullink_LinkClicked);
            // 
            // descript
            // 
            this.descript.Location = new System.Drawing.Point(12, 91);
            this.descript.Name = "descript";
            this.descript.Size = new System.Drawing.Size(215, 23);
            this.descript.TabIndex = 2;
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.descriptionlabel.Location = new System.Drawing.Point(12, 50);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(216, 17);
            this.descriptionlabel.TabIndex = 3;
            this.descriptionlabel.Text = "Название (не обязательно)";
            // 
            // amperagelabel
            // 
            this.amperagelabel.AutoSize = true;
            this.amperagelabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.amperagelabel.Location = new System.Drawing.Point(379, 50);
            this.amperagelabel.Name = "amperagelabel";
            this.amperagelabel.Size = new System.Drawing.Size(84, 17);
            this.amperagelabel.TabIndex = 4;
            this.amperagelabel.Text = "Сила тока";
            // 
            // addstring
            // 
            this.addstring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addstring.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addstring.FlatAppearance.BorderSize = 10;
            this.addstring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.addstring.Font = new System.Drawing.Font("Swis721 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addstring.Location = new System.Drawing.Point(280, 155);
            this.addstring.Name = "addstring";
            this.addstring.Size = new System.Drawing.Size(180, 54);
            this.addstring.TabIndex = 5;
            this.addstring.Text = "Добавить элемент";
            this.addstring.UseVisualStyleBackColor = true;
            this.addstring.Click += new System.EventHandler(this.addstring_Click);
            // 
            // voltagelabel
            // 
            this.voltagelabel.AutoSize = true;
            this.voltagelabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.voltagelabel.Location = new System.Drawing.Point(583, 52);
            this.voltagelabel.Name = "voltagelabel";
            this.voltagelabel.Size = new System.Drawing.Size(100, 17);
            this.voltagelabel.TabIndex = 6;
            this.voltagelabel.Text = "Напряжение";
            // 
            // amperage
            // 
            this.amperage.Location = new System.Drawing.Point(280, 91);
            this.amperage.Name = "amperage";
            this.amperage.Size = new System.Drawing.Size(180, 23);
            this.amperage.TabIndex = 7;
            // 
            // voltage
            // 
            this.voltage.Location = new System.Drawing.Point(500, 91);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(180, 23);
            this.voltage.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voltage);
            this.Controls.Add(this.amperage);
            this.Controls.Add(this.voltagelabel);
            this.Controls.Add(this.addstring);
            this.Controls.Add(this.amperagelabel);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.descript);
            this.Controls.Add(this.calcullink);
            this.Controls.Add(this.calculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор рассчёта сопротивления электроцепи из нескольких элементов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox descript;
        private System.Windows.Forms.Label descriptionlabel;
        public System.Windows.Forms.LinkLabel calcullink;
        private System.Windows.Forms.Label amperagelabel;
        private System.Windows.Forms.Button addstring;
        private System.Windows.Forms.Label voltagelabel;
        private System.Windows.Forms.TextBox amperage;
        private System.Windows.Forms.TextBox voltage;
        private System.Windows.Forms.Label label1;
    }
}

