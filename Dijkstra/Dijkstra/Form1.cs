using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Lista = { "Aarhus", "Lanzarote", "Agadir", "Málaga", "Alghero", "Alicante", "Ancona", "Athens", "Barcelona-El Prat", "Brindisi", "Brest", "Milán", "Bérgamo", "Birmingham", "Biarritz", "Billund", "Bolonia", "Burdeos", "Bournemouth", "Bremen", "Bari", "Berno", "Bristol", "Bruselas", "Zaventem", "Basel", "Bratislava", "Budapest", "París Beauvais", "Brive", "Bydgoszcz", "Béziers", "Cagliari", "Carcassonne", "Clermont Ferrand", "Corfú", "Colonia", "Chania", "Roma Ciampino", "Comiso", "Bruselas Charleroi", "Crotone", "Catania", "Cuneo", "Cardiff", "Dole", "Dinard", "Deauville-Normandía", "Dortmund", "Dublín", "St Étienne", "Edimburgo", "Cefalonia", "Bergerac", "Eindhoven", "East Midlands", "Essaouira", "Faro", "Rome Fiumicino", "Fez", "Baden-Baden", "Memmingen (Munich West)", "Münster", "Nimes", "Figari", "Fuerteventura", "Gdansk", "Grenoble", "Génova", "Patras-Araxos", "Girona", "Haugesund", "Frankfurt Hahn", "Ibiza", "Kos", "Kerry", "Kalamata", "Cracovia", "Katowice", "Kaunas", "Leeds Bradford", "Lodz", "Lourdes", "Derry", "Almería", "Leipzig", "Londres Gatwick", "Limoges", "Lille", "Lisbon", "Linz", "Gran Canaria", "Liverpool", "Lappeenranta", "La Rochelle", "Londres", "Luton", "Lublin", "Madrid", "Menorca", "Manchester", "Murcia", "Malta", "Montpellier", "Marsella", "Maastricht", "Niza", "Newcastle", "Nador", "Knock Oeste de Irlanda", "Dusseldorf Weeze", "Nantes", "Nuremberg", "Estocolmo Skavsta", "Oporto", "Cork", "Osijek", "Ostrava", "Bucharest (Otopeni)", "Oujda", "Plovdiv", "Perugia", "Pafos", "Perpiñán", "Glasgow Prestwick", "Poitiers", "Parma", "Palma", "Palermo", "Poznan", "Prague", "Pisa", "Pescara", "Pula", "Marrakech", "Rabat", "Rodez", "Reus", "Rhodes", "Riga", "Rijeka", "Oslo Rygge", "Rzeszow", "Santiago", "Santander", "Skelleftea", "Tesalónica", "Shannon", "Londres Stansted", "Lamezia", "Sevilla", "Strasbourg", "Berlín Schönefeld", "Salzburgo", "Szczecin", "Tenerife Norte", "Tenerife Sur", "Podgorica", "Tallin", "Toulon", "Tampere", "Tánger", "Trapani", "Oslo Torp", "Turín", "Trieste", "Venecia Treviso", "Tours", "Valencia", "Valladolid", "Vilnius", "Verona", "Estocolmo Vasteras", "Växjö", "Varsovia Modlin", "Wroclaw", "París Vatry", "Jerez", "Zadar", "Zaragoza", "Zakynthos", "Glasgow International", "Copenhague", "Hamburg", "Gotemburgo Landvetter", "Ponta Delgada", "Lorient", "Santorini National", "Stuttgart", "Castellón", "Eilat (Ovda)" };
            for (int i = 0; i <= Lista.Length - 1; i++)
            { 
                comboBox_Origen.Items.Add(Lista[i]);
                comboBox_destino.Items.Add(Lista[i]);
            }
        }
    }
}
