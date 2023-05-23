namespace TP4_Bis;

static class Info{
    public static List<Pais> ListaPaises = new List<Pais>();
    
    private static void IniciarLista(){
        ListaPaises.Add(new Pais("Benin","/Fotos/Bandera-Benin.png",13000000,new DateTime(1960,8,1),"Bab's Dock" ));
        ListaPaises.Add(new Pais("Argentina","/Fotos/Bandera-Argentina.png",45810000,new DateTime(1816,7,9),"Glaciar Perito Moreno" ));
        ListaPaises.Add(new Pais("Kenya","/Fotos/Bandera-Kenya.png",53010000,new DateTime(1963,12,12),"Parque nacional de Amboseli" ));
        ListaPaises.Add(new Pais("Luxemburgo","/Fotos/Bandera-Luxemburgo.png",640064,new DateTime(1839,4,19),"Castillo de Vianden" ));
        ListaPaises.Add(new Pais("Somalia","/Fotos/Bandera-Somalia.png",17070000,new DateTime(1960,7,1),"Laas Geel" ));
    }   
    public static List<Pais> ListarPaises(){
        if(ListaPaises.Count == 0) IniciarLista();
        return ListaPaises;
        
        
    }
    public static Pais DetallePais(string NombrePais){
        
        foreach (Pais PaisARecorrer in ListaPaises)
        {
            if(PaisARecorrer.Nombre == NombrePais) return PaisARecorrer;
        }
        return null;
    }

}