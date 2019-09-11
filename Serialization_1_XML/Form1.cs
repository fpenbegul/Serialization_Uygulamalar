using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization_1_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnXMLseri_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("metin.xml", FileMode.OpenOrCreate);

            string metin = "XML serialization uygulanacak olan veri!";

            //FileStream fs = new FileStream("metin.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(string));
            serializer.Serialize(fs, metin);
            fs.Close();

        }

        private void BtnXMLDeseri_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("metin.xml", FileMode.OpenOrCreate);

            XmlSerializer serializer = new XmlSerializer(typeof(string));

            string sonuc = serializer.Deserialize(fs).ToString();
            fs.Close();
            MessageBox.Show(sonuc);

        }

        private void BtnBasicSeri_Click(object sender, EventArgs e)
        {
            // sadeleştirilmiş nesneyi taşımak için kullanılır
            Kisi kisi = new Kisi();

            kisi.AdSoyad = "Duygu Yenilmez";
            kisi.Yas = 38;
            XmlWriter writer = XmlWriter.Create(Application.StartupPath + @"\\data.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Kisi));

            serializer.Serialize(writer, kisi);
            writer.Close();
        }

        private void BtnBasicDeseri_Click(object sender, EventArgs e)
        {
            // veriyi dosyadan okuma işlemi yapacak
            XmlReader reader = XmlReader.Create(Application.StartupPath + @"\data.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(Kisi));
            Kisi kisi = (Kisi)serializer.Deserialize(reader);
            reader.Close();

            MessageBox.Show(kisi.ToString());


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
