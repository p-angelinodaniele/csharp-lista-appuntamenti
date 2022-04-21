using Agenda;


List<Appuntamento> listaAppuntamenti=new List<Appuntamento>();
string nome="";
string localitaAppuntamento="";
DateTime data =new DateTime();

Console.Write("Inserisci il numero di appuntamenti che desideri ");
int counter = int.Parse(Console.ReadLine());

for(int i = 0; i < counter; i++) {

    Console.Write("Inserisci il nome dell'appuntamento: ");
    nome = Console.ReadLine();
    Console.Write("Inserisci la localita dell'appuntamento: ");
    localitaAppuntamento = Console.ReadLine();
    


    bool controlloData=false;
    while (controlloData == false)
    {
        try
        {
            Console.WriteLine();
            Console.Write("Inserisci la data con orario: ");
            data = DateTime.Parse(Console.ReadLine());
             
            


            listaAppuntamenti.Add(new Appuntamento(nome, localitaAppuntamento, data));

            controlloData = true;


        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Write(e.Message);

        }
    }
    
}

foreach (Appuntamento ogniAppuntamento in listaAppuntamenti)
{
    ogniAppuntamento.StampaOggetto();
}






   
    
    
    



    
