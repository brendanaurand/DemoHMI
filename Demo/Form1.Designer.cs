namespace Demo
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
            components = new System.ComponentModel.Container();
            tmrPLCHeartbeat = new System.Windows.Forms.Timer(components);
            btnHeartBeat = new Button();
            labelPartNumber = new Label();
            SuspendLayout();
            // 
            // btnHeartBeat
            // 
            btnHeartBeat.Location = new Point(66, 65);
            btnHeartBeat.Margin = new Padding(3, 2, 3, 2);
            btnHeartBeat.Name = "btnHeartBeat";
            btnHeartBeat.Size = new Size(82, 22);
            btnHeartBeat.TabIndex = 0;
            btnHeartBeat.Text = "HeartBeat";
            btnHeartBeat.UseVisualStyleBackColor = true;
            btnHeartBeat.Click += btnHeartBeat_Click;
            // 
            // labelPartNumber
            // 
            labelPartNumber.AutoSize = true;
            labelPartNumber.Location = new Point(449, 115);
            labelPartNumber.Name = "labelPartNumber";
            labelPartNumber.Size = new Size(98, 15);
            labelPartNumber.TabIndex = 1;
            labelPartNumber.Text = "Part Number: NA";
            labelPartNumber.Click += labelPartNumber_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(labelPartNumber);
            Controls.Add(btnHeartBeat);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrPLCHeartbeat;
        private Button btnHeartBeat;
        private Label labelPartNumber;
    }
}
