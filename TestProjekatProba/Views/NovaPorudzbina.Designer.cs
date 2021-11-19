
namespace TestProjekatProba.Views
{
    partial class NovaPorudzbina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderid = new System.Windows.Forms.Label();
            this.tEST_DOODataSet3 = new TestProjekatProba.TEST_DOODataSet3();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new TestProjekatProba.TEST_DOODataSet3TableAdapters.OrderDetailsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tEST_DOODataSet4 = new TestProjekatProba.TEST_DOODataSet4();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TestProjekatProba.TEST_DOODataSet4TableAdapters.ProductsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tEST_DOODataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEST_DOODataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtOrderID.Location = new System.Drawing.Point(147, 51);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(71, 31);
            this.txtOrderID.TabIndex = 0;
            // 
            // lblOrderid
            // 
            this.lblOrderid.AutoSize = true;
            this.lblOrderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblOrderid.Location = new System.Drawing.Point(69, 60);
            this.lblOrderid.Name = "lblOrderid";
            this.lblOrderid.Size = new System.Drawing.Size(60, 17);
            this.lblOrderid.TabIndex = 1;
            this.lblOrderid.Text = "Order id";
            // 
            // tEST_DOODataSet3
            // 
            this.tEST_DOODataSet3.DataSetName = "TEST_DOODataSet3";
            this.tEST_DOODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.tEST_DOODataSet3;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "productname", true));
            this.comboBox1.DataSource = this.productsBindingSource;
            this.comboBox1.DisplayMember = "productname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "productname";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tEST_DOODataSet4
            // 
            this.tEST_DOODataSet4.DataSetName = "TEST_DOODataSet4";
            this.tEST_DOODataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.tEST_DOODataSet4;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(69, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberi Proizvod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(437, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order id";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox1.Location = new System.Drawing.Point(515, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 31);
            this.textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "productname", true));
            this.listBox1.DataSource = this.productsBindingSource;
            this.listBox1.DisplayMember = "productname";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(63, 172);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 212);
            this.listBox1.TabIndex = 6;
            this.listBox1.ValueMember = "productname";
            this.listBox1.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(577, 194);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(211, 20);
            this.txtshow.TabIndex = 7;
            this.txtshow.TextChanged += new System.EventHandler(this.txtshow_TextChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(338, 193);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(210, 225);
            this.listBox2.TabIndex = 8;
            // 
            // NovaPorudzbina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblOrderid);
            this.Controls.Add(this.txtOrderID);
            this.Name = "NovaPorudzbina";
            this.Text = "NovaPorudzbina";
            this.Load += new System.EventHandler(this.NovaPorudzbina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tEST_DOODataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEST_DOODataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderid;
        private TEST_DOODataSet3 tEST_DOODataSet3;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private TEST_DOODataSet3TableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private TEST_DOODataSet4 tEST_DOODataSet4;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TEST_DOODataSet4TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.ListBox listBox2;
    }
}