using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_yapilari_ödev
{
    public partial class Form1 : Form
    {
        public Dugum h1=null; //1.kuyruğun başını tutar
        public Dugum h2=null;
        public Dugum h3= null;

        public class Proses
        {
            public int prosesNo; // proses türü p1,p2,p3
            public int prosesDeger; //proses değeri 0,1,2,3,4,5
            public string prosesAdi;
            public Proses(int prosesDeger, int prosesNo)
            {
                this.prosesNo = prosesNo;
                this.prosesDeger = prosesDeger;
                this.prosesAdi = "P" + prosesNo + "-" + prosesDeger;
            }
            public string prosesYazdir()
            {
                return prosesAdi;
            }
        }
        static void yazdir(ListBox listbox,int prosesNo,Dugum head)
        {
            Dugum temp = head;
            listbox.Items.Clear();
            while(temp != null)
            {
                listbox.Items.Add(temp.data.prosesAdi);
                temp = temp.next;
            }
        }
        public class Dugum
        {
            public Proses data;
            public Dugum next;
            public Dugum(Proses data)
            {
                next = null;
                this.data = data;
            }
        }
        public class queues
        {
            public Dugum head;
            public Dugum tail;
            public queues()
            {
                head = null;
                tail = null;
            }
        }
        Random random = new Random();
        public void enqueue(int prosesNo,ref Dugum head)
        {
            int prosesDeger = random.Next(0, 6);
            Proses p = new Proses(prosesDeger, prosesNo);
            Dugum yeni = new Dugum(p);
            if (head == null)
            {
                head = yeni;
            }
            else
            {
               Dugum temp=head;
               while(temp.next != null)
               {
                    temp=temp.next;
               }
                temp.next = yeni;
            }
        }
        public Proses dequeue(ref Dugum head)
        {
            if(head == null)
            {
                Console.WriteLine("boş kuyruk eleman çıkarılmaz");
                return null;
            }
            else
            {
                Proses silinecek = head.data;
                head = head.next;
                return silinecek;
            }
        }
        public class stack
        {
            public Dugum top;
            public stack()
            {
                top = null;
            }
            public void push(Proses data)
            {
                Dugum yeni = new Dugum(data);
                if (top == null)
                {
                    top = yeni;
                }
                else
                {
                    yeni.next = top;
                    top = yeni;
                }
            }
            public Proses pop()
            {
                Proses silinecek;
                if (top == null)
                {
                    Console.WriteLine("boş stack eleman çıkarılamaz");
                    return null;
                }
                else
                {
                    silinecek = top.data;
                    top = top.next;
                }
                return silinecek;
            }
        }
    public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) {  }
        private void groupBox3_Enter(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {  }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) { }

        queues q1 = new queues();
        private void button1_Click(object sender, EventArgs e)
        {
            timer4.Interval = 1000; // CPU işlemlerinin hızı
            timer4.Start();
            //işlemci başlat butonu
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer4.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
          
            stack yigin1 = new stack();
            stack yigin2 = new stack();
            stack yigin3 = new stack();

            listBox4.Items.Clear();

            // Proses1 seçiliyse kuyruğundan çıkarıp ve yığına ekler
            if (checkBox1.Checked)
            {
                Proses p;
                while ((p = dequeue(ref h1)) != null)
                {
                    yigin1.push(p);
                    listBox4.Items.Add(p.prosesAdi);
                }
            }
            // Proses2 seçiliyse kuyruğundan çıkarıp ve yığına ekler
            if (checkBox2.Checked)
            {
                Proses p;
                while ((p = dequeue(ref h2)) != null)
                {
                    yigin2.push(p);
                    listBox4.Items.Add(p.prosesAdi);
                }
            }
            // Proses3 seçiliyse kuyruğundan çıkarıp ve yığına ekler
            if (checkBox3.Checked)
            {
                Proses p;
                while ((p = dequeue(ref h3)) != null)
                {
                    yigin3.push(p);
                    listBox4.Items.Add(p.prosesAdi);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int sure = trackBar1.Value * 100;
            if (sure < 200)
            {
                sure = 2000;
            }
            timer1.Interval = sure;
        }
         private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int sure=trackBar2.Value*100;
            if(sure<200)
            {
                sure=2000;
            }
            timer2.Interval = sure;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int sure = trackBar3.Value * 100;
            if (sure < 200)
            {
                sure = 2000;
            }
            timer3.Interval = sure;
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            int sure = trackBar4.Value * 100;
            if (sure < 200)
            {
                sure = 2000;
            }
            timer4.Interval = sure;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enqueue(1,ref h1);
            yazdir(listBox1, 1, h1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            enqueue(2, ref h2);
            yazdir(listBox2,2, h2);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            enqueue(3,ref h3);
            yazdir(listBox3,3, h3);
        }
        List<Proses> siralanmis = new List<Proses>();
        private void timer4_Tick(object sender, EventArgs e)
        {
            Proses p1 = dequeue(ref h1);
            Proses p2 = dequeue(ref h2);
            Proses p3 = dequeue(ref h3);

            List<Proses> list = new List<Proses>();

            if (p1 != null)
            {
                list.Add(p1);
            }
            if (p2 != null)
            {
                list.Add(p2);
            }
            if (p3 != null)
            {
                list.Add(p3);
            }

            //BÜYÜKTEN KÜÇÜĞE SIRALAMA 
            while (list.Count > 0)
            {
                int maxProsesDeger = -1;
                Proses enBuyuk = null;

                foreach (Proses p in list)
                {
                    if (p.prosesDeger > maxProsesDeger)
                    {
                        maxProsesDeger = p.prosesDeger;
                        enBuyuk = p;
                    }
                }
                siralanmis.Add(enBuyuk);
                list.Remove(enBuyuk);
            }
            // işlemci Kuyruğa ekleme 
            foreach (Proses p in siralanmis)
            {
                Dugum yeni = new Dugum(p);

                if (q1.head == null)
                {
                    q1.head = yeni;
                    q1.tail = yeni;
                    continue;
                }

                // Başa ekleme
                if (p.prosesDeger > q1.head.data.prosesDeger)
                {
                    yeni.next = q1.head;
                    q1.head = yeni;
                    continue;
                }

                // Araya ekleme (büyükten küçüğe doğru)
                Dugum temp2 = q1.head;
                while (temp2.next != null &&
                       temp2.next.data.prosesDeger >= p.prosesDeger)
                {
                    temp2 = temp2.next;
                }

                yeni.next = temp2.next;
                temp2.next = yeni;

                if (yeni.next == null) //sona eklersem günceller
                {
                    q1.tail = yeni;
                }
            }
          
            listBox5.Items.Clear(); // ListBox5 temizler
            Dugum temp = q1.head;
            while (temp != null)
            {
                listBox5.Items.Add(temp.data.prosesAdi);
                temp = temp.next;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval =500;
            timer1.Start();
            timer2.Interval = 400;
            timer2.Start();
            timer3.Interval = 500;
            timer3.Start();
        }  
    }
}
