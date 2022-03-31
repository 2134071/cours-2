using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cours_2
{// ajout du 2e message
    public partial class Form1 : Form
    {
        List<string> listeDeMots = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_trouverMot_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dictDistanceRendu = new Dictionary<string, int>();
            string motEntree = textBox_mot.Text;

            //lettre manquante
            foreach (string mot in listeDeMots)
            {
                string copieMotEntree = motEntree;
                int distanceMot = 0;
                foreach (char lettre in mot)
                {
                    int positionLettre = motEntree.IndexOf(lettre);
                    if (positionLettre != -1)
                    {
                        copieMotEntree.Remove(positionLettre, 1);
                    }
                    else
                    {
                        distanceMot++;
                    }
                }

                dictDistanceRendu.Add(mot, distanceMot);
            }
            foreach (KeyValuePair<string, int> motDistance in dictDistanceRendu)
            {
                System.Diagnostics.Trace.WriteLine(motDistance.Key + " : "  + motDistance.Value);
            }
            //lettre en trop
            foreach (string mot in listeDeMots)
            {
                string copieMotEntree = motEntree;
                int distanceMot = 0;
                foreach (char lettre in motEntree)
                {
                    int positionLettre = copieMotEntree.IndexOf(lettre);
                    if (positionLettre != -1)
                    {
                        copieMotEntree.Remove(positionLettre, 1);
                    }
                    else
                    {
                        distanceMot++;
                    }
                }
            dictDistanceRendu[mot] = dictDistanceRendu[mot] + distanceMot;
            }
            foreach (KeyValuePair<string, int> motDistance in dictDistanceRendu)
            {
                System.Diagnostics.Trace.WriteLine(motDistance.Key + " : " + motDistance.Value);
            }
            KeyValuePair<string, int> meilleurMot = dictDistanceRendu.OrderBy(clefvaleur => clefvaleur.Value).First();
            MessageBox.Show("La meilleur valeur est:" + meilleurMot.Key );
            //lettre mal placée


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listeDeMots.Add("mouchoir");
            listeDeMots.Add("mouche");
            listeDeMots.Add("moche");
            listeDeMots.Add("poche");
            listeDeMots.Add("croche");
            listeDeMots.Add("proche");
            listeDeMots.Add("roche");
            listeDeMots.Add("moucher");
            listeDeMots.Add("moudre");
            listeDeMots.Add("poudre");
            listeDeMots.Add("pour");
        }
    }
}
