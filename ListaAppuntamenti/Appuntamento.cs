using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Appuntamento
    {

        private static DateTime dataOraAttuale = DateTime.Now;
        private string nome;
        private string localitaAppuntamento;
        private DateTime dataTime;

        public Appuntamento()
        {
        }
        public Appuntamento(string nome, string localitaAppuntamento, DateTime dataTime)
        {
            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
            this.dataTime = dataTime;
            
            

            if(dataTime < dataOraAttuale)
            {
                throw new ArgumentOutOfRangeException("dataTime", "Mi dispiace non puoi andare indietro nel tempo");
            }
        }

        

        public void setDataTime(DateTime dataTimePassata)
        {
            dataTime = dataTimePassata;
            if (dataTime < dataOraAttuale)
            {
                throw new ArgumentOutOfRangeException("dataTime", "Mi dispiace non puoi andare indietro nel tempo");
                
                return;
            }
        }


        public string getNome()
        {
            return nome;
        }

        public string getLocalitaAppuntamento()
        {
            return localitaAppuntamento;
        }


        public void setNome(string nome)
        {
            this.nome = nome;       
        }


        public void setLocalitaAppuntamento(string localitaAppuntamento)
        {
            this.localitaAppuntamento = localitaAppuntamento;
        }


        public void StampaOggetto()
        {
            Console.WriteLine("----LA TUA AGENDA---- \n");
            Console.WriteLine("Nome della persona con cui hai l'appuntamento: " + this.nome);
            Console.WriteLine("Localita del tuo appuntamento: " + this.localitaAppuntamento);
            Console.WriteLine("data e orario del tuo appuntamento: " + this.dataTime);
            Console.WriteLine();    
        }











    }




}
