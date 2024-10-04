using System.Windows.Forms;

namespace ArchivosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DgvPerfil.Columns.Add("columna1", "Nombre");
            DgvPerfil.Columns.Add("columna2", "Edad");
            DgvPerfil.Columns.Add("columna2", "Genero");
            DgvPerfil.Columns.Add("columna2", "Nota");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.OpenOrCreate, FileAccess.Write);
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                string nombre = TbNombre.Text;
                int edad = int.Parse(TbEdad.Text);
                int nota = int.Parse(TbNota.Text);
                char genero = char.Parse(TbGenero.Text);

                Escritor.Write(nombre.Length);
                Escritor.Write(nombre.ToCharArray());
                Escritor.Write(edad);
                Escritor.Write(nota);
                Escritor.Write(genero);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read);
            using (BinaryReader Lector = new BinaryReader(mArchivoLector))
            {
                int length = Lector.ReadInt32();
                char[] nombreArray = Lector.ReadChars(length);
                string nombre = new string(nombreArray);
                int edad = Lector.ReadInt32();
                int nota = Lector.ReadInt32();
                char genero = Lector.ReadChar();

                DgvPerfil.Rows.Add(nombre, edad, genero, nota);
            }
        }
    }
}
