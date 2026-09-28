namespace AurumLab.Models
{
    public class Dashboard
    {
        public int TotalDispositivos { get; set; }
        public int TotalAtivos { get; set; }
        public int TotalEmManutencao { get; set; }
        public int TotalInoperantes { get; set; }

        //! Usuario
        public string Nome { get; set; }
        public string FotoUsuario{get;set;}

        //! Lista de agrupamento
        public List<ItemAgrupado> DispositivosPorTipo {get;set;}
        public List<LocalDispositivo> Locais {get;set;}

        
    }
}