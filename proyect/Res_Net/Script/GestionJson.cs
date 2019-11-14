using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Res_Net.Script
{
    class GestionJson
    {
        static public List<SueloJson> suelosListJson = new List<SueloJson>();
        static public List<SueloJson> sueloTestJson = new List<SueloJson>();
        static public List<MesasJson> mesasJson = new List<MesasJson>();
        static public List<AdornoJson> adornosJsonList = new List<AdornoJson>();


        public static void CreateJsons() {
            if (!File.Exists("Pisos.json")) {
                File.Create("Pisos.json");
            }
           if (!File.Exists("mesas.json")) {
                File.Create("mesas.json");
            }
            if (!File.Exists("productos.json"))
            {
                File.Create("productos.json");
            }
            if (!File.Exists("adornos.json"))
            {
                File.Create("adornos.json");

            }
            if (!File.Exists("PisosSimulacion.json"))
            {
                File.Create("PisosSimulacion.json");
            }
            if (!File.Exists("mesasSimulacion.json"))
            {
                File.Create("mesasSimulacion.json");
            }
            if (!File.Exists("AdornosSimulacion.json"))
            {
                File.Create("AdornosSimulacion.json");
            }
        }
        public static void GuardarPlanosJson(){
            CreateJsons();
            string jsonString = JsonConvert.SerializeObject(suelosListJson,Formatting.Indented);
            File.WriteAllText("Pisos.json",jsonString);        
        }
        public static void GuardarPlanosJsonSimulacion()
        {
            CreateJsons();
            string jsonString = JsonConvert.SerializeObject(suelosListJson, Formatting.Indented);
            File.WriteAllText("PisosSimulacion.json", jsonString);
        }
        public static void CargarPisoSimulacionJson()
        {
            string pathJson = File.ReadAllText("PisosSimulacion.json");
            List<SueloJson> b = JsonConvert.DeserializeObject<List<SueloJson>>(pathJson);
            sueloTestJson = b;
        }
        public static void GuardarMesasSimulacion()
        {
            CreateJsons();
            string jsonString = JsonConvert.SerializeObject(mesasJson, Formatting.Indented);
            File.WriteAllText("mesasSimulacion.json", jsonString);
        }
        public static void CargarMesasSimulacionJson()
        {
            string pathJson = File.ReadAllText("mesasSimulacion.json");
            List<MesasJson> b = JsonConvert.DeserializeObject<List<MesasJson>>(pathJson);
            mesasJson = b;
        }
        public static void GuardarAdornosSimulacion()
        {
            CreateJsons();
            string jsonString = JsonConvert.SerializeObject(adornosJsonList, Formatting.Indented);
            File.WriteAllText("AdornosSimulacion.json", jsonString);
        }
        public static void CargarAdornosSimulacion()
        {
            string pathJson = File.ReadAllText("AdornosSimulacion.json");
            List<AdornoJson> b = JsonConvert.DeserializeObject<List<AdornoJson>>(pathJson);
            adornosJsonList = b;
        }

        public static void GuardarMesas() {
            CreateJsons();
            string jsonString = JsonConvert.SerializeObject(mesasJson, Formatting.Indented);
            File.WriteAllText("mesas.json", jsonString);
        }
        public static void GuardarAdornos()
        {
            CreateJsons();
            string jsonString = JsonConvert.SerializeObject(adornosJsonList, Formatting.Indented);
            File.WriteAllText("adornos.json", jsonString);
        }
        public static void GuardarProductos()
        {
            CreateJsons();
            string jsonString = JsonConvert.SerializeObject(DatosEstaticos.productosList, Formatting.Indented);
            File.WriteAllText("productos.json", jsonString);
        }
        public static void CargarProductos()
        {
            string pathJson = File.ReadAllText("productos.json");
            List<Productos> b = JsonConvert.DeserializeObject<List<Productos>>(pathJson);
            DatosEstaticos.productosList = b;
        }

        public static void CargarMesasJson()
        {
            string pathJson = File.ReadAllText("mesas.json");
            List<MesasJson> b = JsonConvert.DeserializeObject<List<MesasJson>>(pathJson);
            mesasJson = b;
        }
        public static void CargarAdornos()
        {
            string pathJson = File.ReadAllText("adornos.json");
            List<AdornoJson> b = JsonConvert.DeserializeObject<List<AdornoJson>>(pathJson);
            adornosJsonList = b;
        }
        public static void CargarPlanosJson() {
            string pathJson = File.ReadAllText("Pisos.json");
            List <SueloJson> b = JsonConvert.DeserializeObject<List <SueloJson>>(pathJson);
            sueloTestJson = b;
        }
    }
}
