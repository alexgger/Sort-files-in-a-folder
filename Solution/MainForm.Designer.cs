namespace FileSortedApp
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.browserBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.startsortBtn = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browserBtn
            // 
            resources.ApplyResources(this.browserBtn, "browserBtn");
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.UseVisualStyleBackColor = true;
            this.browserBtn.Click += new System.EventHandler(this.SelectFolder);
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // pathLabel
            // 
            resources.ApplyResources(this.pathLabel, "pathLabel");
            this.pathLabel.Name = "pathLabel";
            // 
            // pathBox
            // 
            resources.ApplyResources(this.pathBox, "pathBox");
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            // 
            // startsortBtn
            // 
            resources.ApplyResources(this.startsortBtn, "startsortBtn");
            this.startsortBtn.Name = "startsortBtn";
            this.startsortBtn.UseVisualStyleBackColor = true;
            this.startsortBtn.Click += new System.EventHandler(this.StartSort);
            // 
            // authorLabel
            // 
            resources.ApplyResources(this.authorLabel, "authorLabel");
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Click += new System.EventHandler(this.AuthorClick);
            // 
            // Application
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.startsortBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.browserBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Application";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browserBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button startsortBtn;
        private System.Windows.Forms.Label authorLabel;
    }
}

