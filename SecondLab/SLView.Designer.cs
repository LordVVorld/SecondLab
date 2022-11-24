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
            // XMLFileLabel
            // 
            XMLFileLabel.AutoSize = true;
            XMLFileLabel.Location = new System.Drawing.Point(15, 10);
            XMLFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            XMLFileLabel.Name = "XMLFileLabel";
            XMLFileLabel.Size = new System.Drawing.Size(132, 24);
            XMLFileLabel.TabIndex = 2;
            XMLFileLabel.Text = "XML File content";
            // 
            // deserializedLabel
            // 
            deserializedLabel.AutoSize = true;
            deserializedLabel.Location = new System.Drawing.Point(505, 10);
            deserializedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            deserializedLabel.Name = "deserializedLabel";
            deserializedLabel.Size = new System.Drawing.Size(136, 24);
            deserializedLabel.TabIndex = 3;
            deserializedLabel.Text = "Deserialized text";
            // 
            // XMLFileTextBox
            // 
            this.XMLFileTextBox.Font = new System.Drawing.Font("Alegreya SC", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMLFileTextBox.Location = new System.Drawing.Point(15, 40);
            this.XMLFileTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.XMLFileTextBox.Name = "XMLFileTextBox";
            this.XMLFileTextBox.ReadOnly = true;
            this.XMLFileTextBox.Size = new System.Drawing.Size(360, 505);
            this.XMLFileTextBox.TabIndex = 0;
            this.XMLFileTextBox.Text = "";
            // 
            // deserializedTextBox
            // 
            this.deserializedTextBox.Font = new System.Drawing.Font("Alegreya SC", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deserializedTextBox.Location = new System.Drawing.Point(505, 40);
            this.deserializedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deserializedTextBox.Name = "deserializedTextBox";
            this.deserializedTextBox.ReadOnly = true;
            this.deserializedTextBox.Size = new System.Drawing.Size(360, 505);
            this.deserializedTextBox.TabIndex = 1;
            this.deserializedTextBox.Text = "";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(380, 40);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 45);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Deserialize";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // SLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.startButton);
            this.Controls.Add(deserializedLabel);
            this.Controls.Add(XMLFileLabel);
            this.Controls.Add(this.XMLFileTextBox);
            this.Controls.Add(this.deserializedTextBox);
            this.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SLView";
            this.Text = "Deserializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox XMLFileTextBox;
        private System.Windows.Forms.RichTextBox deserializedTextBox;
        private System.Windows.Forms.Button startButton;
    }
}

