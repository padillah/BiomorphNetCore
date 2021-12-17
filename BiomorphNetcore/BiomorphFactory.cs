using System;
using System.Collections.Generic;

namespace BiomorphNetcore
{
    public static class BiomorphFactory
    {
        /** The total number of genes that make up a biomorph. */
        public const int GENE_COUNT = 9;
        /** The minimum permitted value for most genes. */
        public const int GENE_MIN = -5;
        /** The maximum permitted value for most genes. */
        public const int GENE_MAX = 5;
        /** The index of the gene that controls biomporph size. */
        public const int LENGTH_GENE_INDEX = 8;
        /** The minimum permitted value for the length gene. */
        public const int LENGTH_GENE_MIN = 1;
        /** The maximum permitted value for the length gene. */
        public const int LENGTH_GENE_MAX = 7;

        public static Biomorph generateRandomCandidate()
        {
            Random rand = new();
            int[] genes = new int[GENE_COUNT];

            for (int i = 0; i < GENE_COUNT - 1; i++)
            {
                // First 8 genes have values between -5 and 5.
                genes[i] = rand.Next(11) - 5;
            }
            // Last genes ha a value between 1 and 7.
            genes[LENGTH_GENE_INDEX] = rand.Next(LENGTH_GENE_MAX) + 1;

            return new Biomorph(genes);
        }

        public static List<Biomorph> MutatePopulation(Biomorph rootPopulation)
        {
            List<Biomorph> mutatedPopulation = new List<Biomorph>(GENE_COUNT);
            int mutatedGene = 0;
            int mutation = 1;
            for (int i = 0; i < GENE_COUNT; i++)
            {
                int[] genes = rootPopulation.GetGenotype();

                mutation *= -1; // Alternate between incrementing and decrementing.
                if (mutation == 1) // After gene has been both incremented and decremented, move to next one.
                {
                    mutatedGene = (mutatedGene + 1) % GENE_COUNT;
                }

                genes[mutatedGene] += mutation;
                int min = mutatedGene == LENGTH_GENE_INDEX ? LENGTH_GENE_MIN : GENE_MIN;
                int max = mutatedGene == LENGTH_GENE_INDEX ? LENGTH_GENE_MAX : GENE_MAX;
                if (genes[mutatedGene] > max)
                {
                    genes[mutatedGene] = min;
                }
                else if (genes[mutatedGene] < min)
                {
                    genes[mutatedGene] = max;
                }

                mutatedPopulation.Add(new Biomorph(genes));
            }

            return mutatedPopulation;

        }
    }
}
