using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{                                           
    class ArtExhibition
    {
        private string title;             //створення private полів (назва виставки, організатор,дата початку,кінець,список творів)
        private string organizer;
        private DateTime startDate;
        private DateTime endDate;
        private List<string> artworks = new List<string>();

        public string Title                    //public властивості 
        {
            get { return title; }
            set { title = value; }
        }
        public string Organizer
        {
            get { return organizer; }
            set { organizer = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
        }
        public List<string> Artwork
        {
            get
            { 
                return artworks;
            }
            set
            { 
                artworks = value;
            }
        }
        public ArtExhibition()                                           //констурктор за замовчуванням 
        {
        }
        public ArtExhibition(string title, string organizer, DateTime startDate, DateTime endDate)      //конструктр за параметровний
        {
            Title = title;
            Organizer = organizer;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public ArtExhibition(ArtExhibition artExhibition)                      // конструктор копіювання                               
        {
            Title = artExhibition.Title;
            Organizer = artExhibition.Organizer;
            startDate = artExhibition.startDate;
            endDate = artExhibition.endDate;
        }
        public void AddArtwork(string artwork)
        {
            artworks.Add(artwork);
        }

        public void RemoveArtwork(string artwork)                           // видалення творів мистецтва
        {
            Artwork.Remove(artwork);
        }

        public void PrintInfo()                                           //принт
        {
            if (StartDate < EndDate) //перевірка коректності дати
            {
                    Console.WriteLine("назва виставки: " + title);
                    Console.WriteLine("органiзатор: " + organizer);
                    Console.WriteLine("дата початку: " + startDate.ToShortDateString());
                    Console.WriteLine("дата завершення: " + endDate.ToShortDateString());
                    Console.WriteLine("твори мистецтва: ");

                    for (int i = 0; i < Artwork.Count; i++)               //
                    {
                        if (Artwork[i] != null)
                        {
                            Console.WriteLine("- " + Artwork[i]);
                        }
                        else
                        {
                            Console.WriteLine("000000000000000000000");
                        }
                    }
            }
            else
            {
                Console.WriteLine("обрана некоректна дата");
            }
             
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {    
            ArtExhibition[] exhibitions2 = new ArtExhibition[2]; // 2 об'єкти виставки : 

            exhibitions2[0] = new ArtExhibition("виставка 123", "скульптор Йохан Лiберт", new DateTime(2024, 9, 20), new DateTime(2024, 9, 25));
            exhibitions2[1] = new ArtExhibition("виставка124", "художниця Ада Вонг", new DateTime(2024, 9, 20), new DateTime(2024, 9, 29));


            exhibitions2[0].AddArtwork("48239482304829038490284092840238048204803294809328490238408342908340293");  //твір мистецтва назва йохана
            exhibitions2[1].AddArtwork("JAJDLIAJDIOJAWIDHAILWJDILAWHDILAHWDLHAWLDJALWDJLAIWJDLIAWJDLIAJWDLAWJLD");  //твір мистецтва назва ада
            exhibitions2[1].AddArtwork("/**//*/*/*/*/*/*/*/*=/-*/=*/=-*=/-*=*/-=*-/=*-/*=-/*=/-*=*-*=/-*/=*/-=/");  //твір мистецтва назва ада2

            exhibitions2[0].PrintInfo();

            Console.WriteLine("\n*************************************************************************\n");
            exhibitions2[1].PrintInfo();

            Console.WriteLine("\n*************************************************************************\n");
            exhibitions2[1].RemoveArtwork("JAJDLIAJDIOJAWIDHAILWJDILAWHDILAHWDLHAWLDJALWDJLAIWJDLIAWJDLIAJWDLAWJLD");
            exhibitions2[1].PrintInfo();

            Console.ReadKey();
        }
    }
}