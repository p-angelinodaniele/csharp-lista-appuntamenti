using Agenda;


List<Appuntamento> listaAppuntamenti=new List<Appuntamento>();
string nome="";
string localitaAppuntamento="";
DateTime data =new DateTime();

Console.Write("Inserisci il numero di appuntamenti che desideri: ");
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

foreach (Appuntamento tuttiGliAppuntamenti in listaAppuntamenti)
{
    tuttiGliAppuntamenti.StampaOggetto();
}



Console.Write("Vuoi cambiare qualcosa nella tua agenda? [si/no] ");
string risposta = Console.ReadLine();   

switch (risposta)
{
    case "si":
        Console.Write("Dimmi il nome di quale appuntamento vuoi cambiare: ");
        string nomeDaCambiare = Console.ReadLine();
        foreach(Appuntamento tuttiGliAppuntamenti in listaAppuntamenti)
        {
            if(nomeDaCambiare == tuttiGliAppuntamenti.getNome())
            {
                Console.Write("Inserisci il nome: ");
                string nomeCambiato = Console.ReadLine();
                tuttiGliAppuntamenti.setNome(nomeCambiato);
                Console.Write("Inserisci la localita: ");
                string localitaCambiata = Console.ReadLine();
                tuttiGliAppuntamenti.setLocalitaAppuntamento(localitaCambiata);
                
                bool controlloData = false;
                while (controlloData == false)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Inserisci la data con orario: ");
                        data = DateTime.Parse(Console.ReadLine());
                        tuttiGliAppuntamenti.setDataTime(data);




                        

                        controlloData = true;


                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.Write(e.Message);

                    }
                }

            }
        }
        break;




}



foreach (Appuntamento tuttiGliAppuntamenti in listaAppuntamenti)
{
    tuttiGliAppuntamenti.StampaOggetto();
}










