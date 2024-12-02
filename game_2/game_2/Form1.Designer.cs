namespace game_2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Car = new System.Windows.Forms.PictureBox();
            this.pictureBox_bluecar = new System.Windows.Forms.PictureBox();
            this.pictureBox_bluecar2 = new System.Windows.Forms.PictureBox();
            this.label_gameover = new System.Windows.Forms.Label();
            this.pictureBox_electrocar = new System.Windows.Forms.PictureBox();
            this.pictureBox_gas1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_gas3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_gas2 = new System.Windows.Forms.PictureBox();
            this.label_gas = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.label_score = new System.Windows.Forms.Label();
            this.progressBar_health = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bluecar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bluecar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_electrocar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gas2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(251, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(251, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 113);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(251, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 113);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(251, 501);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 82);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 648);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(515, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(14, 648);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_Car
            // 
            this.pictureBox_Car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Car.Image")));
            this.pictureBox_Car.Location = new System.Drawing.Point(81, 477);
            this.pictureBox_Car.Name = "pictureBox_Car";
            this.pictureBox_Car.Size = new System.Drawing.Size(67, 106);
            this.pictureBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Car.TabIndex = 6;
            this.pictureBox_Car.TabStop = false;
            // 
            // pictureBox_bluecar
            // 
            this.pictureBox_bluecar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bluecar.Image")));
            this.pictureBox_bluecar.Location = new System.Drawing.Point(43, 101);
            this.pictureBox_bluecar.Name = "pictureBox_bluecar";
            this.pictureBox_bluecar.Size = new System.Drawing.Size(66, 113);
            this.pictureBox_bluecar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bluecar.TabIndex = 7;
            this.pictureBox_bluecar.TabStop = false;
            // 
            // pictureBox_bluecar2
            // 
            this.pictureBox_bluecar2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bluecar2.Image")));
            this.pictureBox_bluecar2.Location = new System.Drawing.Point(419, 44);
            this.pictureBox_bluecar2.Name = "pictureBox_bluecar2";
            this.pictureBox_bluecar2.Size = new System.Drawing.Size(66, 113);
            this.pictureBox_bluecar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bluecar2.TabIndex = 8;
            this.pictureBox_bluecar2.TabStop = false;
            // 
            // label_gameover
            // 
            this.label_gameover.AutoSize = true;
            this.label_gameover.BackColor = System.Drawing.Color.Gray;
            this.label_gameover.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gameover.ForeColor = System.Drawing.Color.Red;
            this.label_gameover.Location = new System.Drawing.Point(83, 288);
            this.label_gameover.Name = "label_gameover";
            this.label_gameover.Size = new System.Drawing.Size(356, 81);
            this.label_gameover.TabIndex = 9;
            this.label_gameover.Text = "Game Over";
            // 
            // pictureBox_electrocar
            // 
            this.pictureBox_electrocar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_electrocar.Image")));
            this.pictureBox_electrocar.Location = new System.Drawing.Point(305, 187);
            this.pictureBox_electrocar.Name = "pictureBox_electrocar";
            this.pictureBox_electrocar.Size = new System.Drawing.Size(68, 113);
            this.pictureBox_electrocar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_electrocar.TabIndex = 10;
            this.pictureBox_electrocar.TabStop = false;
            // 
            // pictureBox_gas1
            // 
            this.pictureBox_gas1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gas1.Image")));
            this.pictureBox_gas1.Location = new System.Drawing.Point(170, 176);
            this.pictureBox_gas1.Name = "pictureBox_gas1";
            this.pictureBox_gas1.Size = new System.Drawing.Size(51, 61);
            this.pictureBox_gas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_gas1.TabIndex = 11;
            this.pictureBox_gas1.TabStop = false;
            // 
            // pictureBox_gas3
            // 
            this.pictureBox_gas3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gas3.Image")));
            this.pictureBox_gas3.Location = new System.Drawing.Point(419, 441);
            this.pictureBox_gas3.Name = "pictureBox_gas3";
            this.pictureBox_gas3.Size = new System.Drawing.Size(51, 61);
            this.pictureBox_gas3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_gas3.TabIndex = 12;
            this.pictureBox_gas3.TabStop = false;
            // 
            // pictureBox_gas2
            // 
            this.pictureBox_gas2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gas2.Image")));
            this.pictureBox_gas2.Location = new System.Drawing.Point(282, 14);
            this.pictureBox_gas2.Name = "pictureBox_gas2";
            this.pictureBox_gas2.Size = new System.Drawing.Size(51, 61);
            this.pictureBox_gas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_gas2.TabIndex = 13;
            this.pictureBox_gas2.TabStop = false;
            // 
            // label_gas
            // 
            this.label_gas.AutoSize = true;
            this.label_gas.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gas.Location = new System.Drawing.Point(11, 27);
            this.label_gas.Name = "label_gas";
            this.label_gas.Size = new System.Drawing.Size(71, 25);
            this.label_gas.TabIndex = 14;
            this.label_gas.Text = "GAS=0";
            // 
            // button_restart
            // 
            this.button_restart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_restart.Location = new System.Drawing.Point(180, 372);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(153, 90);
            this.button_restart.TabIndex = 15;
            this.button_restart.Text = "Restart?";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_score.Location = new System.Drawing.Point(12, 52);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(86, 23);
            this.label_score.TabIndex = 16;
            this.label_score.Text = "SCORE=0";
            // 
            // progressBar_health
            // 
            this.progressBar_health.BackColor = System.Drawing.Color.White;
            this.progressBar_health.ForeColor = System.Drawing.Color.White;
            this.progressBar_health.Location = new System.Drawing.Point(15, 0);
            this.progressBar_health.Name = "progressBar_health";
            this.progressBar_health.Size = new System.Drawing.Size(206, 30);
            this.progressBar_health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_health.TabIndex = 17;
            this.progressBar_health.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(528, 650);
            this.Controls.Add(this.progressBar_health);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.label_gas);
            this.Controls.Add(this.pictureBox_gas2);
            this.Controls.Add(this.pictureBox_gas3);
            this.Controls.Add(this.pictureBox_gas1);
            this.Controls.Add(this.pictureBox_electrocar);
            this.Controls.Add(this.label_gameover);
            this.Controls.Add(this.pictureBox_bluecar2);
            this.Controls.Add(this.pictureBox_bluecar);
            this.Controls.Add(this.pictureBox_Car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bluecar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bluecar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_electrocar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_Car;
        private System.Windows.Forms.PictureBox pictureBox_bluecar;
        private System.Windows.Forms.PictureBox pictureBox_bluecar2;
        private System.Windows.Forms.Label label_gameover;
        private System.Windows.Forms.PictureBox pictureBox_electrocar;
        private System.Windows.Forms.PictureBox pictureBox_gas1;
        private System.Windows.Forms.PictureBox pictureBox_gas3;
        private System.Windows.Forms.PictureBox pictureBox_gas2;
        private System.Windows.Forms.Label label_gas;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.ProgressBar progressBar_health;
    }
}

