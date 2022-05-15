
namespace PlayerView
{
    partial class GameView
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
            this.Label2048 = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.highScoreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label2048
            // 
            this.Label2048.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2048.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2048.Location = new System.Drawing.Point(0, 0);
            this.Label2048.Name = "Label2048";
            this.Label2048.Size = new System.Drawing.Size(1244, 89);
            this.Label2048.TabIndex = 0;
            this.Label2048.Text = "2048\r\n";
            this.Label2048.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.gamePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.gamePanel.ColumnCount = 4;
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.gamePanel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gamePanel.Location = new System.Drawing.Point(317, 116);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.RowCount = 4;
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gamePanel.Size = new System.Drawing.Size(588, 543);
            this.gamePanel.TabIndex = 1;
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(805, 30);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(275, 55);
            this.highScoreLabel.TabIndex = 2;
            this.highScoreLabel.Text = "High Score:";
            // 
            // highScoreTextBox
            // 
            this.highScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreTextBox.Location = new System.Drawing.Point(1086, 28);
            this.highScoreTextBox.Name = "highScoreTextBox";
            this.highScoreTextBox.Size = new System.Drawing.Size(145, 61);
            this.highScoreTextBox.TabIndex = 3;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 738);
            this.Controls.Add(this.highScoreTextBox);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.Label2048);
            this.Name = "GameView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label2048;
        private System.Windows.Forms.TableLayoutPanel gamePanel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.TextBox highScoreTextBox;
    }
}

