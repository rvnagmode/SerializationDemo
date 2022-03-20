using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"D:\Dept.Json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\Dept.Json",FileMode.Open,FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"D:\DeptXml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptXml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"D:\DeptBinary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptBinary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter(); 
                dept = (Department)bf.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"D:\DeptSoap.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptSoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                dept = (Department)sf.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
