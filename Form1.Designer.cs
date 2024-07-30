namespace Password_Manager_Design
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
            txBxPassword = new TextBox();
            btnReveal = new Button();
            textBox1 = new TextBox();
            btnSearch = new Button();
            listBox1 = new ListBox();
            grpBxLogin = new GroupBox();
            grBxMainContent = new GroupBox();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            loadFiletxtToolStripMenuItem = new ToolStripMenuItem();
            grpBxLogin.SuspendLayout();
            grBxMainContent.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txBxPassword
            // 
            txBxPassword.Location = new Point(23, 27);
            txBxPassword.Name = "txBxPassword";
            txBxPassword.Size = new Size(348, 23);
            txBxPassword.TabIndex = 0;
            txBxPassword.KeyDown += txBxPassword_KeyDown;
            // 
            // btnReveal
            // 
            btnReveal.Location = new Point(377, 26);
            btnReveal.Name = "btnReveal";
            btnReveal.Size = new Size(65, 23);
            btnReveal.TabIndex = 1;
            btnReveal.Text = "Reveal";
            btnReveal.UseVisualStyleBackColor = true;
            btnReveal.Click += btnReveal_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(17, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(33, 23);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(17, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(803, 364);
            listBox1.TabIndex = 5;
            // 
            // grpBxLogin
            // 
            grpBxLogin.Controls.Add(btnReveal);
            grpBxLogin.Controls.Add(txBxPassword);
            grpBxLogin.Location = new Point(939, 71);
            grpBxLogin.Name = "grpBxLogin";
            grpBxLogin.Size = new Size(466, 71);
            grpBxLogin.TabIndex = 6;
            grpBxLogin.TabStop = false;
            grpBxLogin.Text = "Login";
            // 
            // grBxMainContent
            // 
            grBxMainContent.Controls.Add(textBox1);
            grBxMainContent.Controls.Add(btnSearch);
            grBxMainContent.Controls.Add(listBox1);
            grBxMainContent.Location = new Point(12, 108);
            grBxMainContent.Name = "grBxMainContent";
            grBxMainContent.Size = new Size(857, 463);
            grBxMainContent.TabIndex = 7;
            grBxMainContent.TabStop = false;
            grBxMainContent.Text = "Password Manager";
            grBxMainContent.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1436, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFiletxtToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Visible = false;
            // 
            // loadFiletxtToolStripMenuItem
            // 
            loadFiletxtToolStripMenuItem.Name = "loadFiletxtToolStripMenuItem";
            loadFiletxtToolStripMenuItem.Size = new Size(180, 22);
            loadFiletxtToolStripMenuItem.Text = "Load File (.txt)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 663);
            Controls.Add(grBxMainContent);
            Controls.Add(grpBxLogin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            grpBxLogin.ResumeLayout(false);
            grpBxLogin.PerformLayout();
            grBxMainContent.ResumeLayout(false);
            grBxMainContent.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txBxPassword;
        private Button btnReveal;
        private TextBox textBox1;
        private Button btnSearch;
        private ListBox listBox1;
        private GroupBox grpBxLogin;
        private GroupBox grBxMainContent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem loadFiletxtToolStripMenuItem;
    }
}
