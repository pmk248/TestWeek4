

namespace TestWeek4
{
    partial class DateForm
    {
        private const bool V = true;

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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sendbutton = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "יום ראשון", "יום שני", "יום שלישי", "יום רבעי", "יום חמישי", "יום ששי", "יום שבת קודש" });
            comboBox1.Location = new Point(12, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Sunday";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "תשרי", "חשון", "כסלו", "טבת", "שבט", "אדר א", "אדר ב", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            comboBox2.Location = new Point(408, 57);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "January";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            comboBox3.Location = new Point(606, 57);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "2024";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "יום אחד", "שני ימים", "שלשה ימים", "ארבעה ימים", "חמישה ימים", "שישה ימים", "שבעה ימים", "שומנה ימים", "תשעה ימים ", "עשרה ימים", "אחד עשר יום", "שנים עשר יום", "שלשה עשר יום", "ארבעה עשר ימים", "חמישה עשר ימים", "ששה עשר יום", "שבעה עשר ימים", "שמונה עשר ימים", "תשעהעשר ימים", "עשרים יום", "עשרים ואחד ימים", "עשרים ושתיים ימים", "עשרים ושלושה ימים", "עשרים וארבעה ימים", "עשרים וחמישה ימים", "עשרים וששה ימים", "עשרים ושבעה ימים", "עשרים ותשעה ימים", "שלושים ימים" });
            comboBox4.Location = new Point(210, 57);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 33);
            comboBox4.TabIndex = 3;
            comboBox4.Text = "1";
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 38);
            label1.TabIndex = 4;
            label1.Text = "Day Of Week";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(182, 38);
            label2.TabIndex = 5;
            label2.Text = "Day Of Month";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(408, 9);
            label3.Name = "label3";
            label3.Size = new Size(182, 38);
            label3.TabIndex = 6;
            label3.Text = "Month";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(606, 9);
            label4.Name = "label4";
            label4.Size = new Size(182, 38);
            label4.TabIndex = 7;
            label4.Text = "Year";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sendbutton
            // 
            sendbutton.Location = new Point(667, 404);
            sendbutton.Name = "sendbutton";
            sendbutton.Size = new Size(112, 34);
            sendbutton.TabIndex = 8;
            sendbutton.Text = "Send";
            sendbutton.UseVisualStyleBackColor = V;
            sendbutton.Click += sendbutton_Click;
            // 
            // DateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sendbutton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "DateForm";
            Text = "DateForm";
            ResumeLayout(false);
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button sendbutton;
    }
}
