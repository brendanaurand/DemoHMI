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
            btnHeartBeat.Location = new Point(75, 87);
            btnHeartBeat.Name = "btnHeartBeat";
            btnHeartBeat.Size = new Size(94, 29);
            btnHeartBeat.TabIndex = 0;
            btnHeartBeat.Text = "HeartBeat";
            btnHeartBeat.UseVisualStyleBackColor = true;
            // 
            // labelPartNumber
            // 
            labelPartNumber.AutoSize = true;
            labelPartNumber.Location = new Point(513, 153);
            labelPartNumber.Name = "labelPartNumber";
            labelPartNumber.Size = new Size(120, 20);
            labelPartNumber.TabIndex = 1;
            labelPartNumber.Text = "Part Number: NA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
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
