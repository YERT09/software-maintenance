using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAM_tecnicas
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contex = new MantenimientoEntities1())
                {
                    var ingreso = contex.ingreso.ToList();
                    int num = ingreso.FindIndex(x => x.usuario == user_ingreso.Text);
                    if (num >= 0 && ingreso[num].contraseña == pass_ingreso.Text)
                    {
                        user_ingreso.Text = "";
                        pass_ingreso.Text = "";
                        SECUNDARIO secundario = new SECUNDARIO();
                        secundario.Visible = true;
                        Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña invalidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pass_ingreso.Text = "";
                        user_ingreso.Text = "";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (pass_nuevo.Text == pass_confir.Text)
            {
                try
                {
                    using (var contex = new MantenimientoEntities1())
                    {
                        if (!contex.ingreso.ToList().Exists(x => x.usuario == user_nuevo.Text))
                        {
                            contex.ingreso.Add(new ingreso { usuario = user_nuevo.Text, contraseña = pass_confir.Text });
                            contex.SaveChanges();
                            MessageBox.Show("EL USUARIO SE HA INGRESADO CORRECTAMENTE", "USUARIO ACEPTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            user_nuevo.Text = "";
                            pass_confir.Text = "";
                            pass_nuevo.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("EL USUARIO YA EXISTE", "USUARIO ACEPTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            user_nuevo.Text = "";
                            pass_confir.Text = "";
                            pass_nuevo.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("La contraseña no coincide", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void INGRESO_Click(object sender, EventArgs e)
        {
            pass_ingreso.Text = "";
            user_ingreso.Text = "";
        }
    }
}
