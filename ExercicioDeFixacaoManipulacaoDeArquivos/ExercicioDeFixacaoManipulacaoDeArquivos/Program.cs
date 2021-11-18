using ExercicioDeFixacaoManipulacaoDeArquivos.Entities;
using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioDeFixacaoManipulacaoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\duduh\AppData\Local\Temp";
            string targetPath = @"C:\Users\duduh\AppData\Local\Temp\out\summary.csv";

            try
            {
                Directory.CreateDirectory(sourcePath + "\\out");
                string[] lines = File.ReadAllLines(sourcePath + "\\produtos.csv");
                List<Produtos> produtos = new List<Produtos>();

                using (StreamReader sr = File.OpenText(sourcePath + "\\produtos.csv"))
                {
                    foreach (string line in lines)
                    {
                        string[] valores = line.Split(",");
                        Produtos produto = new Produtos(valores[0], double.Parse(valores[1], CultureInfo.InvariantCulture), int.Parse(valores[2]));
                        produtos.Add(produto);
                    }

                    using (StreamWriter sw = File.AppendText(targetPath))
                    {
                        foreach (Produtos produto in produtos)
                        {
                            sw.WriteLine(produto);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
