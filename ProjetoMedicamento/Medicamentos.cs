using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMedicamento
{
    class Medicamentos
    {
        #region ATRIBUTOS
        private List<Medicamento> listaMedicamentos;
        private Boolean existe;
        #endregion

        #region PROPRIEDADES
        public Boolean Existe
        {
            get { return this.existe; }
            set { existe = value; }
        }

        public List<Medicamento> ListaMedicamentos
        {
            get { return this.listaMedicamentos; }
        }

        #endregion

        #region CONSTRUTORES
        public Medicamentos()
        {
            this.listaMedicamentos = new List<Medicamento>();
        }
        #endregion

        #region METODOS FUNCIONAIS
        public void adicionar(Medicamento medicamento)
        {
            ListaMedicamentos.Add(medicamento);
        }//ADICIONAR

        public Boolean deletar(Medicamento medicamento)
        {
            Boolean deletado = false;

            Lote lotinho = new Lote();

            foreach(Medicamento medicamentinho in listaMedicamentos)
            {
                if(lotinho.Qtde == 0)
                {
                    ListaMedicamentos.Remove(medicamento);
                    deletado = true;
                }
            }
            return deletado;
        }//DELETAR

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento resultMedic = new Medicamento();

            foreach(Medicamento medic in listaMedicamentos)
            {
                if (medic.Equals(medicamento))
                {
                    resultMedic = medic;
                    existe = true;
                }
            }
            return resultMedic;
        }
        #endregion
    }//CLASS
}//NAMESPACE
