using System;
using System.Collections.Generic;
using Task_Horas.Entities;

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>
        {
            new Aluno("Ana", 2023, 1200, "ETEC Técnico"),
            new Aluno("Bruno Arikawa", 2024, 1300, "ETEC AMS"),
            new Aluno("Davi Waitman", 2024, 1250, "ETEC AMS"),
            new Aluno("Emanuel", 2023, 1100, "ETEC Técnico")
        };

        Console.WriteLine("Lista de Alunos \n");
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"Curso: {aluno.Curso} | Nome: {aluno.Nome} | Ano Matrícula: {aluno.AnoMatricula} | Horas Curso: {aluno.HorasCurso} | Horas Obrigatórias: {aluno.HorasObrigatorias}");
        }

        Console.WriteLine("\nAlunos com obrigatoriedade de 200 horas");
        foreach (Aluno aluno in alunos)
        {
            if (aluno.HorasObrigatorias == 200)
            {
                Console.WriteLine($"Nome: {aluno.Nome} | Curso: {aluno.Curso}");
            }
        }
    }
}
