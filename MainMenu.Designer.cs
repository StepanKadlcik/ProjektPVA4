namespace Milionar_4C_Kadlcik
{
    partial class MainMenu
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
            this.newGame = new System.Windows.Forms.Button();
            this.shop = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.winnerTable = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.Navy;
            this.newGame.FlatAppearance.BorderSize = 0;
            this.newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGame.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.Color.White;
            this.newGame.Location = new System.Drawing.Point(61, 46);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(248, 64);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "Nová hra";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // shop
            // 
            this.shop.BackColor = System.Drawing.Color.Navy;
            this.shop.FlatAppearance.BorderSize = 0;
            this.shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop.ForeColor = System.Drawing.Color.White;
            this.shop.Location = new System.Drawing.Point(61, 158);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(248, 64);
            this.shop.TabIndex = 1;
            this.shop.Text = "Obchod";
            this.shop.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(61, 463);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(248, 64);
            this.exit.TabIndex = 2;
            this.exit.Text = "Odejít";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // winnerTable
            // 
            this.winnerTable.BackColor = System.Drawing.Color.Navy;
            this.winnerTable.FlatAppearance.BorderSize = 0;
            this.winnerTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winnerTable.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winnerTable.ForeColor = System.Drawing.Color.White;
            this.winnerTable.Location = new System.Drawing.Point(61, 272);
            this.winnerTable.Name = "winnerTable";
            this.winnerTable.Size = new System.Drawing.Size(248, 64);
            this.winnerTable.TabIndex = 3;
            this.winnerTable.Text = "Tabulka vítězů";
            this.winnerTable.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Milionar_4C_Kadlcik.Properties.Resources.milionar_main_logo400;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(377, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 665);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.winnerTable);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.newGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button shop;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button winnerTable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}