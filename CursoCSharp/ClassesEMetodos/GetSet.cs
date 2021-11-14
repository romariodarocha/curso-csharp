﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public  Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {

        }

        //Aplicação de Get para fazer a leitura do atributo privado Marca
        public string GetMarca()
        {
            return Marca;
        }

        //Aplicação de Set para alterar a Marca
        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        //Aplicação de Get para fazer a leitura do atributo privado Modelo
        public string GetModelo()
        {
            return Modelo;
        }

        //Aplicação de Set para alterar o Modelo
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        //Aplicação de Get para fazer a leitura do atributo privado Cilindrada
        public int GetCilindrada()
        {
            return Cilindrada;
        }

        //Aplicação de Set para alterar a Cilindrada
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            //Outra forma de alterar os valores e imprimir:
            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }
}
