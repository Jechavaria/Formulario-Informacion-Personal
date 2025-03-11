using System.Windows.Forms;

namespace Formulario
{
    partial class frmInformacionPersonal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionPersonal));
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblInformacionPersonal = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbInformacionPersonal = new System.Windows.Forms.GroupBox();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbInformacionPersonal.SuspendLayout();
            this.gbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            resources.ApplyResources(this.txtDocumento, "txtDocumento");
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtTelefono
            // 
            resources.ApplyResources(this.txtTelefono, "txtTelefono");
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblDocumento
            // 
            resources.ApplyResources(this.lblDocumento, "lblDocumento");
            this.lblDocumento.Name = "lblDocumento";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // lblApellido
            // 
            resources.ApplyResources(this.lblApellido, "lblApellido");
            this.lblApellido.Name = "lblApellido";
            // 
            // lblTelefono
            // 
            resources.ApplyResources(this.lblTelefono, "lblTelefono");
            this.lblTelefono.Name = "lblTelefono";
            // 
            // lblInformacionPersonal
            // 
            resources.ApplyResources(this.lblInformacionPersonal, "lblInformacionPersonal");
            this.lblInformacionPersonal.Name = "lblInformacionPersonal";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtApellido
            // 
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.Name = "txtApellido";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.Name = "txtCorreo";
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbInformacionPersonal
            // 
            this.gbInformacionPersonal.Controls.Add(this.txtDocumento);
            this.gbInformacionPersonal.Controls.Add(this.lblDocumento);
            this.gbInformacionPersonal.Controls.Add(this.lblNombre);
            this.gbInformacionPersonal.Controls.Add(this.lblApellido);
            this.gbInformacionPersonal.Controls.Add(this.txtNombre);
            this.gbInformacionPersonal.Controls.Add(this.txtApellido);
            resources.ApplyResources(this.gbInformacionPersonal, "gbInformacionPersonal");
            this.gbInformacionPersonal.Name = "gbInformacionPersonal";
            this.gbInformacionPersonal.TabStop = false;
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.lblCorreo);
            this.gbContacto.Controls.Add(this.lblTelefono);
            this.gbContacto.Controls.Add(this.txtCorreo);
            this.gbContacto.Controls.Add(this.txtTelefono);
            resources.ApplyResources(this.gbContacto, "gbContacto");
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.TabStop = false;
            // 
            // lblCorreo
            // 
            resources.ApplyResources(this.lblCorreo, "lblCorreo");
            this.lblCorreo.Name = "lblCorreo";
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmInformacionPersonal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.gbInformacionPersonal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblInformacionPersonal);
            this.Name = "frmInformacionPersonal";
            this.gbInformacionPersonal.ResumeLayout(false);
            this.gbInformacionPersonal.PerformLayout();
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblInformacionPersonal;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbInformacionPersonal;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

