using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_2
{

    public partial class Form1 : Form
    {
        private string gameScore = string.Empty;    

        public string Score
        {
            get { return gameScore; }
            set { gameScore = value; }
        }


        private bool hasCollided = false;  // 충돌 여부를 추적하는 변수
        private Timer collisionResetTimer;  // 충돌 후 reset 타이머
        public Form1()
        {
            InitializeComponent(); //폼 초기화함
            this.KeyPreview = true;//폼이 키 이벤트를 받을수 있도록 설정
            // 충돌 타이머 초기화
            collisionResetTimer = new Timer();
            collisionResetTimer.Interval = 1000;  // 1초 후 hasCollided를 reset
            collisionResetTimer.Tick += CollisionResetTimer_Tick; //메서드 호출

        }

        int carSpeed = 1; //자동차 스피드
        int collectedgas = 0; // 기름
        int score = 0; //게임 점수
        int health = 100; //차량 체력 (100에서 시작)
        int collisionCount = 0; //차량 충돌 횟수
        int difficultyTimer = 0; //난이도 증가시키는 타이머

        public string GetScoreAsString() //점수를 문자열로 반환함
        {

            return "Score:" + score.ToString();
        }

        void UpdateHealthBar() //체력이 0 이하일때 게임 오버, 체력 남으면 체력 바를 갱신
        {
            // 체력 0 이하일 때 처리
            if (health <= 0)
            {
                progressBar_health.Value = 0; // 체력바를 0으로 설정
                progressBar_health.ForeColor = Color.White; // 체력바 색을 흰색으로 변경
                label_gameover.Visible = true;
                button_restart.Visible = true;
                timer1.Enabled = false; // 게임 정지

                // 게임 오버 메시지
                MessageBox.Show("Game Over!\nFinal Score: " + GetScoreAsString(), "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 체력이 0보다 클 때는 체력바 갱신
                progressBar_health.Value = health;
                progressBar_health.ForeColor = Color.Green; // 체력바 색은 초록으로 유지
            }
        }

        void gasCollection() //기름 수를 갱신하는 코드
        {
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_gas1.Bounds))
            {
                collectedgas++;
                score += 10;
                label_gas.Text = "GAS " + collectedgas.ToString();
                label_score.Text = GetScoreAsString();

                z = r.Next(0, 200); //기름을 먹으면 다시 기름이 새로운 랜덤한 지점에서 생성
                pictureBox_gas1.Location = new Point(z, 0);
            }

            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_gas2.Bounds))
            {
                collectedgas++;
                score += 10;
                label_gas.Text = "GAS " + collectedgas.ToString();
                label_score.Text = GetScoreAsString();

                z = r.Next(100, 300);
                pictureBox_gas2.Location = new Point(z, 0);
            }

            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_gas3.Bounds))
            {
                collectedgas++;
                score += 10;
                label_gas.Text = "GAS " + collectedgas.ToString();
                label_score.Text = GetScoreAsString();

                z = r.Next(200, 400);
                pictureBox_gas3.Location = new Point(z, 0);
            }
        }


        void gameover() // 차량 충돌시 게임오버 코딩
        {
            // 차량과 장애물이 충돌했을 때
            if ((pictureBox_Car.Bounds.IntersectsWith(pictureBox_bluecar.Bounds) ||
                 pictureBox_Car.Bounds.IntersectsWith(pictureBox_bluecar2.Bounds) ||
                 pictureBox_Car.Bounds.IntersectsWith(pictureBox_electrocar.Bounds)))
            {
                // 충돌이 발생하고 아직 충돌이 처리되지 않았다면
                if (!hasCollided) // 충돌이 아직 처리되지 않았다면
                {
                    collisionCount++; // 충돌 횟수 증가
                    health -= 20; // 충돌 시 체력 20 감소
                    UpdateHealthBar(); // 체력바 업데이트
                    hasCollided = true; // 충돌 처리 완료 표시

                    // 충돌 후 일정 시간 동안 더 이상 충돌을 처리하지 않도록 타이머 시작
                    collisionResetTimer.Start();
                }
            }

            // 충돌 횟수가 3에 도달하면 게임 오버
            if (collisionCount >= 3 || health <= 0)  // 체력이 0 이하가 되거나 충돌 횟수가 3번일 경우
            {
                // 게임 오버 직전에 점수 갱신 (필요한 경우에만 점수 갱신 로직을 넣어주세요)
                Score = score.ToString();  // 실제 점수를 gameScore에 할당
                label_score.Text = "Score: " + gameScore; // UI에서 점수를 갱신

                progressBar_health.Value = 0; // 체력바를 0으로 설정
                progressBar_health.ForeColor = Color.White; // 체력바 색을 흰색으로 변경
                label_gameover.Visible = true; // 게임 오버 라벨 보이기
                button_restart.Visible = true; // 다시 시작 버튼 보이기
                timer1.Enabled = false; // 타이머 비활성화

                // 게임 오버 메시지
                MessageBox.Show("Game Over!\nFinal Score: " + GetScoreAsString(), "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CollisionResetTimer_Tick(object sender, EventArgs e)// 충돌 처리 타이머
        {
            // 타이머가 tick되면 충돌 플래그를 false로 리셋
            hasCollided = false;
            collisionResetTimer.Stop();  // 타이머 중지
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carSpeed);
            blueCar(carSpeed);
            electroCar(3);
            gameover();
            gas(carSpeed);
            gasCollection();
            increaseDifficulty();


        }

        void gas(int speed) // 기름 내려오는 위치
        {
            if (pictureBox_gas1.Top >= 500)
            {
                z = r.Next(0, 200);
                pictureBox_gas1.Location = new Point(z, 0);
            }
            else
            {
                pictureBox_gas1.Top += speed;
            }

            if (pictureBox_gas2.Top >= 500)
            {
                z = r.Next(100, 300);
                pictureBox_gas2.Location = new Point(z, 0);
            }
            else
            {
                pictureBox_gas2.Top += speed;
            }

            if (pictureBox_gas3.Top >= 500)
            {
                z = r.Next(200, 400);
                pictureBox_gas3.Location = new Point(z, 0);
            }
            else
            {
                pictureBox_gas3.Top += speed;
            }
        }

        Random r = new Random(); //위에서 내려오는 자동차들의 위치가 랜덤하게 나오는 코딩
        int x, y, z;

        void blueCar(int speed)  //파란차 위치
        {
            if (pictureBox_bluecar.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_bluecar.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_bluecar.Top += speed;
            }

            if (pictureBox_bluecar2.Top >= 500)
            {
                x = r.Next(200, 400);
                pictureBox_bluecar2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_bluecar2.Top += speed;
            }
        }

        void electroCar(int speed) // 전기차 위치
        {
            if (pictureBox_electrocar.Top >= 500)
            {
                y = r.Next(0, 300);
                pictureBox_electrocar.Location = new Point(y, 0);
            }
            else
            {
                pictureBox_electrocar.Top += carSpeed;
            }
        }

        void moveline(int speed)//배경 도로 움직이는 코딩
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }

        private void button_restart_Click(object sender, EventArgs e) //다시 시작버튼 클릭시
        {
            Restart();
        }

        private void Restart() // 게임 초기화(자동차 위치, 기름, 속도)
        {
            carSpeed = 1; // 게임 시작시 속도 1로 초기화
            collectedgas = 0;
            label_gas.Text = "GAS 0";
            label_score.Text = "Score: " + GetScoreAsString();
            progressBar_health.Value = 100; // 체력 초기화
            progressBar_health.ForeColor = Color.Green;
            progressBar_health.Style = ProgressBarStyle.Continuous;
            score = 0;
            health = 100; // 체력 초기화
            collisionCount = 0; // 충돌횟수 초기화
            label_gameover.Visible = false;
            button_restart.Visible = false;

            // 내 자동차 위치 초기화
            pictureBox_Car.Location = new Point(200, 400);

            // 기름 위치 초기화
            pictureBox_gas1.Location = new Point(r.Next(0, 200), 0);
            pictureBox_gas2.Location = new Point(r.Next(100, 300), 0);
            pictureBox_gas3.Location = new Point(r.Next(200, 400), 0);

            // 장애물 위치 초기화
            pictureBox_bluecar.Location = new Point(r.Next(0, 200), -100);
            pictureBox_bluecar2.Location = new Point(r.Next(200, 400), -100);
            pictureBox_electrocar.Location = new Point(r.Next(0, 300), -100);

            timer1.Enabled = true;
            difficultyTimer = 0;

        }

        private void increaseDifficulty()
        {
            difficultyTimer++;
            if (difficultyTimer % 300 == 0)
            {
                if (carSpeed < 15)
                {
                    carSpeed++; // 속도 증가
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // 자동차를 좌,우로 움직이게 하는 코딩과 도로 벽 밖으로 나가지 않게하는 코딩
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_Car.Left > 0)
                    pictureBox_Car.Left += -15;  //왼쪽 이동
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox_Car.Right < 500 - pictureBox_Car.Width / 2)
                    pictureBox_Car.Left += 15; // 오른쪽 이동
            }

            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 15)
                {
                    carSpeed++; // 속도 증가
                }

                if (e.KeyCode == Keys.Down)
                {
                    if (carSpeed > 0)
                    {
                        carSpeed--; // 속도 감소
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_gameover.Visible = false; // 게임 오버 메시지 처음에는 숨김
            button_restart.Visible = false; // 다시 시작 버튼을 숨김
            progressBar_health.Maximum = 100;
            progressBar_health.Value = health;
            progressBar_health.ForeColor = Color.Green; //피 색깔
            progressBar_health.Style = ProgressBarStyle.Continuous;
        }
    }
}