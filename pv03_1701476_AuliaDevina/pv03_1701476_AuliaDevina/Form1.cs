
using pv03_1701476_AuliaDevina.Model;
using pv03_1701476_AuliaDevina.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_1701476_AuliaDevina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitNim_Click(object sender, EventArgs e)
        {
            TodoRepository todo = new TodoRepository();

            tbNim.Enabled = false;

            string nim = tbNim.Text;

            btnAdd.Enabled = true;
            submitNim.Enabled = false;

            dataGridView1.DataSource = todo.getByNim(nim);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.NimMhs = tbNim.Text;
            temp.Nama = tbNama.Text;
            temp.Kategori = tbKategori.Text;

            TodoRepository todo = new TodoRepository();

            todo.addTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt32(idDel.Text);

            TodoRepository todo = new TodoRepository();

            todo.deleteTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt32(idUp.Text);
            temp.Nama = namaUp.Text;
            temp.Kategori = kategoriUp.Text;

            TodoRepository todo = new TodoRepository();

            todo.updateTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }
    }
}
