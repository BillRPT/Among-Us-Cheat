using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_AmongUs
{
    public partial class Form1 : Form
    {
        //Déclarer
        private Memory.Mem uneMemoire;
        private SpeedHack unspeedHack;
        private Vision uneVision;
        private Impostor unImpostor;
        private Engineer engineer;

        private Thread ventCooldownThread;
        private bool antiVentCooldown = false;

        private Thread noventTimeThread;
        private bool antiVentTime = false;

        private Thread nocoldownVanish;
        private bool anticoldownVanish = false;

        private Thread infinitevanishTime;
        private bool infiniteVanish;

        private Thread infiniteshifterTime;
        private bool infiniteShifter;

        private Thread coldownshifterTime;
        private bool coldownShifter;

        public Form1()
        {

            //Instancier une memoire
            uneMemoire = new Memory.Mem();


            if (uneMemoire.OpenProcess("Among Us"))
            {
                InitializeComponent();
                //instancier les différentes class qu'on utilisera
                unspeedHack = new SpeedHack(uneMemoire);
                uneVision = new Vision(uneMemoire);
                unImpostor = new Impostor(uneMemoire);
                engineer = new Engineer(uneMemoire);
            }
            else
            {
                MessageBox.Show("Open Among Us.exe");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.label2.Text = this.trackBar2.Value.ToString();

            // Juste écrire la nouvelle vitesse, avec 4 offset ici (pas très stable)
            this.unspeedHack.changeSpeed(this.trackBar2.Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                unImpostor.changekillColdown();
            }
            else
            {
                unImpostor.normalkillColdown();
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.label5.Text = this.trackBar3.Value.ToString();
            uneVision.changecrewmateVision(this.trackBar3.Value);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            this.label7.Text = this.trackBar4.Value.ToString();
            uneVision.changementimposteurVision(this.trackBar4.Value);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                antiVentCooldown = true;
                ventCooldownThread = new Thread(() =>
                {
                    while (antiVentCooldown)
                    {
                        try
                        {
                            engineer.noventColdown();
                        }
                        catch
                        {

                        }
                        Thread.Sleep(50); 
                    }
                });
                ventCooldownThread.IsBackground = true;
                ventCooldownThread.Start();
            }
            else
            {
                antiVentCooldown = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                //Mettre sur true
                antiVentTime = true;
                noventTimeThread = new Thread(() =>
                {
                    //Le run tant que la case n'est pas décocher
                    while (antiVentTime)
                    {
                        try
                        {
                            engineer.noventTime(); 
                        }
                        catch
                        {

                        }
                        Thread.Sleep(50);
                    }
                });
                noventTimeThread.IsBackground = true;
                noventTimeThread.Start();
            }
            else
            {
                //si la case est décocher le mettre a false
                antiVentTime = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                //Mettre sur true
                anticoldownVanish = true;
                nocoldownVanish = new Thread(() =>
                {
                    //Le run tant que la case n'est pas décocher
                    while (anticoldownVanish)
                    {
                        try
                        {
                            unImpostor.nocoldownVanish();
                        }
                        catch
                        {

                        }
                        Thread.Sleep(50);
                    }
                });
                nocoldownVanish.IsBackground = true;
                nocoldownVanish.Start();
            }
            else
            {
                anticoldownVanish = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                //Mettre sur true
                infiniteVanish = true;
                infinitevanishTime = new Thread(() =>
                {
                    //Le run tant que la case n'est pas décocher
                    while (infiniteVanish)
                    {
                        try
                        {
                            unImpostor.infinitevanishTime();
                        }
                        catch
                        {

                        }
                        Thread.Sleep(50);
                    }
                });
                infinitevanishTime.IsBackground = true;
                infinitevanishTime.Start();
            }
            else
            {
                infiniteVanish = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                infiniteShifter = true;
                infiniteshifterTime = new Thread(() =>
                {
                    while (infiniteShifter)
                    {
                        try
                        {
                            unImpostor.infiniteshifterTime();
                        }
                        catch
                        {

                        }
                        //Petite pause pour pas surcharger
                        Thread.Sleep(50);
                    }
                });
                infiniteshifterTime.IsBackground = true;
                infiniteshifterTime.Start();
            }
            else
            {
                infiniteShifter = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox7.Checked)
            {
                coldownShifter = true;
                coldownshifterTime = new Thread(() =>
                {
                    while (coldownShifter)
                    {
                        try
                        {
                            unImpostor.nocoldownShifter();
                        }
                        catch
                        {

                        }
                        Thread.Sleep(50);
                    }
                });
                coldownshifterTime.IsBackground = true;
                coldownshifterTime.Start();
            }
            else
            {
                coldownShifter = false;
            }
        }
    }
}
