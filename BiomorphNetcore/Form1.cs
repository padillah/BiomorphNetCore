using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BiomorphNetcore
{
    public partial class Form1 : Form
    {
        List<BiomorphImage> pictureBoxes;

        public Form1()
        {
            InitializeComponent();

            pictureBoxes = new List<BiomorphImage>(9);

            // Need a new Biomorph
            Biomorph rootBiomorph = BiomorphFactory.generateRandomCandidate();

            List<Biomorph> biomes = new List<Biomorph>();


            for (int i = 0; i < BiomorphFactory.GENE_COUNT; i++)
            {
                BiomorphImage newImage = new BiomorphImage()
                { BackColor = Color.AliceBlue, ForeColor = Color.Black, Dock = DockStyle.Fill };
                newImage.Click += NewImage_Click;

                pictureBoxes.Add(newImage);
                biomes.Add(rootBiomorph.Clone());
            }

            tableLayoutPanel1.Controls.Add(pictureBoxes[0], 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBoxes[1], 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBoxes[2], 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBoxes[3], 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBoxes[4], 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBoxes[5], 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBoxes[6], 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBoxes[7], 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBoxes[8], 2, 2);

            biomes = BiomorphFactory.MutatePopulation(biomes);

            for (int index = 0; index < pictureBoxes.Count; index++)
            {
                pictureBoxes[index].draw(biomes[index]);
            }
        }

        private void NewImage_Click(object? sender, EventArgs e)
        {
            BiomorphImage? currentImage = sender as BiomorphImage;
            if (currentImage != null)
            {
                List<Biomorph> biomes = new List<Biomorph>();
                var currentBiomorph = currentImage.Biomorph;

                for (int i = 0; i < BiomorphFactory.GENE_COUNT; i++)
                {
                    biomes.Add(currentBiomorph.Clone());
                }

                biomes = BiomorphFactory.MutatePopulation(biomes);

                for (int index = 0; index < pictureBoxes.Count; index++)
                {
                    pictureBoxes[index].draw(biomes[index]);
                }
            }
        }
    }
}