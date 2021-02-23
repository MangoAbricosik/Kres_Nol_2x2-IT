using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kres_Nol_IT
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      button5.Hide();
      button1.Show();
      button2.Show();
      button3.Show();
      button4.Show();

      label1.Show();

      GameStart();
    }

    int cout = 0;

    public void GameStart()
    {
      if ((button1.Text == "x") && (button4.Text == "x") || (button2.Text == "x") && (button3.Text == "x"))
      {
        label1.Text = "Ты победил!";

        button1.Hide();
        button2.Hide();
        button3.Hide();
        button4.Hide();

        return;
      }
      if ((button1.Text == "0") && (button4.Text == "0") || (button2.Text == "0") && (button3.Text == "0"))
      {
        label1.Text = "Ты проиграл!";

        button1.Hide();
        button2.Hide();
        button3.Hide();
        button4.Hide();

        return;
      }
      if ((button1.Text == "0") && (button3.Text == "0") || (button2.Text == "0") && (button3.Text == "0") || (button1.Text == "x") && (button3.Text == "x") || (button2.Text == "x") && (button4.Text == "x"))
      {
        label1.Text = "Ничья!";

        button1.Hide();
        button2.Hide();
        button3.Hide();
        button4.Hide();

        return;
      }

      if (cout == 0)
      {
        cout = 2;
      }
      else
      {
        Randomized();
      }
    }
    public void Randomized()
    {
      Random rand = new Random();

      while (true)
      {
        switch (rand.Next(1, 4))
        {
          case 1:
            if (button1.Enabled == false)
            {
              continue;
            }
            button1.Enabled = false;
            button1.BackColor = Color.Red;
            button1.Text = "0";
            cout += 2;
            break;
          case 2:
            if (button2.Enabled == false)
            {
              continue;
            }
            button2.Enabled = false;
            button2.BackColor = Color.Red;
            button2.Text = "0";
            cout += 2;
            break;
          case 3:
            if (button3.Enabled == false)
            {
              continue;
            }
            button3.Enabled = false;
            button3.BackColor = Color.Red;
            button3.Text = "0";
            cout += 2;
            break;
          case 4:
            if (button4.Enabled == false)
            {
              continue;
            }
            button4.Enabled = false;
            button4.BackColor = Color.Red;
            button4.Text = "0";
            cout += 2;
            break;
        }

        if (cout == 4)
        {
          cout = 2;
          break;
        }
        else
        {
          continue;
        }
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      button1.Hide();
      button2.Hide();
      button3.Hide();
      button4.Hide();

      label1.Text = "Ты ставишь крестики";
      label1.Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      button1.Enabled = false;
      button1.Text = "x";
      button1.BackColor = Color.Green;
      GameStart();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button2.Enabled = false;
      button2.Text = "x";
      button2.BackColor = Color.Green;
      GameStart();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button3.Enabled = false;
      button3.Text = "x";
      button3.BackColor = Color.Green;
      GameStart();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button4.Enabled = false;
      button4.Text = "x";
      button4.BackColor = Color.Green;
      GameStart();
    }
  }
}
