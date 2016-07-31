using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace arff_olusturucu
{
    public partial class Form1 : Form
    {
        string dosyaadi;
        string dosyayolu;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= DialogResult.None;
            string yazi = "";
            string dosya_yolu = @"C:\Users\Samsung\Desktop\markalar2.arff";

            string varmi;
            if (File.Exists(dosya_yolu))
            {
                varmi = "var";
            }
            else
            {
                varmi = "yok";
            }

            StreamReader oku=null;
            if (dosyaadi != "" && dosyaadi!=null)
            { 
                oku = new StreamReader(dosyayolu, Encoding.UTF8);

                oku = File.OpenText(dosyayolu);



                yazi = oku.ReadToEnd();

                MessageBox.Show(yazi);

                dialogResult = MessageBox.Show("Onay", "Az Önceki Dataları Onaylıyor musun?", MessageBoxButtons.YesNo);

            }
             if (dialogResult == DialogResult.Yes)
            {

                if (textBox2.Text == "" || dosyayolu == "")
                    MessageBox.Show("Dosya Seçmediniz ya da Dosya Adını yazmadınız.");
                else if (yazi != "" && textBox2.Text != "")
                {
                    StreamWriter sw = File.AppendText(dosya_yolu);
                    int counter = 0;
                    //  FileStream fs = new FileStream(dosya_yolu, FileMode.Append);
                 

                    //   StreamWriter Dosya = File.AppendText("C:\Users\Samsung\Desktop\metinbelgesi.txt");
                    string finalString = "";
                    List<string> kelimeler = new List<string>();
                    //APPLE
                    kelimeler.Add("apple tv remote");
                    kelimeler.Add("iphone 6 plus");
                    kelimeler.Add("ipad air 2");
                    kelimeler.Add("ipad mini 2");
                    kelimeler.Add("ipad mini 4");
                    kelimeler.Add("iphone 6s");
                    kelimeler.Add("app store");
                    kelimeler.Add("ipod touch");
                    kelimeler.Add("iphone ipad");
                    kelimeler.Add("apple watch");
                    kelimeler.Add("iphone imac");
                    kelimeler.Add("apple pencil");
                    kelimeler.Add("iphone macbook");
                    kelimeler.Add("6 plus");
                    kelimeler.Add("iphone 5s");
                    kelimeler.Add("multi touch");
                    kelimeler.Add("macbook air");
                    kelimeler.Add("macbook pro");
                    kelimeler.Add("apple music");
                    kelimeler.Add("apple watchos");
                    kelimeler.Add("apple store");
                    kelimeler.Add("mac pro");
                    kelimeler.Add("mac mini");
                    kelimeler.Add("os x");
                    kelimeler.Add("apple tv");
                    kelimeler.Add("touch surface");
                    kelimeler.Add("ios 9");
                    kelimeler.Add("ios 9,3");
                    kelimeler.Add("ipad pro");
                    kelimeler.Add("ipad air");
                    kelimeler.Add("iphone");
                    kelimeler.Add("macbook");
                    kelimeler.Add("touch");
                    kelimeler.Add("icloud");
                    kelimeler.Add("ipad");
                    kelimeler.Add("ios");
                    kelimeler.Add("apple");
                    kelimeler.Add("mac");
                    kelimeler.Add("ipod");
                    kelimeler.Add("imac");
                    kelimeler.Add("trackpad");
                    kelimeler.Add("app");
                    kelimeler.Add("store");
                    kelimeler.Add("itunes");
                    kelimeler.Add("siri");
                    kelimeler.Add("watch");
                    kelimeler.Add("tvos");
                    kelimeler.Add("boost");
                    kelimeler.Add("imessage");
                    kelimeler.Add("ibooks");
                    kelimeler.Add("retina");
                    kelimeler.Add("4K");
                    kelimeler.Add("magic");
                    kelimeler.Add("fusion drive");
                    kelimeler.Add("Safari");

                    //ASUS
                    kelimeler.Add("zenfone 2");
                    kelimeler.Add("zenfone 2 Laser");
                    kelimeler.Add("zenfone Go");
                    kelimeler.Add("zenfone Selfie");
                    kelimeler.Add("zenfone 6");
                    kelimeler.Add("zenfone 5");
                    kelimeler.Add("zenfone 4");
                    kelimeler.Add("zenfone ZE551ML 2");
                    kelimeler.Add("zenpad C 7.0");
                    kelimeler.Add("asus z170c");
                    kelimeler.Add("zenpad 8.0");
                    kelimeler.Add("asus z380c");
                    kelimeler.Add("zenfone 7");
                    kelimeler.Add("zenpad S 8.0");
                    kelimeler.Add("asus z580c");
                    kelimeler.Add("Fonepad 7");
                    kelimeler.Add("asus fe170cg");
                    kelimeler.Add("asus tf103");
                    kelimeler.Add("asus me302kl");
                    kelimeler.Add("memo pad 7");
                    kelimeler.Add("memo pad 10");
                    kelimeler.Add("asus me170c");
                    kelimeler.Add("memo pad 8");
                    kelimeler.Add("asus me181c");
                    kelimeler.Add("asus eee pad");
                    kelimeler.Add("memo pad");
                    kelimeler.Add("asus ZE551ML");
                    kelimeler.Add("asus me180a");
                    kelimeler.Add("asus me176c");
                    kelimeler.Add("me181c");
                    kelimeler.Add("me170c");
                    kelimeler.Add("me302kl");
                    kelimeler.Add("tf103");
                    kelimeler.Add("fe170cg");
                    kelimeler.Add("z580c");
                    kelimeler.Add("z380c");
                    kelimeler.Add("z170c");
                    kelimeler.Add("ZE551ML");
                    kelimeler.Add("zenfone");
                    kelimeler.Add("me180a");
                    kelimeler.Add("me176c");
                    kelimeler.Add("fonepad");
                    kelimeler.Add("me102a");
                    kelimeler.Add("zenUI");
                    kelimeler.Add("z300c");
                    kelimeler.Add("ze600kl");
                    kelimeler.Add("me173x");
                    kelimeler.Add("me175cg");
                    kelimeler.Add("me372cg");

                    //LG
                    kelimeler.Add("lg k10");
                    kelimeler.Add("lg magna");
                    kelimeler.Add("lg aka");
                    kelimeler.Add("lg g4 stylus");
                    kelimeler.Add("lg g4 beat");
                    kelimeler.Add("lg g pad");
                    kelimeler.Add("lg leon");
                    kelimeler.Add("g flex 2");
                    kelimeler.Add("lg optimus g pro");
                    kelimeler.Add("lg optimus g");
                    kelimeler.Add("lg optimus l9");
                    kelimeler.Add("lg optimus vu");
                    kelimeler.Add("lg optimus 4x hd");
                    kelimeler.Add("lg optimus l7");
                    kelimeler.Add("lg optimus l5");
                    kelimeler.Add("lg optimus l3");
                    kelimeler.Add("lg nexus 4");
                    kelimeler.Add("lg nexus 5");
                    kelimeler.Add("lg v10");
                    kelimeler.Add("lg l80");
                    kelimeler.Add("l 80");
                    kelimeler.Add("l fino");
                    kelimeler.Add("l bello");
                    kelimeler.Add("g3 beat");
                    kelimeler.Add("g2 mini");
                    kelimeler.Add("lg h542 g4");
                    kelimeler.Add("lg h525 g4c");
                    kelimeler.Add("lg h815 g4");
                    kelimeler.Add("lg g4");
                    kelimeler.Add("lg g4c");
                    kelimeler.Add("lg y50");
                    kelimeler.Add("lg g3 stylus");
                    kelimeler.Add("g3 stylus");
                    kelimeler.Add("lg optimus");
                    kelimeler.Add("lg lgv400");
                    kelimeler.Add("lgv400");
                    kelimeler.Add("lg lgv700");
                    kelimeler.Add("nexus 4");
                    kelimeler.Add("nexus 5");
                    kelimeler.Add("lgv700");
                    kelimeler.Add("lg lgv500");
                    kelimeler.Add("lgv500");
                    kelimeler.Add("lg k7");
                    kelimeler.Add("lg g5");
                    kelimeler.Add("g flex");
                    kelimeler.Add("optimus");
                    kelimeler.Add("k10");
                    kelimeler.Add("nexus");
                    kelimeler.Add("k7");
                    kelimeler.Add("v10");
                    kelimeler.Add("h542");
                    kelimeler.Add("g4");
                    kelimeler.Add("h525");
                    kelimeler.Add("g4c");
                    kelimeler.Add("h815");
                    kelimeler.Add("y50");
                    kelimeler.Add("g3");
                    kelimeler.Add("g5");
                    kelimeler.Add("h850");
                    kelimeler.Add("k430");
                    kelimeler.Add("h960");
                    kelimeler.Add("h500");
                    kelimeler.Add("h788");
                    kelimeler.Add("h735");
                    kelimeler.Add("h324");
                    kelimeler.Add("h955");
                    kelimeler.Add("d693");
                    kelimeler.Add("d290");
                    kelimeler.Add("d331");
                    kelimeler.Add("d723");
                    kelimeler.Add("d855");
                    kelimeler.Add("d610");
                    kelimeler.Add("d405");
                    kelimeler.Add("d320");
                    kelimeler.Add("d160");
                    kelimeler.Add("e450");
                    kelimeler.Add("p713");
                    kelimeler.Add("e410i");
                    kelimeler.Add("d821");
                    kelimeler.Add("d958");
                    kelimeler.Add("d682");
                    kelimeler.Add("e440");
                    kelimeler.Add("g2");
                    kelimeler.Add("d802");
                    //SAMSUNG
                    kelimeler.Add("galaxy s7 edge plus");
                    kelimeler.Add("s7 edge plus");
                    kelimeler.Add("s7 edge");
                    kelimeler.Add("galaxy s7");
                    kelimeler.Add("galaxy note 5");
                    kelimeler.Add("galaxy note edge");
                    kelimeler.Add("note edge");
                    kelimeler.Add("galaxy note 4");
                    kelimeler.Add("galaxy note 2");
                    kelimeler.Add("galaxy note 3");
                    kelimeler.Add("galaxy s6 edge");
                    kelimeler.Add("galaxy s6");
                    kelimeler.Add("galaxy s5");
                    kelimeler.Add("galaxy s4");
                    kelimeler.Add("galaxy s3");
                    kelimeler.Add("s3 mini");
                    kelimeler.Add("s4 mini");
                    kelimeler.Add("s5 mini");
                    kelimeler.Add("s3 neo");
                    kelimeler.Add("s6 edge");
                    kelimeler.Add("galaxy A7");
                    kelimeler.Add("galaxy A5");
                    kelimeler.Add("galaxy A3");
                    kelimeler.Add("galaxy A8");
                    kelimeler.Add("galaxy A7 2016");
                    kelimeler.Add("A7 2016");
                    kelimeler.Add("galaxy A5 2016");
                    kelimeler.Add("A5 2016");
                    kelimeler.Add("galaxy A3 2016");
                    kelimeler.Add("A3 2016");
                    kelimeler.Add("galaxy J1 2016");
                    kelimeler.Add("J1 2016");
                    kelimeler.Add("galaxy J1");
                    kelimeler.Add("galaxy J2");
                    kelimeler.Add("galaxy J5");
                    kelimeler.Add("galaxy J7");
                    kelimeler.Add("galaxy n920 note 5");
                    kelimeler.Add("galaxy n920");
                    kelimeler.Add("galaxy g531 grand");
                    kelimeler.Add("galaxy g531");
                    kelimeler.Add("g531 grand");
                    kelimeler.Add("galaxy a710");
                    kelimeler.Add("galaxy a310");
                    kelimeler.Add("galaxy a510");
                    kelimeler.Add("galaxy i9060 grand");
                    kelimeler.Add("galaxy i9060");
                    kelimeler.Add("i9060 grand");
                    kelimeler.Add("galaxy i9500");
                    kelimeler.Add("g355 core 2");
                    kelimeler.Add("galaxy i8200");
                    kelimeler.Add("galaxy i8150");
                    kelimeler.Add("galaxy E5");
                    kelimeler.Add("galaxy E7");
                    kelimeler.Add("galaxy Tab S2");
                    kelimeler.Add("Tab S2");
                    kelimeler.Add("galaxy Tab S");
                    kelimeler.Add("Tab S");
                    kelimeler.Add("galaxy Tab 4");
                    kelimeler.Add("Tab 4");
                    kelimeler.Add("galaxy Tab Pro");
                    kelimeler.Add("Tab Pro");
                    kelimeler.Add("galaxy Tab 3");
                    kelimeler.Add("Tab 3");
                    kelimeler.Add("galaxy Tab3 Kids");
                    kelimeler.Add("Tab3 Kids");
                    kelimeler.Add("galaxy Note Pro");
                    kelimeler.Add("galaxy Tab");
                    kelimeler.Add("Note Pro");
                    kelimeler.Add("galaxy Note 2014 Edition");
                    kelimeler.Add("Note 2014 Edition");
                    kelimeler.Add("galaxy Note");
                    kelimeler.Add("galaxy core prime");
                    kelimeler.Add("galaxy alpha");
                    kelimeler.Add("galaxy grand geo");
                    kelimeler.Add("grand neo");
                    kelimeler.Add("grand prime");
                    kelimeler.Add("note 5");
                    kelimeler.Add("note 4");
                    kelimeler.Add("note 2");
                    kelimeler.Add("note 3");
                    kelimeler.Add("note 3 neo");
                    kelimeler.Add("samsung");
                    kelimeler.Add("s7");
                    kelimeler.Add("E5");
                    kelimeler.Add("E7");
                    kelimeler.Add("s6");
                    kelimeler.Add("s5");
                    kelimeler.Add("s4");
                    kelimeler.Add("s3");
                    kelimeler.Add("A7");
                    kelimeler.Add("J1");
                    kelimeler.Add("J2");
                    kelimeler.Add("J5");
                    kelimeler.Add("J7");
                    kelimeler.Add("A5");
                    kelimeler.Add("n920");
                    kelimeler.Add("A3");
                    kelimeler.Add("A8");
                    kelimeler.Add("a710");
                    kelimeler.Add("i8150");
                    kelimeler.Add("i8200");
                    kelimeler.Add("g355");
                    kelimeler.Add("i9500");
                    kelimeler.Add("a510");
                    kelimeler.Add("a310");
                    kelimeler.Add("sm-e700f");
                    kelimeler.Add("sm-t350");
                    kelimeler.Add("sm-t550");
                    kelimeler.Add("sm-t562");
                    kelimeler.Add("sm-t560");
                    //HTC
                    kelimeler.Add("Desire 200");
                    kelimeler.Add("Desire 601");
                    kelimeler.Add("Desire 500");
                    kelimeler.Add("Desire 300");
                    kelimeler.Add("Desire 510");
                    kelimeler.Add("Desire 320");
                    kelimeler.Add("Desire 310");
                    kelimeler.Add("Desire 516");
                    kelimeler.Add("Desire 610");
                    kelimeler.Add("Desire 616");
                    kelimeler.Add("Desire 816G");
                    kelimeler.Add("Desire 620G");
                    kelimeler.Add("Desire 820G");
                    kelimeler.Add("Desire 626G");
                    kelimeler.Add("Desire 816");
                    kelimeler.Add("Desire 820");
                    kelimeler.Add("Desire 620");
                    kelimeler.Add("Desire 626");
                    kelimeler.Add("Desire EYE");
                    kelimeler.Add("Desire 728G");
                    kelimeler.Add("Desire 530");
                    kelimeler.Add("Desire 828");
                    kelimeler.Add("Desire 825");
                    kelimeler.Add("Htc 10");
                    kelimeler.Add("one A9");
                    kelimeler.Add("one m9");
                    kelimeler.Add("one m8");
                    kelimeler.Add("htc one");
                    kelimeler.Add("one mini 2");
                    kelimeler.Add("one max");
                    kelimeler.Add("one mini");
                    kelimeler.Add("htc flyer");
                    kelimeler.Add("htc");
                    kelimeler.Add("desire");

                    if (varmi == "yok")
                    {
                        sw.WriteLine("@RELATION MARKALAR");
                        for (int i = 0; i < kelimeler.Count; i++)
                        {
                            sw.WriteLine("@attribute '" + kelimeler[i] + "' {0,1}");
                        }
                        sw.WriteLine("@attribute class {apple,asus,samsung,lg,htc,sony,diger,tum}");
                        sw.WriteLine("@data");
                    }

                    string words = yazi.ToLower();
                    if (finalString != null)
                    {
                        finalString = finalString + "\n";
                    }
                    counter++;
                    int startIndex = 0;
                    int lastIndex = 0;
                    while (startIndex != -1)
                    {

                        lastIndex = words.IndexOf('.', startIndex + 1);

                        if (lastIndex == -1)
                            startIndex = lastIndex;

                        if (lastIndex != -1)
                        {
                            string sentence = words.Substring(startIndex + 1, lastIndex - startIndex - 1);
                            startIndex = lastIndex;

                            //  startIndex = words.IndexOf('.', lastIndex + 1);

                            for (int i = 0; i < kelimeler.Count; i++)
                            {

                                if (sentence.Contains(kelimeler[i].ToLower()))
                                {
                                    finalString = finalString + "1" + ",";
                                }
                                else
                                    finalString = finalString + "0" + ",";

                            }

                            finalString = finalString + textBox2.Text + "\n";
                            sw.WriteLine(finalString);
                            label1.Text = finalString;
                            finalString = "";
                            // MessageBox.Show("İşlem Bitti!");
                        }

                    }

                    sw.Close();

                    oku.Close();

                    listBox1.Items.Add(textBox2.Text);

                    label2.Text = "";
                    dosyayolu = "";
                    dosyaadi = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                textBox2.Text = "";
                label2.Text = "";
                dosyayolu = "";
                dosyaadi = "";
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Not Defteri |*.txt";
       


            if (file.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = file.FileName;
                dosyaadi = file.SafeFileName;
                label2.Text = dosyaadi;
            }
        }
    }
}

