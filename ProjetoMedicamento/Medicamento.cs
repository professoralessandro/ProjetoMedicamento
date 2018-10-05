﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMedicamento
{
    class Medicamento
    {
        #region ATRIBUTOS
        private Int32 id;
        private String nome;
        private String laboratorio;
        private Queue<Lote> lotes;
        #endregion

        #region PROPRIEDADES
        public Queue<Lote> Lotes
        {
            get { return this.lotes; }
        }

        public Int32 Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }


        public String Laboratorio
        {
            get { return this.laboratorio; }
            set { this.laboratorio = value; }
        }
        #endregion

        #region CONSTRUTORES
        public Medicamento()
        {
            this.lotes = new Queue<Lote>();
        }

        public Medicamento(Int32 id, String nome, String laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;

        }
        #endregion

        #region SOBRESSCRITAS
        public override bool Equals(object obj)
        {
            Medicamento p = (Medicamento)obj;
            return this.id.Equals(p.id);
        }
        #endregion

        #region METODOS FUNCIONAIS

        public Int32 qtdeDisponivel()
        {
            Medicamento medic = new Medicamento(id, "1", "1");
            Int32 qtdeMedic = 0;

            Console.WriteLine("Informe qual é o ID do medicamento");
            id = Convert.ToInt32(Console.ReadLine());

            foreach (Lote lotezinho in Lotes)
            {
                if(medic.Id.Equals(medic.Id))
                {
                    qtdeMedic += lotezinho.Qtde;
                }
            }

            return qtdeMedic;
        }

        //A COMPLETAR
        public Boolean vender(Int32 qtde)
        {
            Int32 quant = 0;
            Boolean vendido = false;

            foreach(Lote lot in Lotes)
            {
               quant += Convert.ToInt32(lot.Qtde);
            }
            if(quant < qtde)
            {
                //L -= qtde;
                foreach (Lote lot in Lotes)
                {
                    lot.Qtde -= qtde;
                    if(lot.Qtde == 0)
                    {
                        Lotes.Dequeue();
                    }
                }
                vendido = true;
            }
            return vendido;
        }//VENDER

        public void comprar(Lote lote)
        {
            Lotes.Enqueue(lote);
        }

        public String toString()
        {
            return "id: " + this.id + " - nome: " + this.nome + " - laboratório: " + this.laboratorio;
        }
        #endregion
    }//CLASS
}//NAMESPACE