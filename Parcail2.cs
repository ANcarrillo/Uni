using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcail2
{
    class Cola
    {
        class Nodo 
        {
            public string NombreEm;
            public string ApellidoEm;
            public int Id;
         
            public double HorasDeTrabajo;

            public Nodo sig;
        }
    
        private Nodo raiz,fondo;
    
        public Cola() 
        {
            raiz=null;
            fondo=null;
        }
    
        public bool Vacia ()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Insertar (string NombreEm, string ApellidoEm,int Id, double HorasDeTrabajo)
        {
            Nodo nuevo;
            nuevo = new Nodo ();
            nuevo.NombreEm = NombreEm;
             nuevo.ApellidoEm = ApellidoEm;
              nuevo.Id =  Id;
               nuevo.HorasDeTrabajo = HorasDeTrabajo;
            nuevo.sig = null;
            if (Vacia ()) 
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }
        }

        public void Imprimir() 
        {
            Nodo reco=raiz;
            while (reco!=null) 
            {
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("NOMBRE: "+reco.NombreEm );
                Console.WriteLine("APELLIDO: "+ reco.ApellidoEm );
                Console.WriteLine("IDENTIFICACION: "+ reco.Id );
                Console.WriteLine("HORA DE TRABAJO DIARIOS: "+ reco.HorasDeTrabajo);
                 Console.WriteLine("_______________________________________________");
                reco=reco.sig;
            }
            Console.WriteLine();
        }
        public void PagosQuince()
        {
            Nodo pa=raiz;
            while (pa!=null){
                 Console.WriteLine("_______________________________________________");
                    

                  Console.WriteLine("PAGO QUINCENAL DEL TRABAJADOR: "+ pa.NombreEm);
                  Console.WriteLine("IDENTIFICACION DEL TRABAJADOR: "+ pa.Id);
                  Console.WriteLine("PAGO QUINCENAL: "+(((pa.HorasDeTrabajo*15) * 3700)));
                  Console.WriteLine("DESCUESTO DE SALUD: "+(((pa.HorasDeTrabajo*15) * 3700)*0.4));
                  Console.WriteLine("PAGO TOTAL: "+(((pa.HorasDeTrabajo*15) * 3700)-(((pa.HorasDeTrabajo*15) * 3700)*0.4)));

                 Console.WriteLine("_______________________________________________");
                pa=pa.sig;

            }
            


        }
        
        static void Main(string[] args)
        {
            Cola cola1=new Cola();
            cola1.Insertar("ANDRES","CARRILLO",12345,7);
             cola1.Insertar("LUARA","RAMIREZ",1245,6);
            cola1.Imprimir();
            cola1.PagosQuince();
            
        }
    }
}