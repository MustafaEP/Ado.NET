using System.Data;
using System.Data.SqlClient;
using WinFormsApp1.classes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("Select * from kisi", sqlVariables.connection);
            //istedi�imiz sql komutlar�n� i�eren SqlCommand nesnesi olu�turdur.

            sqlVariables.checkConnection(sqlVariables.connection);
            //sunucuya olan ba�lant�m�z� kontrol ettik.

            SqlDataAdapter adapter = new SqlDataAdapter(commandList);
            //SqlDataAdapter, sql sorgusundan gelen verileri datatable'ye yada dataset'e doldurmay� sa�lar

            DataTable dataTable = new DataTable();
            //Bir DataTable olu�turuldu

            adapter.Fill(dataTable);
            //SqlDataAdapter'deki bilgiler datatable'ya i�lendi.

            dataGridView1.DataSource= dataTable;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into kisi (kisi_ad, kisi_soyad, kisi_sehir) values ( @pad, @psoyad, @psehir)",sqlVariables.connection);
            //tabloya kisi ekliyecek sql komudunun nesnesini olu�turduk

            
            sqlVariables.checkConnection(sqlVariables.connection);
            //sqle ba�land�k

            
            commandAdd.Parameters.AddWithValue("@pad", kisi_ad.Text);
            commandAdd.Parameters.AddWithValue("@psoyad", kisi_soyad.Text);
            commandAdd.Parameters.AddWithValue("@psehir", kisi_sehir.Text);
            //sql komudundaki parametreleri atad�k


            commandAdd.ExecuteNonQuery();
            //komudu �al��t�rd�k ve silme i�lemini ger�ekl�tirdik

            button2_Click(sender, e);
            //buttona t�klatarak sayfay� yeniletiyoruz
        }

        int selected_id;

        private void button_delete_Click(object sender, EventArgs e)
        {
            selected_id = Convert.ToInt32(delete_kisi_id.Text);
            //textboxtan ald���m�z say�y� selected_id ' ye atad�k.
            //textbox String depolar convert edilesi gerekir.

            SqlCommand commandDelete = new SqlCommand("Delete from kisi where kisi_id=@pid", sqlVariables.connection);
            //komudun oldu�u nesneyi olu�turduk

            sqlVariables.checkConnection(sqlVariables.connection);
            //sql ba�lant�s� kuruldu

            commandDelete.Parameters.AddWithValue("@pid", selected_id);
            //parametreler atand�

            commandDelete.ExecuteNonQuery();
            //kod �al��t�r�ld�

            button2_Click((object)sender, e);
            //buttona t�klatarak sayfay� yeniletiyoruz
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            selected_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["kisi_id"].Value);
            delete_kisi_id.Text = selected_id.ToString();

            yeni_kisi_id.Text = dataGridView1.CurrentRow.Cells["kisi_id"].Value.ToString();
            yeni_kisi_ad.Text = dataGridView1.CurrentRow.Cells["kisi_ad"].Value.ToString();
            yeni_kisi_soyad.Text = dataGridView1.CurrentRow.Cells["kisi_soyad"].Value.ToString();
            yeni_kisi_sehir.Text = dataGridView1.CurrentRow.Cells["kisi_sehir"].Value.ToString();




        }


        private void duzenle_button_Click(object sender, EventArgs e)
        {
            SqlCommand yeni_sqlCommand = new SqlCommand("update kisi set kisi_ad = @yeniad, kisi_soyad = @yenisoyad, kisi_sehir = @yenisehir where kisi_id = @yeniid", sqlVariables.connection);

            sqlVariables.checkConnection(sqlVariables.connection);

            yeni_sqlCommand.Parameters.AddWithValue("@yeniad", yeni_kisi_ad.Text);
            yeni_sqlCommand.Parameters.AddWithValue("@yenisoyad", yeni_kisi_soyad.Text);
            yeni_sqlCommand.Parameters.AddWithValue("@yenisehir", yeni_kisi_sehir.Text);
            yeni_sqlCommand.Parameters.AddWithValue("@yeniid", Convert.ToInt32(yeni_kisi_id.Text));

            yeni_sqlCommand.ExecuteNonQuery();
            

            button2_Click(sender, e);
            //buttona t�klatarak sayfay� yeniletiyoruz
        }


        //solid nedir


    }
}