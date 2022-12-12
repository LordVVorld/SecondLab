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
            this.actionMenu = new System.Windows.Forms.MenuStrip();
            this.chooseFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeButton = new System.Windows.Forms.ToolStripMenuItem();
            XMLFileLabel = new System.Windows.Forms.Label();
            deserializedLabel = new System.Windows.Forms.Label();
            this.actionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLFileLabel
            // 
            XMLFileLabel.AutoSize = true;
            XMLFileLabel.Location = new System.Drawing.Point(15, 33);
            XMLFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            XMLFileLabel.Name = "XMLFileLabel";
            XMLFileLabel.Size = new System.Drawing.Size(132, 24);
            XMLFileLabel.TabIndex = 2;
            XMLFileLabel.Text = "XML File content";
            // 
            // deserializedLabel
            // 
            deserializedLabel.AutoSize = true;
            deserializedLabel.Location = new System.Drawing.Point(383, 33);
            deserializedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            deserializedLabel.Name = "deserializedLabel";
            deserializedLabel.Size = new System.Drawing.Size(136, 24);
            deserializedLabel.TabIndex = 3;
            deserializedLabel.Text = "Deserialized text";
            // 
            // XMLFileTextBox
            // 
            this.XMLFileTextBox.Font = new System.Drawing.Font("Alegreya SC", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMLFileTextBox.Location = new System.Drawing.Point(15, 63);
            this.XMLFileTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.XMLFileTextBox.Name = "XMLFileTextBox";
            this.XMLFileTextBox.ReadOnly = true;
            this.XMLFileTextBox.Size = new System.Drawing.Size(360, 483);
            this.XMLFileTextBox.TabIndex = 0;
            this.XMLFileTextBox.Text = "";
            // 
            // deserializedTextBox
            // 
            this.deserializedTextBox.Font = new System.Drawing.Font("Alegreya SC", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deserializedTextBox.Location = new System.Drawing.Point(383, 63);
            this.deserializedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deserializedTextBox.Name = "deserializedTextBox";
            this.deserializedTextBox.ReadOnly = true;
            this.deserializedTextBox.Size = new System.Drawing.Size(360, 483);
            this.deserializedTextBox.TabIndex = 1;
            this.deserializedTextBox.Text = "";
            // 
            // actionMenu
            // 
            this.actionMenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.actionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFileButton,
            this.deserializeButton});
            this.actionMenu.Location = new System.Drawing.Point(0, 0);
            this.actionMenu.Name = "actionMenu";
            this.actionMenu.Size = new System.Drawing.Size(759, 32);
            this.actionMenu.TabIndex = 5;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(123, 28);
            this.chooseFileButton.Text = "Выбрать файл";
            // 
            // deserializeButton
            // 
            this.deserializeButton.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(150, 28);
            this.deserializeButton.Text = "Десериализовать";
            // 
            // SLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(759, 561);
            this.Controls.Add(deserializedLabel);
            this.Controls.Add(XMLFileLabel);
            this.Controls.Add(this.XMLFileTextBox);
            this.Controls.Add(this.deserializedTextBox);
            this.Controls.Add(this.actionMenu);
            this.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.actionMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SLView";
            this.Text = "Deserializer";
            this.actionMenu.ResumeLayout(false);
            this.actionMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox XMLFileTextBox;
        private System.Windows.Forms.RichTextBox deserializedTextBox;
        private System.Windows.Forms.MenuStrip actionMenu;
        private System.Windows.Forms.ToolStripMenuItem chooseFileButton;
        private System.Windows.Forms.ToolStripMenuItem deserializeButton;
    }
}

