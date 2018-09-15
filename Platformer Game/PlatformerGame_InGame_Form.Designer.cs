namespace Platformer_Game
{
    partial class PlatformerGame_InGame_Form
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
            this.components = new System.ComponentModel.Container();
            this.Ground_PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player_PictureBox = new System.Windows.Forms.PictureBox();
            this.Game_Update_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground_PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground_PictureBox1
            // 
            this.Ground_PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ground_PictureBox1.Location = new System.Drawing.Point(-8, 418);
            this.Ground_PictureBox1.Name = "Ground_PictureBox1";
            this.Ground_PictureBox1.Size = new System.Drawing.Size(816, 39);
            this.Ground_PictureBox1.TabIndex = 0;
            this.Ground_PictureBox1.TabStop = false;
            // 
            // Player_PictureBox
            // 
            this.Player_PictureBox.AccessibleName = "Player";
            this.Player_PictureBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Player_PictureBox.Location = new System.Drawing.Point(336, 219);
            this.Player_PictureBox.Name = "Player_PictureBox";
            this.Player_PictureBox.Size = new System.Drawing.Size(36, 103);
            this.Player_PictureBox.TabIndex = 1;
            this.Player_PictureBox.TabStop = false;
            // 
            // Game_Update_Timer
            // 
            this.Game_Update_Timer.Interval = 30;
            this.Game_Update_Timer.Tick += new System.EventHandler(this.Game_Update_Timer_Tick);
            // 
            // PlatformerGame_InGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player_PictureBox);
            this.Controls.Add(this.Ground_PictureBox1);
            this.Name = "PlatformerGame_InGame_Form";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerMovement_KeysDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayerMovement_KeysUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground_PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground_PictureBox1;
        public System.Windows.Forms.PictureBox Player_PictureBox;
        private System.Windows.Forms.Timer Game_Update_Timer;
    }
}

