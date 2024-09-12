using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Serie_III
{
    public static class ClassCouncil
    {

        public static void SchoolMeans(string input, string output)
        {

                // Lecture du CSV 
            

            using (var reader = new StreamReader(@input))
            {
                //Creation des listes pour recuperer les données
                List<string> Nom = new List<string>();
                List<string> Matiere = new List<string>();
                List<float> Note = new List<float>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    Nom.Add(values[0]);
                    Matiere.Add(values[1]);
                    //On convertit directement les notes en float
                    Note.Add(float.Parse(values[2]));
                }
                // Récupération des valeurs distinctes dans matieres
                List<string> MatDis = new List<string>();
                foreach (string line in Matiere)
                {
                    if (!MatDis.Contains(line))
                    {
                        MatDis.Add(line);
                    }
                }
                List<string> MatMoy = new List<string>();
                List<float> NoteMoy = new List<float>();
                // Récupération des notes pour chaque matières
                foreach (string line in MatDis)
                    {
                    List<float> Moyenne = new List<float>();
                    int cpt = 0;
                    for (int i = 0; i < Note.Count; i++)
                    {
                        if (Matiere[i] == line)
                        {
                            Moyenne.Add(Note[i]);
                            cpt += 1;
                        }

                    }
                    float moy = 0;
                    foreach (float v in Moyenne) moy += v;
                    moy = moy / cpt;
                    MatMoy.Add(line);
                    NoteMoy.Add(moy);


                    }
                using (StreamWriter writer = new StreamWriter(output))
                {
                    for (int i = 0; i < MatMoy.Count; i++)
                    {
                        writer.WriteLine(MatMoy[i] + ";" + NoteMoy[i]);
                    }
                }

            }
            
        }
    }
}
