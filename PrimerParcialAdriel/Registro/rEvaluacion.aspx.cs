using BLL;
using Entidades;
using PrimerParcialAdriel.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerParcialAdriel.Registro
{
    public partial class rEvaluacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["Evaluacion"] = new Evaluacion();
                Limpiar();
                BindGrid();
            }
        }
        private Evaluacion LlenaClase()
        {
            Evaluacion evaluacion = new Evaluacion();

            evaluacion = (Evaluacion)ViewState["Evaluacion"];
            evaluacion.EvalucionId = Utils.ToInt(EvaluacionIdTextBox.Text);
            evaluacion.Fecha = Utils.ToDateTime(FechaTextBox.Text);
            evaluacion.Estudiante = EstudianteTextBox.Text;
            evaluacion.Total = Utils.ToDecimal(ToTalTextBox.Text);
           

            return evaluacion;
        }
        protected void BindGrid()
        {
            if (ViewState["Evaluacion"] != null)
            {
                GridView.DataSource = ((Evaluacion)ViewState["Evalaucion"]).Detalle;
                GridView.DataBind();

            }

        }
        private void Limpiar()
        {
            EvaluacionIdTextBox.Text = "0";
            FechaTextBox.Text = DateTime.Now.ToString();

            EstudianteTextBox.Text = string.Empty;
            CategoriaTextBox.Text = string.Empty;
            ValorTextBox.Text = "0";
            LogradoTextBox.Text = "0";
            ToTalTextBox.Text = "0";
            GridView.DataSource = null;
            GridView.DataBind();


        }
        private bool ExisteBaseDato()
        {
            RepositorioBase<Evaluacion> rep = new RepositorioBase<Evaluacion>();
            Evaluacion evaluacion = new Evaluacion();

            evaluacion = rep.Buscar(Utils.ToInt(EvaluacionIdTextBox.Text));
            return (evaluacion != null);


        }
        private void LlenaCampo(Evaluacion evaluacion)
        {
            EvaluacionIdTextBox.Text = Convert.ToString(evaluacion.EvalucionId);
            FechaTextBox.Text = evaluacion.Fecha.ToString();
            EstudianteTextBox.Text = evaluacion.Estudiante;


            ViewState["Evaluacion"] = evaluacion.Detalle;
            this.DataBind();
       
        }




        protected void buscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Evaluacion> rep = new RepositorioBase<Evaluacion>();
            Evaluacion evaluacion = new Evaluacion();

            evaluacion = rep.Buscar(Utils.ToInt(EvaluacionIdTextBox.Text));

           if(evaluacion != null)
            {
                LlenaCampo(evaluacion);

            }
            else{

                Utils.ShowToastr(this.Page, "Error", "error", "error");
            }



        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Evaluacion> rep = new RepositorioBase<Evaluacion>();
            Evaluacion evaluacion = new Evaluacion();

            bool paso = false;

            evaluacion = LlenaClase();

            if(Utils.ToInt(EvaluacionIdTextBox.Text) == 0)
            {
                paso = rep.Guardar(evaluacion);
               
            }
            else
            {
                if(!ExisteBaseDato())
                {
                    Utils.ShowToastr(this.Page, "Persona no existe ", "error", "error");
                    return;
                }
                paso = rep.Modificar(evaluacion);
            }
            
            if(paso)
            {
                Utils.ShowToastr(this.Page, "Perfecto", "succes", "succes");
            }
            else
            {
                Utils.ShowToastr(this.Page, "Error", "error", "error");
            }
            Limpiar();

        }

        protected void eliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Evaluacion> rep = new RepositorioBase<Evaluacion>();
            Evaluacion evaluacion = new Evaluacion();

            evaluacion = rep.Buscar(Utils.ToInt(EvaluacionIdTextBox.Text));

            if (evaluacion != null)
            {
                rep.Eliminar(Utils.ToInt(EvaluacionIdTextBox.Text));
                Utils.ShowToastr(this.Page, "Perfecto", "succes", "succes");
            }
            else
            {
                Utils.ShowToastr(this.Page, "Error", "error", "error");
            }
            Limpiar();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            Evaluacion evaluacion = new Evaluacion();
            evaluacion = (Evaluacion)ViewState["Evaluacion"];

            decimal Perdido = 0;
            
            Perdido = Utils.ToDecimal(ValorTextBox.Text) - Utils.ToDecimal(LogradoTextBox.Text);

            evaluacion.Detalle.Add(new DetalleEvaluacion(CategoriaTextBox.Text, Utils.ToDecimal(ValorTextBox.Text), Utils.ToDecimal(LogradoTextBox.Text),Perdido));

            ViewState["Detalle"] = evaluacion.Detalle;
            this.DataBind();

            ToTalTextBox.Text = Convert.ToString(Perdido + evaluacion.Total);
           

        }
    }
}