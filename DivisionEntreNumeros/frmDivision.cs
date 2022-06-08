using System;
using System.Windows.Forms;

namespace DivisionEntreNumeros
{
  public partial class frmDivision : Form
  {

    public frmDivision()
    {
      InitializeComponent();
    }
    float resultado;  // declaro variable para poder usar en cualquier lugar
    private void frmDivision_Load(object sender, EventArgs e)
    {
      label1.Text = "Dividendo";
      label2.Text = "Divisor";
    }
    private void btnCalcular_Click(object sender, EventArgs e)
    {
      try  // el comando try --> tratará de realizar la acción solicitada (esto es una trampa de errores)
      {
        float v01 = float.Parse(txtV01.Text); // convierte a resultado a float ( float es parecido a double / decimal )
        float v02 = float.Parse(txtV02.Text); // convierte a resultado a float ( float es parecido a double / decimal )
        //* ----------------------------------------------------------
        //! coloca aqui la operación de División según el radio button
        //* ----------------------------------------------------------
        if (rbtnDividir.Checked == true)
        {
          resultado = v01 / v02;   // realiza la operación de dividir
        }
        //* -------------------------------------------------------------
        // !coloca aqui la operación de Multiplicar según el radio button
        //* -------------------------------------------------------------
        if (rbtnMultiplica.Checked == true)
        {
          resultado = v01 * v02;   // realiza la operación de multiplicar
        }
        //* ---------------------------------------------------------
        //! coloca aqui la operación sumar según el radio button
        //* ---------------------------------------------------------
        if (rbtnSumar.Checked == true)
        {
          resultado = v01 + v02;   // realiza la operación de Sumar
        }
        //* ---------------------------------------------------------
        //! coloca aqui la operación Porciento según el radio button
        //* ---------------------------------------------------------
        if (rbtnPorciento.Checked == true)
        {
          resultado = (v01 * v02) / 100;   // realiza la operación de obtener el porciento
        }
        //* ---------------------------------------------------------
        //! asigna el Resultado
        //* ---------------------------------------------------------
        lblResultado.Text = Convert.ToString(resultado); // convierte a resultado a string
      }
      catch (Exception error)  // de haber algún error es atrapado por el comando --> catch
      {
        MessageBox.Show("Tengo Un Error : " + error.Message);  // de haber error aparece una caja de mensajes
      }
    }


    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      txtV01.Clear();  // Clear --> Limpiar el textbox dividendo
      txtV02.Clear();    // Clear --> Limpiar el textbox divisor
      lblResultado.Text = ""; // limpiar este label

      rbtnDividir.Checked = true; // se vera marcado el radio button

      lblResultado.Text = ""; // limpiar este label

      txtV01.Focus();  // Focus --> El puntero del mouse se coloca en este textbox
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();   // cierra la aplicación
    }

    public void rbtnDividir_CheckedChanged(object sender, EventArgs e)
    {
      label1.Text = "Dividendo";
      label2.Text = "Divisor";
    }

    private void rbtnMultiplica_CheckedChanged(object sender, EventArgs e)
    {
      label1.Text = "Multiplicando";
      label2.Text = "Multiplicador";

    }

    private void rbtnPorciento_CheckedChanged(object sender, EventArgs e)
    {
      label1.Text = "Cantidad";
      label2.Text = "Porcentaje";

    }

    private void rbtnSumar_CheckedChanged(object sender, EventArgs e)
    {
      label1.Text = "Sumando (a)";
      label2.Text = "Sumando (b)";

    }
    // !  Comportamientos de la aplicación
    // TODO: El programa tiene un evento en el boton enter Funciona como aceptar y salta directo al  Botonn calcular

    private void txtV01_Validated(object sender, EventArgs e) //Validate para que no se salten los numeros y tener una mejor ejecucion
    {
      if (txtV01.Text == string.Empty) //Restricciion para no dejar campos vacios
      {
        MessageBox.Show("Debe Completar el Campo");
        txtV01.Focus();

      }
      {
        txtV02.Enabled = true; //Hbilitando el texbox 2 para que pueda ser usado despues de rellenar el textbox 1
      }
    }

    private void txtV01_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Char.IsLetter(e.KeyChar)) // Solo permitir numeros en el             
      {
        e.Handled = true;
        MessageBox.Show("Solo numeros");
      }
      KeyPreview = true;
    }

    private void txtV02_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Char.IsLetter(e.KeyChar)) // Solo permitir numeros en el texto            
      {
        e.Handled = true;
        MessageBox.Show("Solo numeros");
      }
      KeyPreview = true;
    }


  }

}
