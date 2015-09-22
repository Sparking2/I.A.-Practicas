namespace Dijkstra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.combo_origen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_destino = new System.Windows.Forms.ComboBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad de Origen:";
            // 
            // combo_origen
            // 
            this.combo_origen.FormattingEnabled = true;
            this.combo_origen.Items.AddRange(new object[] {
             "",
            "Aarhus",
            "Lanzarote",
            "Agadir",
            "M laga",
            "Alghero",
            "Alicante",
            "Ancona",
            "Athens",
            "Barcelona-El Prat",
            "Brindisi",
            "Brest",
            "Mil n B‚rgamo",
            "Birmingham",
            "Biarritz",
            "Billund",
            "Bolonia",
            "Burdeos",
            "Bournemouth",
            "Bremen",
            "Bari",
            "Berno",
            "Bristol",
            "Bruselas Zaventem",
            "Basel",
            "Bratislava",
            "Budapest",
            "Par¡s Beauvais",
            "Brive",
            "Bydgoszcz",
            "B‚ziers",
            "Cagliari",
            "Carcassonne",
            "Clermont Ferrand",
            "Corf£",
            "Colonia",
            "Chania",
            "Roma Ciampino",
            "Comiso",
            "Bruselas Charleroi",
            "Crotone",
            "Catania",
            "Cuneo",
            "Cardiff",
            "Dole",
            "Dinard",
            "Deauville-Normand¡a",
            "Dortmund",
            "Dubl¡n",
            "St tienne",
            "Edimburgo",
            "Cefalonia",
            "Bergerac",
            "Eindhoven",
            "East Midlands",
            "Essaouira",
            "Faro",
            "Rome Fiumicino",
            "Fez",
            "Baden-Baden",
            "Memmingen (Munich West)",
            "Mnster",
            "Nimes",
            "Figari",
            "Fuerteventura",
            "Gdansk",
            "Grenoble",
            "G‚nova",
            "Patras-Araxos",
            "Girona",
            "Haugesund",
            "Frankfurt Hahn",
            "Ibiza",
            "Kos",
            "Kerry",
            "Kalamata",
            "Cracovia",
            "Katowice",
            "Kaunas",
            "Leeds Bradford",
            "Lodz",
            "Lourdes",
            "Derry",
            "Almer¡a",
            "Leipzig",
            "Londres Gatwick",
            "Limoges",
            "Lille",
            "Lisbon",
            "Linz",
            "Gran Canaria",
            "Liverpool",
            "Lappeenranta",
            "La Rochelle",
            "Londres Luton",
            "Lublin",
            "Madrid",
            "Menorca",
            "Manchester",
            "Murcia",
            "Malta",
            "Montpellier",
            "Marsella",
            "Maastricht",
            "Niza",
            "Newcastle",
            "Nador",
            "Knock Oeste de Irlanda",
            "Dusseldorf Weeze",
            "Nantes",
            "Nuremberg",
            "Estocolmo Skavsta",
            "Oporto",
            "Cork",
            "Osijek",
            "Ostrava",
            "Bucharest (Otopeni)",
            "Oujda",
            "Plovdiv",
            "Perugia",
            "Pafos",
            "Perpi¤ n",
            "Glasgow Prestwick",
            "Poitiers",
            "Parma",
            "Palma",
            "Palermo",
            "Poznan",
            "Prague",
            "Pisa",
            "Pescara",
            "Pula",
            "Marrakech",
            "Rabat",
            "Rodez",
            "Reus",
            "Rhodes",
            "Riga",
            "Rijeka",
            "Oslo Rygge",
            "Rzeszow",
            "Santiago",
            "Santander",
            "Skelleftea",
            "Tesal¢nica",
            "Shannon",
            "Londres Stansted",
            "Lamezia",
            "Sevilla",
            "Strasbourg",
            "Berl¡n Sch”nefeld",
            "Salzburgo",
            "Szczecin",
            "Tenerife Norte",
            "Tenerife Sur",
            "Podgorica",
            "Tallin",
            "Toulon",
            "Tampere",
            "T nger",
            "Trapani",
            "Oslo Torp",
            "Tur¡n",
            "Trieste",
            "Venecia Treviso",
            "Tours",
            "Valencia",
            "Valladolid",
            "Vilnius",
            "Verona",
            "Estocolmo Vasteras",
            "V„xj”",
            "Varsovia Modlin",
            "Wroclaw",
            "Par¡s Vatry",
            "Jerez",
            "Zadar",
            "Zaragoza",
            "Zakynthos",
            "Glasgow International",
            "Copenhague",
            "Hamburg",
            "Gotemburgo Landvetter",
            "Ponta Delgada",
            "Lorient",
            "Santorini National",
            "Stuttgart",
            "Castell¢n",
            "Eilat (Ovda)"});
            this.combo_origen.Location = new System.Drawing.Point(385, 74);
            this.combo_origen.Name = "combo_origen";
            this.combo_origen.Size = new System.Drawing.Size(121, 21);
            this.combo_origen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad de Destino:";
            // 
            // combo_destino
            // 
            this.combo_destino.FormattingEnabled = true;
            this.combo_destino.Items.AddRange(new object[] {
            "",
            "Aarhus",
            "Lanzarote",
            "Agadir",
            "M laga",
            "Alghero",
            "Alicante",
            "Ancona",
            "Athens",
            "Barcelona-El Prat",
            "Brindisi",
            "Brest",
            "Mil n B‚rgamo",
            "Birmingham",
            "Biarritz",
            "Billund",
            "Bolonia",
            "Burdeos",
            "Bournemouth",
            "Bremen",
            "Bari",
            "Berno",
            "Bristol",
            "Bruselas Zaventem",
            "Basel",
            "Bratislava",
            "Budapest",
            "Par¡s Beauvais",
            "Brive",
            "Bydgoszcz",
            "B‚ziers",
            "Cagliari",
            "Carcassonne",
            "Clermont Ferrand",
            "Corf£",
            "Colonia",
            "Chania",
            "Roma Ciampino",
            "Comiso",
            "Bruselas Charleroi",
            "Crotone",
            "Catania",
            "Cuneo",
            "Cardiff",
            "Dole",
            "Dinard",
            "Deauville-Normand¡a",
            "Dortmund",
            "Dubl¡n",
            "St tienne",
            "Edimburgo",
            "Cefalonia",
            "Bergerac",
            "Eindhoven",
            "East Midlands",
            "Essaouira",
            "Faro",
            "Rome Fiumicino",
            "Fez",
            "Baden-Baden",
            "Memmingen (Munich West)",
            "Mnster",
            "Nimes",
            "Figari",
            "Fuerteventura",
            "Gdansk",
            "Grenoble",
            "G‚nova",
            "Patras-Araxos",
            "Girona",
            "Haugesund",
            "Frankfurt Hahn",
            "Ibiza",
            "Kos",
            "Kerry",
            "Kalamata",
            "Cracovia",
            "Katowice",
            "Kaunas",
            "Leeds Bradford",
            "Lodz",
            "Lourdes",
            "Derry",
            "Almer¡a",
            "Leipzig",
            "Londres Gatwick",
            "Limoges",
            "Lille",
            "Lisbon",
            "Linz",
            "Gran Canaria",
            "Liverpool",
            "Lappeenranta",
            "La Rochelle",
            "Londres Luton",
            "Lublin",
            "Madrid",
            "Menorca",
            "Manchester",
            "Murcia",
            "Malta",
            "Montpellier",
            "Marsella",
            "Maastricht",
            "Niza",
            "Newcastle",
            "Nador",
            "Knock Oeste de Irlanda",
            "Dusseldorf Weeze",
            "Nantes",
            "Nuremberg",
            "Estocolmo Skavsta",
            "Oporto",
            "Cork",
            "Osijek",
            "Ostrava",
            "Bucharest (Otopeni)",
            "Oujda",
            "Plovdiv",
            "Perugia",
            "Pafos",
            "Perpi¤ n",
            "Glasgow Prestwick",
            "Poitiers",
            "Parma",
            "Palma",
            "Palermo",
            "Poznan",
            "Prague",
            "Pisa",
            "Pescara",
            "Pula",
            "Marrakech",
            "Rabat",
            "Rodez",
            "Reus",
            "Rhodes",
            "Riga",
            "Rijeka",
            "Oslo Rygge",
            "Rzeszow",
            "Santiago",
            "Santander",
            "Skelleftea",
            "Tesal¢nica",
            "Shannon",
            "Londres Stansted",
            "Lamezia",
            "Sevilla",
            "Strasbourg",
            "Berl¡n Sch”nefeld",
            "Salzburgo",
            "Szczecin",
            "Tenerife Norte",
            "Tenerife Sur",
            "Podgorica",
            "Tallin",
            "Toulon",
            "Tampere",
            "T nger",
            "Trapani",
            "Oslo Torp",
            "Tur¡n",
            "Trieste",
            "Venecia Treviso",
            "Tours",
            "Valencia",
            "Valladolid",
            "Vilnius",
            "Verona",
            "Estocolmo Vasteras",
            "V„xj”",
            "Varsovia Modlin",
            "Wroclaw",
            "Par¡s Vatry",
            "Jerez",
            "Zadar",
            "Zaragoza",
            "Zakynthos",
            "Glasgow International",
            "Copenhague",
            "Hamburg",
            "Gotemburgo Landvetter",
            "Ponta Delgada",
            "Lorient",
            "Santorini National",
            "Stuttgart",
            "Castell¢n",
            "Eilat (Ovda)"});
            this.combo_destino.Location = new System.Drawing.Point(385, 171);
            this.combo_destino.Name = "combo_destino";
            this.combo_destino.Size = new System.Drawing.Size(121, 21);
            this.combo_destino.TabIndex = 3;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(479, 226);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 23);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dijkstra.Properties.Resources._2000px_Ryanair_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(36, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.combo_destino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_origen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RYANAIR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_origen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_destino;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

