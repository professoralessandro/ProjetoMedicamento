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
        #endregion

        #region PROPRIEDADES
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
            foreach(Medicamento medicamentinho in listaMedicamentos)
            {
                if(medicamento.Id.Equals(0))
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
                }
            }
            return resultMedic;
        }
        #endregion
    }//CLASS
}//NAMESPACE
