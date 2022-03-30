
namespace Cesar_Cypher_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.CypherKeyInput = new System.Windows.Forms.TextBox();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.InputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputLabel.Location = new System.Drawing.Point(12, 46);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(68, 29);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.HeaderPanel.Controls.Add(this.Title);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(807, 43);
            this.HeaderPanel.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(12, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(213, 18);
            this.Title.TabIndex = 0;
            this.Title.Text = "Klye\'s Cesar Cypher Translator";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(17, 78);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(771, 135);
            this.InputBox.TabIndex = 2;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 481);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(807, 40);
            this.FooterPanel.TabIndex = 2;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputLabel.Location = new System.Drawing.Point(12, 267);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(88, 29);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(17, 299);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(771, 135);
            this.OutputBox.TabIndex = 4;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CopyButton.Location = new System.Drawing.Point(679, 440);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(109, 32);
            this.CopyButton.TabIndex = 0;
            this.CopyButton.Text = "Copy Output";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EncodeButton.Location = new System.Drawing.Point(564, 257);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(109, 32);
            this.EncodeButton.TabIndex = 5;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = false;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DecodeButton.Location = new System.Drawing.Point(679, 257);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(109, 32);
            this.DecodeButton.TabIndex = 6;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = false;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // CypherKeyInput
            // 
            this.CypherKeyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CypherKeyInput.Location = new System.Drawing.Point(243, 258);
            this.CypherKeyInput.Name = "CypherKeyInput";
            this.CypherKeyInput.Size = new System.Drawing.Size(315, 30);
            this.CypherKeyInput.TabIndex = 7;
            this.CypherKeyInput.Text = "Enter Cypher Key";
            this.CypherKeyInput.TextChanged += new System.EventHandler(this.CypherKeyInput_TextChanged);
            this.CypherKeyInput.Enter += new System.EventHandler(this.CypherKeyInput_Enter);
            this.CypherKeyInput.Leave += new System.EventHandler(this.CypherKeyInput_Exit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(807, 521);
            this.Controls.Add(this.CypherKeyInput);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.InputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CesarCypherTranslator";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.TextBox CypherKeyInput;
    }
}

