using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMedicamento
{
    class Lote
    {
        #region ATRIBUTOS
        private Int32 id;
        private Int32 qtde;
        private DateTime venc;
        #endregion

        #region PROPRIEDADES
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        public Int32 Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
        public DateTime Venc

        {
            get { return venc; }
            set { venc = value; }
        }
        #endregion

        #region CONSTRUTORES
        public Lote(Int32 id, Int32 qtde, DateTime venc)
        {
            this.id = id;
            this.qtde = qtde;
            this.venc = venc;
        }

        public Lote() : this(0, 0, System.DateTime.MinValue)
        {
        }
        #endregion

        #region SOBRESSCRITAS

        #endregion

        #region METODOS FUNCIONAIS
        public String toString()
        {
            return "id: " + this.id + " - quantidade: " + this.qtde + " - vencimento: " + this.venc.ToShortDateString();
        }
        #endregion
    }//CLASS
}//NAMESPACE
