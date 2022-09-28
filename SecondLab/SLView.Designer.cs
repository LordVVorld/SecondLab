namespace SecondLab
{
    partial class SLView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label XMLFileLabel;
            System.Windows.Forms.Label deserializedLabel;
            this.XMLFileTextBox = new System.Windows.Forms.RichTextBox();
            this.deserializedTextBox = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            XMLFileLabel = new System.Windows.Forms.Label();
            deserializedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XMLFileTextBox
            // 
            this.XMLFileTextBox.Location = new System.Drawing.Point(12, 25);
            this.XMLFileTextBox.Name = "XMLFileTextBox";
            this.XMLFileTextBox.ReadOnly = true;
            this.XMLFileTextBox.Size = new System.Drawing.Size(310, 410);
            this.XMLFileTextBox.TabIndex = 0;
            this.XMLFileTextBox.Text = "";
            // 
            // deserializedTextBox
            // 
            this.deserializedTextBox.Location = new System.Drawing.Point(467, 25);
            this.deserializedTextBox.Name = "deserializedTextBox";
            this.deserializedTextBox.ReadOnly = true;
            this.deserializedTextBox.Size = new System.Drawing.Size(305, 410);
            this.deserializedTextBox.TabIndex = 1;
            this.deserializedTextBox.Text = "";
            // 
            // XMLFileLabel
            // 
            XMLFileLabel.AutoSize = true;
            XMLFileLabel.Location = new System.Drawing.Point(12, 9);
            XMLFileLabel.Name = "XMLFileLabel";
            XMLFileLabel.Size = new System.Drawing.Size(87, 13);
            XMLFileLabel.TabIndex = 2;
            XMLFileLabel.Text = "XML File content";
            // 
            // deserializedLabel
            // 
            deserializedLabel.AutoSize = true;
            deserializedLabel.Location = new System.Drawing.Point(688, 9);
            deserializedLabel.Name = "deserializedLabel";
            deserializedLabel.Size = new System.Drawing.Size(84, 13);
            deserializedLabel.TabIndex = 3;
            deserializedLabel.Text = "Deserialized text";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(358, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Do Magic";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // SLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.startButton);
            this.Controls.Add(deserializedLabel);
            this.Controls.Add(XMLFileLabel);
            this.Controls.Add(this.deserializedTextBox);
            this.Controls.Add(this.XMLFileTextBox);
            this.Name = "SLView";
            this.Text = "SecondLab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox XMLFileTextBox;
        private System.Windows.Forms.RichTextBox deserializedTextBox;
        private System.Windows.Forms.Button startButton;
    }
}

