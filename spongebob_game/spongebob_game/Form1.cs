using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spongebob_game
{
    public partial class Form : System.Windows.Forms.Form
    {
        int points = 0;
        bool GoLeft, GoRight;
        int Speed = 20;
        const int SpongebobTop = 210;
        const int SpongebobMaxTop = SpongebobTop - 180;
        const int ObjectSpeed = 10;
        Random randNum;

        List<PictureBox> Jellys = new List<PictureBox>();
        List<PictureBox> planks = new List<PictureBox>();

        public Form()
        {
            InitializeComponent();
            randNum = new Random(this.Width - spongebob.Left); // יצירת מדוזות ופלקטונים במיקום רנדומלי
            for (int i = 0; i < 3; i++)
            {
                CreateJellyfish();
                Createplankton();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.L)
            {
                GoLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.R)
            {
                GoRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.L)
            {
                GoLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.R)
            {
                GoRight = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pb_health.Value <= 0) // סיום משחק שהבריאות שווה לאפס 
            {
                timer.Stop();
                GameOver();
                return;
            }
            if (planks.Count < 3)
            {
                int newPlanks = randNum.Next(0, 3 - planks.Count + 1);
                if (newPlanks > 0)
                    Createplankton();
            }
            if (Jellys.Count < 3)
            {
                int newJellys = randNum.Next(0, 5 - Jellys.Count + 1);
                if (newJellys > 0)
                    CreateJellyfish();
            }
            if (GoLeft == true && spongebob.Left > 0) // הגדרת תנועה ימינה שמאלה לבובספוג
            {
                spongebob.Left -= Speed;
            }


            if (GoRight == true && spongebob.Left + spongebob.Width < this.ClientSize.Width)
            {
                spongebob.Left += Speed;
            }


            lbl_points.Text = "points: " + points; // עדכון נקודות

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox jelly && (string)jelly.Tag == "jellys") // אם בובספוג נתקל במדוזה
                {
                    bool hit = spongebob.Bounds.IntersectsWith(x.Bounds);
                    if (hit || jelly.Top >= this.Height)
                    {
                        this.Controls.Remove(jelly);
                        Jellys.Remove(jelly);
                        jelly.Dispose();
                        if (hit && pb_health.Value != 0)
                            pb_health.Value -= 20;
                    }
                    else
                        x.Top = Math.Min(this.Height, x.Top + randNum.Next(5, ObjectSpeed));
                }

                if (x is PictureBox plankton && (string)plankton.Tag == "plankton") // אם בובספוג נתקל בפלנקטון
                {
                    bool hit = spongebob.Bounds.IntersectsWith(plankton.Bounds);
                    if (hit || plankton.Top >= this.Height)
                    {
                        this.Controls.Remove(plankton);
                        planks.Remove(plankton);
                        plankton.Dispose();
                        if (hit)
                            points += 10;
                    }
                    else
                        x.Top = Math.Min(this.Height, x.Top + randNum.Next(5, ObjectSpeed));
                }
            }
        }

        private void CreateJellyfish() // פונקציה ליצירת אובייקט מדוזה 
        {
            PictureBox jelly = new PictureBox();
            jelly.BackColor = System.Drawing.Color.Transparent;
            jelly.Image = global::spongebob_game.Properties.Resources.jellyfish;
            jelly.Top = 0;
            jelly.Left = randNum.Next(0, this.Width);
            jelly.Name = "jelly1";
            jelly.Size = new System.Drawing.Size(50, 58);
            jelly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            jelly.TabIndex = 11;
            jelly.TabStop = false;
            jelly.Tag = "jellys";

            Jellys.Add(jelly);
            this.Controls.Add(jelly);
            jelly.BringToFront();
        }

        private void Createplankton() // פונקציה ליצירת אובייקט פלקטון 
        {
            PictureBox plank = new PictureBox();
            plank.BackColor = System.Drawing.Color.Transparent;
            plank.Image = global::spongebob_game.Properties.Resources.plankton;
            plank.Top = 0;
            plank.Left = randNum.Next(0, this.Width);
            plank.Name = "plankton";
            plank.Size = new System.Drawing.Size(50, 58);
            plank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            plank.TabIndex = 14;
            plank.TabStop = false;
            plank.Tag = "plankton";

            planks.Add(plank);
            this.Controls.Add(plank);
        }

        private void RestartGame()//פונקצית אתחול משחק
        {
            //מחיקת אובייקטים מהמשחק הקודם 
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && ((string)X.Tag == "jellys" || (string)X.Tag == "plankton"))
                {
                    this.Controls.Remove(X);
                    ((PictureBox)X).Dispose();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                CreateJellyfish();
                Createplankton();
            }

            spongebob.Location = new System.Drawing.Point(1, SpongebobTop); // מיקום בובספוג מחדש

            // אתחול משתנים
            points = 0;
            pb_health.Value = 100;
            GoLeft = false;
            GoRight = false;

            timer.Start();
        } 

        private void pb_health_MouseHover(object sender, EventArgs e) // שינוי תצוגת עכבר על הפקד
        {
            pb_health.Cursor = Cursors.Hand;
        }

        private void pb_health_MouseClick(object sender, MouseEventArgs e) // שינוי תצוגה של הפקד בלחיצת עכבר 
        {
            pb_health.Style = ProgressBarStyle.Continuous;
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e) // אופציות לשינוי רקע המשחק בקומבו בוקס
        {
            string txt;
            txt = cbo.Text;
            if(txt == "flowers background")
                Form.ActiveForm.BackgroundImage = global::spongebob_game.Properties.Resources.flowers_background;
            if (txt == "krusty krab background")
                Form.ActiveForm.BackgroundImage = global::spongebob_game.Properties.Resources.krusty_krab_background;
            if (txt == "nigboorhood background")
                Form.ActiveForm.BackgroundImage = global::spongebob_game.Properties.Resources.nigboorhood_background;
        }

        private void GameOver()
        {
            MessageBox.Show("Game over! \nbetter luck next time...");
            RestartGame();
        } // הודעה למשתמש שנגמר המשחק ושימוש בפונקצית האתחול
    }
}
